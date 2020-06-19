namespace Trivia
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.panelQuestionArea = new System.Windows.Forms.Panel();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.btnOptionA = new System.Windows.Forms.Button();
            this.lblAnswerButtons = new System.Windows.Forms.Label();
            this.btnOptionB = new System.Windows.Forms.Button();
            this.btnOptionC = new System.Windows.Forms.Button();
            this.btnOptionD = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblHighScoreValue = new System.Windows.Forms.Label();
            this.lblQuestionStatus = new System.Windows.Forms.Label();
            this.btnIncorrect = new System.Windows.Forms.Button();
            this.btnCorrect = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelQuestionArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.Location = new System.Drawing.Point(0, 0);
            this.lblGameTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(800, 40);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "TRIVIA GAME";
            this.lblGameTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblGameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(39, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(57, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question";
            // 
            // panelQuestionArea
            // 
            this.panelQuestionArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestionArea.Controls.Add(this.lblOptionD);
            this.panelQuestionArea.Controls.Add(this.lblOptionC);
            this.panelQuestionArea.Controls.Add(this.lblOptionB);
            this.panelQuestionArea.Controls.Add(this.lblOptionA);
            this.panelQuestionArea.Controls.Add(this.lblD);
            this.panelQuestionArea.Controls.Add(this.lblC);
            this.panelQuestionArea.Controls.Add(this.lblB);
            this.panelQuestionArea.Controls.Add(this.lblA);
            this.panelQuestionArea.Controls.Add(this.lblQuestionText);
            this.panelQuestionArea.Location = new System.Drawing.Point(42, 100);
            this.panelQuestionArea.Name = "panelQuestionArea";
            this.panelQuestionArea.Size = new System.Drawing.Size(449, 265);
            this.panelQuestionArea.TabIndex = 3;
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Location = new System.Drawing.Point(62, 186);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(49, 13);
            this.lblOptionD.TabIndex = 8;
            this.lblOptionD.Text = "Option D";
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Location = new System.Drawing.Point(62, 151);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(48, 13);
            this.lblOptionC.TabIndex = 7;
            this.lblOptionC.Text = "Option C";
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Location = new System.Drawing.Point(62, 116);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(48, 13);
            this.lblOptionB.TabIndex = 6;
            this.lblOptionB.Text = "Option B";
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Location = new System.Drawing.Point(62, 77);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(48, 13);
            this.lblOptionA.TabIndex = 5;
            this.lblOptionA.Text = "Option A";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(21, 186);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(20, 13);
            this.lblD.TabIndex = 4;
            this.lblD.Text = "D:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(21, 151);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(19, 13);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "C:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(21, 116);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(19, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(21, 77);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(19, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A:";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(18, 31);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(73, 13);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question Text";
            // 
            // btnOptionA
            // 
            this.btnOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionA.Location = new System.Drawing.Point(531, 145);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(120, 40);
            this.btnOptionA.TabIndex = 4;
            this.btnOptionA.TabStop = false;
            this.btnOptionA.Text = "A";
            this.btnOptionA.UseVisualStyleBackColor = true;
            this.btnOptionA.Click += new System.EventHandler(this.btnOptionA_Click);
            // 
            // lblAnswerButtons
            // 
            this.lblAnswerButtons.AutoSize = true;
            this.lblAnswerButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerButtons.Location = new System.Drawing.Point(531, 100);
            this.lblAnswerButtons.Name = "lblAnswerButtons";
            this.lblAnswerButtons.Size = new System.Drawing.Size(99, 29);
            this.lblAnswerButtons.TabIndex = 5;
            this.lblAnswerButtons.Text = "Answer:";
            // 
            // btnOptionB
            // 
            this.btnOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionB.Location = new System.Drawing.Point(668, 145);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(120, 40);
            this.btnOptionB.TabIndex = 6;
            this.btnOptionB.TabStop = false;
            this.btnOptionB.Text = "B";
            this.btnOptionB.UseVisualStyleBackColor = true;
            this.btnOptionB.Click += new System.EventHandler(this.btnOptionB_Click);
            // 
            // btnOptionC
            // 
            this.btnOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionC.Location = new System.Drawing.Point(531, 212);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(120, 40);
            this.btnOptionC.TabIndex = 7;
            this.btnOptionC.TabStop = false;
            this.btnOptionC.Text = "C";
            this.btnOptionC.UseVisualStyleBackColor = true;
            this.btnOptionC.Click += new System.EventHandler(this.btnOptionC_Click);
            // 
            // btnOptionD
            // 
            this.btnOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptionD.Location = new System.Drawing.Point(668, 212);
            this.btnOptionD.Name = "btnOptionD";
            this.btnOptionD.Size = new System.Drawing.Size(120, 40);
            this.btnOptionD.TabIndex = 8;
            this.btnOptionD.TabStop = false;
            this.btnOptionD.Text = "D";
            this.btnOptionD.UseVisualStyleBackColor = true;
            this.btnOptionD.Click += new System.EventHandler(this.btnOptionD_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblScore.Location = new System.Drawing.Point(535, 36);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 24);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(664, 40);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(27, 20);
            this.lblScoreValue.TabIndex = 11;
            this.lblScoreValue.Text = "00";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHighScore.Location = new System.Drawing.Point(536, 68);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(121, 24);
            this.lblHighScore.TabIndex = 12;
            this.lblHighScore.Text = "High Score:";
            // 
            // lblHighScoreValue
            // 
            this.lblHighScoreValue.AutoSize = true;
            this.lblHighScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreValue.Location = new System.Drawing.Point(664, 72);
            this.lblHighScoreValue.Name = "lblHighScoreValue";
            this.lblHighScoreValue.Size = new System.Drawing.Size(27, 20);
            this.lblHighScoreValue.TabIndex = 13;
            this.lblHighScoreValue.Text = "00";
            // 
            // lblQuestionStatus
            // 
            this.lblQuestionStatus.AutoSize = true;
            this.lblQuestionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionStatus.Location = new System.Drawing.Point(567, 271);
            this.lblQuestionStatus.Name = "lblQuestionStatus";
            this.lblQuestionStatus.Size = new System.Drawing.Size(113, 13);
            this.lblQuestionStatus.TabIndex = 14;
            this.lblQuestionStatus.Text = "Correct / Incorrect";
            // 
            // btnIncorrect
            // 
            this.btnIncorrect.BackColor = System.Drawing.Color.Transparent;
            this.btnIncorrect.Enabled = false;
            this.btnIncorrect.FlatAppearance.BorderSize = 0;
            this.btnIncorrect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIncorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIncorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncorrect.Image = global::Trivia.Properties.Resources.wrong;
            this.btnIncorrect.Location = new System.Drawing.Point(686, 253);
            this.btnIncorrect.Name = "btnIncorrect";
            this.btnIncorrect.Size = new System.Drawing.Size(48, 48);
            this.btnIncorrect.TabIndex = 16;
            this.btnIncorrect.UseVisualStyleBackColor = false;
            this.btnIncorrect.Visible = false;
            // 
            // btnCorrect
            // 
            this.btnCorrect.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrect.Enabled = false;
            this.btnCorrect.FlatAppearance.BorderSize = 0;
            this.btnCorrect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCorrect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCorrect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorrect.Image = global::Trivia.Properties.Resources.correct;
            this.btnCorrect.Location = new System.Drawing.Point(740, 253);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(48, 48);
            this.btnCorrect.TabIndex = 15;
            this.btnCorrect.UseVisualStyleBackColor = false;
            this.btnCorrect.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Image = global::Trivia.Properties.Resources.right_arrow;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(531, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(257, 63);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncorrect);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.lblQuestionStatus);
            this.Controls.Add(this.lblHighScoreValue);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnOptionD);
            this.Controls.Add(this.btnOptionC);
            this.Controls.Add(this.btnOptionB);
            this.Controls.Add(this.lblAnswerButtons);
            this.Controls.Add(this.btnOptionA);
            this.Controls.Add(this.panelQuestionArea);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblGameTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRIVIA GAME";
            this.Load += new System.EventHandler(this.lblTitle_Load);
            this.panelQuestionArea.ResumeLayout(false);
            this.panelQuestionArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Panel panelQuestionArea;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Label lblAnswerButtons;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.Button btnOptionD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblHighScoreValue;
        private System.Windows.Forms.Label lblQuestionStatus;
        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Button btnIncorrect;
    }
}

