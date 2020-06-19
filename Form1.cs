using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    public partial class Form1 : Form
    {
        ArrayList questions = new ArrayList();
        Questions oQuestions = new Questions();
        private string Answer = "";

        public Form1()
        {
            InitializeComponent();
            createQuestionInList();
            setQuestions();
        }

        private void setQuestions()
        {
            
            lblQuestionText.Text = ((Questions)questions[0]).getQuestion();
            lblOptionA.Text = ((Questions)questions[0]).getOption1();
            lblOptionB.Text = ((Questions)questions[0]).getOption2();
            lblOptionC.Text = ((Questions)questions[0]).getOption3();
            lblOptionD.Text = ((Questions)questions[0]).getOption4();
        }

        public void checkAnswer()
        {
            //Console.WriteLine(Answer);
            if (Answer == ((Questions)questions[0]).getAnswer())
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Load(object sender, EventArgs e)
        {

        }

        public void createQuestionInList()
        {
            questions.Add(oQuestions);
            ((Questions)questions[0]).Question = "King Henry VIII was the second monarch of which European royal house?";
            ((Questions)questions[0]).Option1 = "York";
            ((Questions)questions[0]).Option2 = "Stuart";
            ((Questions)questions[0]).Option3 = "Lancaster";
            ((Questions)questions[0]).Option4 = "Tudor";
            ((Questions)questions[0]).Answer = "Tudor";
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
    }
}
