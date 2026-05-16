using static typetext.Logic.Program;
namespace TypeDeck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void RunBtn_Click(object sender, EventArgs e)
        {
            string code = CodeEditor.Text;
            _ = Task.Run(() => Run(code));
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
            string code = "close";
            _ = Task.Run(() => Run(code));
        }
    }
}
