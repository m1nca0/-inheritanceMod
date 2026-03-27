namespace InheritanceMod
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
            button1 = new Button();
            txtInfo = new RichTextBox();
            txtOut = new RichTextBox();
            button2 = new Button();
            listOut = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(370, 23);
            button1.TabIndex = 0;
            button1.Text = "Перезаполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(12, 41);
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(370, 54);
            txtInfo.TabIndex = 1;
            txtInfo.Text = "";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 202);
            txtOut.Name = "txtOut";
            txtOut.ReadOnly = true;
            txtOut.Size = new Size(306, 96);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(324, 199);
            button2.Name = "button2";
            button2.Size = new Size(58, 96);
            button2.TabIndex = 3;
            button2.Text = "Взять";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listOut
            // 
            listOut.Location = new Point(12, 100);
            listOut.Name = "listOut";
            listOut.ReadOnly = true;
            listOut.Size = new Size(370, 96);
            listOut.TabIndex = 4;
            listOut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 307);
            Controls.Add(listOut);
            Controls.Add(button2);
            Controls.Add(txtOut);
            Controls.Add(txtInfo);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox txtInfo;
        private RichTextBox txtOut;
        private Button button2;
        private RichTextBox listOut;
    }
}
