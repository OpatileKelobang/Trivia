﻿using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trivia
{
    public partial class Form1 : Form
    {

        Questions[] aoQuestions = new Questions[10];
        
        private int count = 0;
        private int score = 0;
        private string Answer = "";
        private int questionNumber = 0;
        
        public Form1()
        {
            InitializeComponent();
            createQuestionInList();
            checkHighScore();
        }


        private void checkHighScore()
        {
            if (score >= Settings.HighScore)
            {
                Settings.HighScore = score;
                lblHighScoreValue.Text = score.ToString();
                using (StreamWriter writer =
                    new StreamWriter(
                        "C:\\Users\\Opatile\\source\\repos\\Trivia\\assets\\highscore.txt"))
                {
                    writer.WriteLine(score.ToString());
                    writer.Close();
                }
            }
        }
        private void checkAnswer()
        {
            if (Answer == aoQuestions[count].getAnswer())
            {
                lblQuestionStatus.Text = "CORRECT";
                lblQuestionStatus.Visible = true;
                lblQuestionStatus.ForeColor = Color.DarkGreen;
                btnCorrect.Enabled = true;
                btnCorrect.Visible = true;
                activateNext();
                count++;
                score = score + 5;
                lblScoreValue.Text = score.ToString();
            }
            else
            {
                lblQuestionStatus.Text = "INCORRECT";
                lblQuestionStatus.Visible = true;
                lblQuestionStatus.ForeColor = Color.DarkRed;
                btnIncorrect.Enabled = true;
                btnIncorrect.Visible = true;
                activateNext();
            }
        }

        private void activateNext()
        {
            btnNext.Enabled = true;
            btnOptionA.Enabled = false;
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
            btnOptionD.Enabled = false;
        }

        private void deactivateNext()
        {
            btnNext.Enabled = false;
            btnOptionA.Enabled = true;
            btnOptionB.Enabled = true;
            btnOptionC.Enabled = true;
            btnOptionD.Enabled = true;
            btnIncorrect.Enabled = false;
            btnIncorrect.Visible = false;
            btnCorrect.Enabled = false;
            btnCorrect.Visible = false;
            lblQuestionStatus.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Load(object sender, EventArgs e)
        {

        }

        private void createQuestionInList()
        {
            switch (questionNumber)
            {
                case 0:
                    aoQuestions[0] = new Questions
                    {
                        Question = "King Henry VIII was the second monarch of which European royal house?",
                        Option1 = "York",
                        Option2 = "Stuart",
                        Option3 = "Lancaster",
                        Option4 = "Tudor",
                        Answer = "Tudor"
                    };

                    lblQuestionStatus.Visible = false;
                    lblQuestionText.Text = aoQuestions[0].getQuestion();
                    lblOptionA.Text = aoQuestions[0].getOption1();
                    lblOptionB.Text = aoQuestions[0].getOption2();
                    lblOptionC.Text = aoQuestions[0].getOption3();
                    lblOptionD.Text = aoQuestions[0].getOption4();
                    break;
                
                case 1:
                    aoQuestions[1] = new Questions
                    {
                        Question = "How many soccer players should be on the field at the same time?",
                        Option1 = "20",
                        Option2 = "22",
                        Option3 = "24",
                        Option4 = "26",
                        Answer = "22"
                    };

                    lblQuestionText.Text = aoQuestions[1].getQuestion();
                    lblOptionA.Text = aoQuestions[1].getOption1();
                    lblOptionB.Text = aoQuestions[1].getOption2();
                    lblOptionC.Text = aoQuestions[1].getOption3();
                    lblOptionD.Text = aoQuestions[1].getOption4();
                    break;

                case 2:
                    aoQuestions[2] = new Questions
                    {
                        Question = "Which American president appears on a one dollar bill?",
                        Option1 = "Thomas Jefferson",
                        Option2 = "Abraham Lincoln",
                        Option3 = "George Washington",
                        Option4 = "Benjamin Franklin",
                        Answer = "George Washington"
                    };

                    lblQuestionText.Text = aoQuestions[2].getQuestion();
                    lblOptionA.Text = aoQuestions[2].getOption1();
                    lblOptionB.Text = aoQuestions[2].getOption2();
                    lblOptionC.Text = aoQuestions[2].getOption3();
                    lblOptionD.Text = aoQuestions[2].getOption4();
                    break;

                case 3:
                    aoQuestions[3] = new Questions
                    {
                        Question = "Who is the current South African Minister of Finance?",
                        Option1 = "Fikile Mbalula",
                        Option2 = "Julius Malema",
                        Option3 = "Bonang Matheba",
                        Option4 = "Tito Mboweni",
                        Answer = "Tito Mboweni"
                    };

                    lblQuestionText.Text = aoQuestions[3].getQuestion();
                    lblOptionA.Text = aoQuestions[3].getOption1();
                    lblOptionB.Text = aoQuestions[3].getOption2();
                    lblOptionC.Text = aoQuestions[3].getOption3();
                    lblOptionD.Text = aoQuestions[3].getOption4();
                    break;

                case 4:
                    aoQuestions[4] = new Questions
                    {
                        Question = "Who is the current South African Minister of Finance?",
                        Option1 = "Fikile Mbalula",
                        Option2 = "Julius Malema",
                        Option3 = "Bonang Matheba",
                        Option4 = "Tito Mboweni",
                        Answer = "Tito Mboweni"
                    };

                    lblQuestionText.Text = aoQuestions[4].getQuestion();
                    lblOptionA.Text = aoQuestions[4].getOption1();
                    lblOptionB.Text = aoQuestions[4].getOption2();
                    lblOptionC.Text = aoQuestions[4].getOption3();
                    lblOptionD.Text = aoQuestions[4].getOption4();
                    break;

                case 5:
                    aoQuestions[5] = new Questions
                    {
                        Question = "Which company was established on April 1st, 1976 by Steve Jobs, Steve Wozniak and Ronald Wayne?",
                        Option1 = "Apple",
                        Option2 = "Microsoft",
                        Option3 = "Atari",
                        Option4 = "Commodore",
                        Answer = "Apple"
                    };

                    lblQuestionText.Text = aoQuestions[5].getQuestion();
                    lblOptionA.Text = aoQuestions[5].getOption1();
                    lblOptionB.Text = aoQuestions[5].getOption2();
                    lblOptionC.Text = aoQuestions[5].getOption3();
                    lblOptionD.Text = aoQuestions[5].getOption4();
                    break;

                case 6:
                    aoQuestions[6] = new Questions
                    {
                        Question = "In web design, what does CSS stand for?",
                        Option1 = "Counter Strike: Source",
                        Option2 = "Corrective Style Sheet",
                        Option3 = "Cascading Style Sheet",
                        Option4 = "Computer Style Sheet",
                        Answer = "Cascading Style Sheet"
                    };

                    lblQuestionText.Text = aoQuestions[6].getQuestion();
                    lblOptionA.Text = aoQuestions[6].getOption1();
                    lblOptionB.Text = aoQuestions[6].getOption2();
                    lblOptionC.Text = aoQuestions[6].getOption3();
                    lblOptionD.Text = aoQuestions[6].getOption4();
                    break;
            }
        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            Answer = lblOptionA.Text;
            checkAnswer();
        }

        private void btnOptionB_Click(object sender, EventArgs e)
        {
            Answer = lblOptionB.Text;
            checkAnswer();
        }

        private void btnOptionC_Click(object sender, EventArgs e)
        {
            Answer = lblOptionC.Text;
            checkAnswer();
        }

        private void btnOptionD_Click(object sender, EventArgs e)
        {
            Answer = lblOptionD.Text;
            checkAnswer();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            questionNumber += 1;
            Console.WriteLine(questionNumber);
            createQuestionInList();
            deactivateNext();
        }
    }
}
