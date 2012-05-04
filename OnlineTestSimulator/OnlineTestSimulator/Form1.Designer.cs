namespace OnlineTestSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_D = new System.Windows.Forms.RadioButton();
            this.radio_C = new System.Windows.Forms.RadioButton();
            this.radio_B = new System.Windows.Forms.RadioButton();
            this.radio_A = new System.Windows.Forms.RadioButton();
            this.lbl_QuestionCounter = new System.Windows.Forms.Label();
            this.btn_EndTest = new System.Windows.Forms.Button();
            this.btn_ShowAns = new System.Windows.Forms.Button();
            this.lbl_ShowAns = new System.Windows.Forms.Label();
            this.btn_Review = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // lbl_Question
            // 
            this.lbl_Question.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(27, 26);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(584, 277);
            this.lbl_Question.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Answer";
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(65, 379);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(68, 23);
            this.btn_Prev.TabIndex = 7;
            this.btn_Prev.Text = "Previous";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(150, 379);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(68, 23);
            this.btn_Next.TabIndex = 8;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_D);
            this.groupBox1.Controls.Add(this.radio_C);
            this.groupBox1.Controls.Add(this.radio_B);
            this.groupBox1.Controls.Add(this.radio_A);
            this.groupBox1.Location = new System.Drawing.Point(25, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 45);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radio_D
            // 
            this.radio_D.AutoSize = true;
            this.radio_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_D.Location = new System.Drawing.Point(160, 14);
            this.radio_D.Name = "radio_D";
            this.radio_D.Size = new System.Drawing.Size(36, 21);
            this.radio_D.TabIndex = 10;
            this.radio_D.TabStop = true;
            this.radio_D.Text = "D";
            this.radio_D.UseVisualStyleBackColor = true;
            this.radio_D.CheckedChanged += new System.EventHandler(this.radio_D_CheckedChanged);
            // 
            // radio_C
            // 
            this.radio_C.AutoSize = true;
            this.radio_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_C.Location = new System.Drawing.Point(109, 14);
            this.radio_C.Name = "radio_C";
            this.radio_C.Size = new System.Drawing.Size(35, 21);
            this.radio_C.TabIndex = 9;
            this.radio_C.TabStop = true;
            this.radio_C.Text = "C";
            this.radio_C.UseVisualStyleBackColor = true;
            this.radio_C.CheckedChanged += new System.EventHandler(this.radio_C_CheckedChanged);
            // 
            // radio_B
            // 
            this.radio_B.AutoSize = true;
            this.radio_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_B.Location = new System.Drawing.Point(63, 14);
            this.radio_B.Name = "radio_B";
            this.radio_B.Size = new System.Drawing.Size(35, 21);
            this.radio_B.TabIndex = 8;
            this.radio_B.TabStop = true;
            this.radio_B.Text = "B";
            this.radio_B.UseVisualStyleBackColor = true;
            this.radio_B.CheckedChanged += new System.EventHandler(this.radio_B_CheckedChanged);
            // 
            // radio_A
            // 
            this.radio_A.AutoSize = true;
            this.radio_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_A.Location = new System.Drawing.Point(16, 14);
            this.radio_A.Name = "radio_A";
            this.radio_A.Size = new System.Drawing.Size(35, 21);
            this.radio_A.TabIndex = 7;
            this.radio_A.TabStop = true;
            this.radio_A.Text = "A";
            this.radio_A.UseVisualStyleBackColor = true;
            this.radio_A.CheckedChanged += new System.EventHandler(this.radio_A_CheckedChanged);
            // 
            // lbl_QuestionCounter
            // 
            this.lbl_QuestionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuestionCounter.Location = new System.Drawing.Point(105, 4);
            this.lbl_QuestionCounter.Name = "lbl_QuestionCounter";
            this.lbl_QuestionCounter.Size = new System.Drawing.Size(45, 17);
            this.lbl_QuestionCounter.TabIndex = 10;
            // 
            // btn_EndTest
            // 
            this.btn_EndTest.Location = new System.Drawing.Point(536, 379);
            this.btn_EndTest.Name = "btn_EndTest";
            this.btn_EndTest.Size = new System.Drawing.Size(75, 23);
            this.btn_EndTest.TabIndex = 11;
            this.btn_EndTest.Text = "End Test";
            this.btn_EndTest.UseVisualStyleBackColor = true;
            this.btn_EndTest.Click += new System.EventHandler(this.btn_EndTest_Click);
            // 
            // btn_ShowAns
            // 
            this.btn_ShowAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowAns.Location = new System.Drawing.Point(263, 379);
            this.btn_ShowAns.Name = "btn_ShowAns";
            this.btn_ShowAns.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowAns.TabIndex = 12;
            this.btn_ShowAns.Text = "Show Ans";
            this.btn_ShowAns.UseVisualStyleBackColor = true;
            this.btn_ShowAns.Click += new System.EventHandler(this.btn_ShowAns_Click);
            // 
            // lbl_ShowAns
            // 
            this.lbl_ShowAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_ShowAns.Location = new System.Drawing.Point(259, 335);
            this.lbl_ShowAns.Name = "lbl_ShowAns";
            this.lbl_ShowAns.Size = new System.Drawing.Size(100, 23);
            this.lbl_ShowAns.TabIndex = 13;
            // 
            // btn_Review
            // 
            this.btn_Review.Location = new System.Drawing.Point(423, 379);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(107, 23);
            this.btn_Review.TabIndex = 14;
            this.btn_Review.Text = "Review Answers";
            this.btn_Review.UseVisualStyleBackColor = true;
            this.btn_Review.Click += new System.EventHandler(this.btn_Review_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 425);
            this.Controls.Add(this.btn_Review);
            this.Controls.Add(this.lbl_ShowAns);
            this.Controls.Add(this.btn_ShowAns);
            this.Controls.Add(this.btn_EndTest);
            this.Controls.Add(this.lbl_QuestionCounter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Online Test Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_D;
        private System.Windows.Forms.RadioButton radio_C;
        private System.Windows.Forms.RadioButton radio_B;
        private System.Windows.Forms.RadioButton radio_A;
        private System.Windows.Forms.Label lbl_QuestionCounter;
        private System.Windows.Forms.Button btn_EndTest;
        private System.Windows.Forms.Button btn_ShowAns;
        private System.Windows.Forms.Label lbl_ShowAns;
        private System.Windows.Forms.Button btn_Review;

    }
}

