using static typetext.Logic.Program;
using static typetext.Logic.Files;
namespace TypeDeck
{
    public partial class Form1 : Form
    {
        public static Task current;
        public static bool enter = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void RunBtn_Click(object sender, EventArgs e)
        {
            string code = CodeEditor.Text;
            current = Task.Run(() => Run(code));
            Start();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                if (FileName.Text.Length > 0)
                {
                    SaveFile(CodeEditor.Text, FileName.Text);
                    _ = Task.Run(() => Reset(Color.Green));
                }                       
                else
                    _ = Task.Run(() => Reset(Color.Red));
                e.Handled = true;
            }
            if (e.Control && e.KeyCode == Keys.O)
            {
                if (FileName.Text.Length > 0)
                {
                    CodeEditor.Text = LoadFile(FileName.Text);
                    _ = Task.Run(() => Reset(Color.Green));
                }
                else
                    _ = Task.Run(() => Reset(Color.Red));
                e.Handled = true;
            }

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                if (enter)
                    RunBtn_Click(sender, e);
            }
        }
        private void EnterInput(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && InputBox.Text.Replace(" ", "") != "")
            {
                SubmitInput(InputBox.Text);
                InputBox.Text = "";
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        private void Supress(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        private void ConditionedSupress(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.S || e.KeyCode == Keys.Enter || e.KeyCode == Keys.O))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private async void Reset(Color color)
        {
            label5.ForeColor = color;
            await Task.Delay(1300);
            label5.ForeColor = Color.Black;
        }
        private async void Start()
        {

            RunBtn.BackColor = Color.Gray;
            RunBtn.Enabled = false;
            enter = false;
            await Task.Delay(1000);
            RunBtn.BackColor = Color.FromArgb(128, 255, 128);
            RunBtn.Enabled = true;
            enter = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataBus += UpdateOutput;
            Errors += UpdateErrors;
        }
        private void UpdateOutput(List<string> currentOutputs)
        {
            if (Outputs.InvokeRequired)
                Outputs.Invoke(new Action(() => UpdateOutput(currentOutputs)));
            else
            {
                Outputs.Text = string.Join(Environment.NewLine, currentOutputs);
                Outputs.SelectionStart = Outputs.Text.Length;
                Outputs.ScrollToCaret();
            }
        }
        private void UpdateErrors(List<string> currentErrors)
        {
            if (StackOverflow.InvokeRequired)
                StackOverflow.Invoke(new Action(() => UpdateErrors(currentErrors)));
            else
            {
                StackOverflow.Text = string.Join(Environment.NewLine, currentErrors);
                StackOverflow.SelectionStart = StackOverflow.Text.Length;
                StackOverflow.ScrollToCaret();
            }
        }
        private void UpdateInput(bool currentInputState)
        {
            InputBox.ForeColor = inputing ? Color.Green : Color.DarkBlue;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBus -= UpdateOutput;
            Errors -= UpdateErrors;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            run = false;
            Output = [];
            send();
        }
    }
}
