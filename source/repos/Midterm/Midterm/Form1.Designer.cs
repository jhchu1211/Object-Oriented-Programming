namespace Midterm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lister = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(12, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(313, 45);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "How many numbers would you like to generate?";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(349, 42);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(141, 24);
            this.nBox.TabIndex = 1;
            this.nBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 90);
            this.button1.TabIndex = 2;
            this.button1.Text = "Separate Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lister
            // 
            this.lister.FormattingEnabled = true;
            this.lister.ItemHeight = 16;
            this.lister.Location = new System.Drawing.Point(12, 266);
            this.lister.Name = "lister";
            this.lister.Size = new System.Drawing.Size(478, 244);
            this.lister.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 559);
            this.Controls.Add(this.lister);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox nBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lister;
    }
}

