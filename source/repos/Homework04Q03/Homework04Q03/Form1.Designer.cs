namespace Homework04Q03
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
            this.nBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.eBox = new System.Windows.Forms.RichTextBox();
            this.LB2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LB1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // nBox
            // 
            this.nBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nBox.Location = new System.Drawing.Point(133, 113);
            this.nBox.Name = "nBox";
            this.nBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nBox.Size = new System.Drawing.Size(125, 36);
            this.nBox.TabIndex = 0;
            this.nBox.Text = "";
            this.nBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(264, 113);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(32, 36);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "!";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(403, 113);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(47, 36);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "e =";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // eBox
            // 
            this.eBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBox.Location = new System.Drawing.Point(456, 113);
            this.eBox.Name = "eBox";
            this.eBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.eBox.Size = new System.Drawing.Size(301, 36);
            this.eBox.TabIndex = 3;
            this.eBox.Text = "";
            // 
            // LB2
            // 
            this.LB2.FormattingEnabled = true;
            this.LB2.ItemHeight = 16;
            this.LB2.Location = new System.Drawing.Point(403, 173);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(354, 244);
            this.LB2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LB1
            // 
            this.LB1.HideSelection = false;
            this.LB1.Location = new System.Drawing.Point(403, 173);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(354, 244);
            this.LB1.TabIndex = 6;
            this.LB1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.eBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox nBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox eBox;
        private System.Windows.Forms.ListBox LB2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView LB1;
    }
}

