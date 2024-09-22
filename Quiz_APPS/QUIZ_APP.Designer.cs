namespace Quiz_APPS
{
    partial class QUIZ_APP
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
            this.richTextBox1_Questions = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOption1 = new System.Windows.Forms.RadioButton();
            this.button_Next = new System.Windows.Forms.Button();
            this.radioButtonOption2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1_Questions
            // 
            this.richTextBox1_Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1_Questions.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1_Questions.Name = "richTextBox1_Questions";
            this.richTextBox1_Questions.Size = new System.Drawing.Size(575, 123);
            this.richTextBox1_Questions.TabIndex = 0;
            this.richTextBox1_Questions.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 4);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonOption1
            // 
            this.radioButtonOption1.AutoSize = true;
            this.radioButtonOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption1.Location = new System.Drawing.Point(12, 188);
            this.radioButtonOption1.Name = "radioButtonOption1";
            this.radioButtonOption1.Size = new System.Drawing.Size(152, 29);
            this.radioButtonOption1.TabIndex = 2;
            this.radioButtonOption1.TabStop = true;
            this.radioButtonOption1.Text = "radioButton1";
            this.radioButtonOption1.UseVisualStyleBackColor = true;
            this.radioButtonOption1.Click += new System.EventHandler(this.radioButtonOption1_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_Next.Location = new System.Drawing.Point(79, 372);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(416, 47);
            this.button_Next.TabIndex = 3;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // radioButtonOption2
            // 
            this.radioButtonOption2.AutoSize = true;
            this.radioButtonOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption2.Location = new System.Drawing.Point(12, 232);
            this.radioButtonOption2.Name = "radioButtonOption2";
            this.radioButtonOption2.Size = new System.Drawing.Size(152, 29);
            this.radioButtonOption2.TabIndex = 4;
            this.radioButtonOption2.TabStop = true;
            this.radioButtonOption2.Text = "radioButton2";
            this.radioButtonOption2.UseVisualStyleBackColor = true;
            this.radioButtonOption2.Click += new System.EventHandler(this.radioButtonOption2_Click);
            // 
            // radioButtonOption3
            // 
            this.radioButtonOption3.AutoSize = true;
            this.radioButtonOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption3.Location = new System.Drawing.Point(12, 281);
            this.radioButtonOption3.Name = "radioButtonOption3";
            this.radioButtonOption3.Size = new System.Drawing.Size(152, 29);
            this.radioButtonOption3.TabIndex = 5;
            this.radioButtonOption3.TabStop = true;
            this.radioButtonOption3.Text = "radioButton3";
            this.radioButtonOption3.UseVisualStyleBackColor = true;
            this.radioButtonOption3.Click += new System.EventHandler(this.radioButtonOption3_Click);
            // 
            // radioButtonOption4
            // 
            this.radioButtonOption4.AutoSize = true;
            this.radioButtonOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption4.Location = new System.Drawing.Point(12, 326);
            this.radioButtonOption4.Name = "radioButtonOption4";
            this.radioButtonOption4.Size = new System.Drawing.Size(152, 29);
            this.radioButtonOption4.TabIndex = 6;
            this.radioButtonOption4.TabStop = true;
            this.radioButtonOption4.Text = "radioButton4";
            this.radioButtonOption4.UseVisualStyleBackColor = true;
            this.radioButtonOption4.Click += new System.EventHandler(this.radioButtonOption4_Click);
            // 
            // QUIZ_APP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 457);
            this.Controls.Add(this.radioButtonOption4);
            this.Controls.Add(this.radioButtonOption3);
            this.Controls.Add(this.radioButtonOption2);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.radioButtonOption1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1_Questions);
            this.Name = "QUIZ_APP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUIZ_APP";
            this.Load += new System.EventHandler(this.QUIZ_APP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1_Questions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOption1;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.RadioButton radioButtonOption2;
        private System.Windows.Forms.RadioButton radioButtonOption3;
        private System.Windows.Forms.RadioButton radioButtonOption4;
    }
}