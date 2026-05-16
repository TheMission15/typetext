namespace TypeDeck
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CodeEditor = new TextBox();
            Outputs = new RichTextBox();
            RunBtn = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            StopBtn = new Button();
            StackOverflow = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // CodeEditor
            // 
            CodeEditor.Location = new Point(50, 79);
            CodeEditor.Multiline = true;
            CodeEditor.Name = "CodeEditor";
            CodeEditor.Size = new Size(481, 609);
            CodeEditor.TabIndex = 0;
            // 
            // Outputs
            // 
            Outputs.Location = new Point(1105, 131);
            Outputs.Name = "Outputs";
            Outputs.Size = new Size(123, 439);
            Outputs.TabIndex = 1;
            Outputs.Text = "";
            // 
            // RunBtn
            // 
            RunBtn.BackColor = Color.FromArgb(128, 255, 128);
            RunBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RunBtn.Location = new Point(854, 59);
            RunBtn.Name = "RunBtn";
            RunBtn.Size = new Size(192, 63);
            RunBtn.TabIndex = 2;
            RunBtn.Text = "Run";
            RunBtn.UseVisualStyleBackColor = false;
            RunBtn.Click += RunBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(255, 128, 128);
            ExitBtn.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitBtn.Location = new Point(854, 306);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(192, 63);
            ExitBtn.TabIndex = 3;
            ExitBtn.Text = "Close Window";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(1105, 87);
            label1.Name = "label1";
            label1.Size = new Size(100, 35);
            label1.TabIndex = 4;
            label1.Text = "Output";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label2.ForeColor = Color.Lavender;
            label2.Location = new Point(50, 16);
            label2.Name = "label2";
            label2.Size = new Size(150, 60);
            label2.TabIndex = 5;
            label2.Text = "Editor";
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.FromArgb(255, 128, 0);
            StopBtn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StopBtn.Location = new Point(854, 131);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(192, 63);
            StopBtn.TabIndex = 6;
            StopBtn.Text = "Stop Program";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // StackOverflow
            // 
            StackOverflow.Location = new Point(854, 690);
            StackOverflow.Name = "StackOverflow";
            StackOverflow.Size = new Size(774, 174);
            StackOverflow.TabIndex = 7;
            StackOverflow.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(854, 652);
            label3.Name = "label3";
            label3.Size = new Size(84, 35);
            label3.TabIndex = 8;
            label3.Text = "Errors";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(2297, 1047);
            Controls.Add(label3);
            Controls.Add(StackOverflow);
            Controls.Add(StopBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ExitBtn);
            Controls.Add(RunBtn);
            Controls.Add(Outputs);
            Controls.Add(CodeEditor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "TypeDeck";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CodeEditor;
        private RichTextBox Outputs;
        private Button RunBtn;
        private Button ExitBtn;
        private Label label1;
        private Label label2;
        private Button StopBtn;
        private RichTextBox StackOverflow;
        private Label label3;
    }
}
