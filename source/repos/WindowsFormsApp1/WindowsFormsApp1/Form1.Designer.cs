namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.nBox = new System.Windows.Forms.RichTextBox();
            this.sBox = new System.Windows.Forms.RichTextBox();
            this.fBox = new System.Windows.Forms.RichTextBox();
            this.rBox = new System.Windows.Forms.RichTextBox();
            this.ssBox = new System.Windows.Forms.RichTextBox();
            this.tBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 25);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Employee name: ";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(13, 60);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(198, 25);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Employee\'s total weekly sales: ";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(13, 265);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(198, 25);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "Federal tax (18%): ";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox4.Enabled = false;
            this.richTextBox4.Location = new System.Drawing.Point(13, 327);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(198, 25);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "Retirement Contribution (15%): ";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox5.Enabled = false;
            this.richTextBox5.Location = new System.Drawing.Point(13, 389);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(198, 25);
            this.richTextBox5.TabIndex = 5;
            this.richTextBox5.Text = "Social Security (9%): ";
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(237, 12);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(190, 26);
            this.nBox.TabIndex = 6;
            this.nBox.Text = "";
            // 
            // sBox
            // 
            this.sBox.Location = new System.Drawing.Point(237, 59);
            this.sBox.Name = "sBox";
            this.sBox.Size = new System.Drawing.Size(190, 26);
            this.sBox.TabIndex = 7;
            this.sBox.Text = "";
            // 
            // fBox
            // 
            this.fBox.Location = new System.Drawing.Point(237, 264);
            this.fBox.Name = "fBox";
            this.fBox.Size = new System.Drawing.Size(190, 26);
            this.fBox.TabIndex = 8;
            this.fBox.Text = "";
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(237, 326);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(190, 26);
            this.rBox.TabIndex = 9;
            this.rBox.Text = "";
            // 
            // ssBox
            // 
            this.ssBox.Location = new System.Drawing.Point(237, 388);
            this.ssBox.Name = "ssBox";
            this.ssBox.Size = new System.Drawing.Size(190, 26);
            this.ssBox.TabIndex = 10;
            this.ssBox.Text = "";
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(186, 470);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(190, 26);
            this.tBox.TabIndex = 11;
            this.tBox.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox7.Enabled = false;
            this.richTextBox7.Location = new System.Drawing.Point(118, 430);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(198, 25);
            this.richTextBox7.TabIndex = 12;
            this.richTextBox7.Text = "Total Net Pay:";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox6.Enabled = false;
            this.richTextBox6.Location = new System.Drawing.Point(118, 212);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(198, 25);
            this.richTextBox6.TabIndex = 13;
            this.richTextBox6.Text = "Deductions:";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(13, 512);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 39);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 563);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.ssBox);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.fBox);
            this.Controls.Add(this.sBox);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox nBox;
        private System.Windows.Forms.RichTextBox sBox;
        private System.Windows.Forms.RichTextBox fBox;
        private System.Windows.Forms.RichTextBox rBox;
        private System.Windows.Forms.RichTextBox ssBox;
        private System.Windows.Forms.RichTextBox tBox;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button2;
    }
}

