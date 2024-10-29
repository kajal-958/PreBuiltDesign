namespace PrebuiltDesigns
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
            btnOpen = new Button();
            txtFileContent = new TextBox();
            btnSave = new Button();
            btnFont = new Button();
            label1 = new Label();
            rtxFileContent = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(588, 70);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open File";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += button1_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(91, 135);
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(293, 27);
            txtFileContent.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(588, 124);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button2_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(104, 43);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(94, 29);
            btnFont.TabIndex = 3;
            btnFont.Text = "Font";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 96);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 4;
            label1.Text = "TXT";
            // 
            // rtxFileContent
            // 
            rtxFileContent.Location = new Point(91, 229);
            rtxFileContent.Name = "rtxFileContent";
            rtxFileContent.Size = new Size(307, 120);
            rtxFileContent.TabIndex = 5;
            rtxFileContent.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 190);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 6;
            label2.Text = "RTX";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(rtxFileContent);
            Controls.Add(label1);
            Controls.Add(btnFont);
            Controls.Add(btnSave);
            Controls.Add(txtFileContent);
            Controls.Add(btnOpen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpen;
        private TextBox txtFileContent;
        private Button btnSave;
        private Button btnFont;
        private Label label1;
        private RichTextBox rtxFileContent;
        private Label label2;
    }
}
