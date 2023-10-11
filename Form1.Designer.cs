namespace WinFormsApp1
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
            button1_sendtotally = new Button();
            logTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // button1_sendtotally
            // 
            button1_sendtotally.Location = new Point(108, 202);
            button1_sendtotally.Margin = new Padding(2, 2, 2, 2);
            button1_sendtotally.Name = "button1_sendtotally";
            button1_sendtotally.Size = new Size(173, 26);
            button1_sendtotally.TabIndex = 0;
            button1_sendtotally.Text = "Send to tally";
            button1_sendtotally.UseVisualStyleBackColor = true;
            button1_sendtotally.Click += button1_sendtotally_Click;
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(59, 53);
            logTextBox.Margin = new Padding(2, 2, 2, 2);
            logTextBox.Name = "logTextBox";
            logTextBox.Size = new Size(319, 95);
            logTextBox.TabIndex = 1;
            logTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 415);
            Controls.Add(logTextBox);
            Controls.Add(button1_sendtotally);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1_sendtotally;
        private RichTextBox logTextBox;
    }
}