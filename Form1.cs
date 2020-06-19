using RestSharp;
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

        Questions[] aoQuestions = new Questions[3];
        
        private int count = 0;
        private string Answer = "";
        
        public Form1()
        {
            InitializeComponent();
            createQuestionInList();
        }


        public void checkAnswer()
        {
            if (Answer == aoQuestions[count].getAnswer())
            {
                lblQuestionStatus.Text = "CORRECT";
                lblQuestionStatus.ForeColor = Color.DarkGreen;
                btnCorrect.Enabled = true;
                btnCorrect.Visible = true;
                activateNext();
                count++;
            }
            else
            {
                lblQuestionStatus.Text = "INCORRECT";
                lblQuestionStatus.ForeColor = Color.DarkRed;
                btnIncorrect.Enabled = true;
                btnIncorrect.Visible = true;
                activateNext();
            }
        }

        public void activateNext()
        {
            btnNext.Enabled = true;
            btnOptionA.Enabled = false;
            btnOptionB.Enabled = false;
            btnOptionC.Enabled = false;
            btnOptionD.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Load(object sender, EventArgs e)
        {

        }

        public void createQuestionInList()
        {
            // Question 1
            aoQuestions[0] = new Questions
            {
                Question = "King Henry VIII was the second monarch of which European royal house?",
                Option1 = "York",
                Option2 = "Stuart",
                Option3 = "Lancaster",
                Option4 = "Tudor",
                Answer = "Tudor"
            };

            // Question 2
            aoQuestions[1] = new Questions
            {
                Question = "How many soccer players should be on the field at the same time?",
                Option1 = "20",
                Option2 = "22",
                Option3 = "24",
                Option4 = "26",
                Answer = "22"
            };

            // Question 3
            aoQuestions[2] = new Questions
            {
                Question = "Which American president appears on a one dollar bill?",
                Option1 = "Thomas Jefferson",
                Option2 = "Abraham Lincoln",
                Option3 = "George Washington",
                Option4 = "Benjamin Franklin",
                Answer = "George Washington"
            };

            // Iteration
            for (int x = 0; x < 3; x++)
            {
                lblQuestionText.Text = aoQuestions[x].getQuestion();
                lblOptionA.Text = aoQuestions[x].getOption1();
                lblOptionB.Text = aoQuestions[x].getOption2();
                lblOptionC.Text = aoQuestions[x].getOption3();
                lblOptionD.Text = aoQuestions[x].getOption4();
            }

        }

        private void btnOptionA_Click(object sender, EventArgs e)
        {
            Answer = lblOptionA.Text;
            checkAnswer();
            activateNext();
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
            
        }
    }
}
