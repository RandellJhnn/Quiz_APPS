using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_APPS
{
    public partial class QUIZ_APP : Form
    {
        public QUIZ_APP()
        {
            InitializeComponent();
        }

        // create an array of questiongs
        String[] questions = { "What is the correct way to declare a variable in Visual Basic?", "Which event occurs when a button is clicked in a Visual Basic application??",
                               "How do you create a message box in Visual Basic?", "What keyword is used to define a subroutine in Visual Basic?",
                                "Which of the following statements is used to handle exceptions in Visual Basic?", };

        // create an array of options 
        // 5 questions
        // 5 options
        // the last option will be the correct answer
        // and we will use it to check if the user select the correct answer
        String[,] options = new string[5, 5] {{"Dim x As Integer", "Variable x Integer", "Int x", "Declare x As Integer", "Dim x As Integer"},
                                               {"MouseHover", "KeyPress", "Click", "Load", "Click"},
                                                {"MessageBox.Show(\"Hello World!\")", "ShowMessage(\"Hello World!\")", "Alert(\"Hello World!\")", "MsgBox.Display(\"Hello World!\")", "MessageBox.Show(\"Hello World!\")"},
                                                 {"Function", "Sub", "Method", "Procedure", "Sub"},
                                                  {"Try...Except", "Catch...Finally", "Error", "Handle", "Try...Except"}};

        int index = 0, correct = 0;
        private IEnumerable<Control> controls;

        // create a function to check if the user has selected the correct answer
        public void checkAnswer(RadioButton rbt)
        {
            // the 4th item(we start from 0) is the correct in every question
            if (rbt.Text.Equals(options[index, 4]))
            {
                correct++;
                // you can make the correct answer become green
                // and the wrong answer red
                rbt.BackColor = Color.Green;
            }
            else
            {
                rbt.BackColor = Color.Red;
            }

            index++;
            // display radiobuttons
            setEnable(false);
        }

        // create a function to uncheck radiobuttons
        public void uncheck()
        {
            radioButtonOption1.Checked = false;
            radioButtonOption2.Checked = false;
            radioButtonOption3.Checked = false;
            radioButtonOption4.Checked = false;
        }

        // create a function to change radiobuttons backcolor and color
        public void resetRadio()
        {
            // we are gonna use the foreach loop
            // the color change automatically when disabled
            foreach(Control c in this.Controls)
            {
                if(c is RadioButton)
                {
                    RadioButton rdb = (RadioButton)c;
                    rdb.BackColor = Color.White;
                }
            }

        }

        // create a function to enable/disable radiobuttons
        public void setEnable(Boolean yes_or_no)
        {
            radioButtonOption1.Enabled = yes_or_no;
            radioButtonOption2.Enabled = yes_or_no;
            radioButtonOption3.Enabled = yes_or_no;
            radioButtonOption4.Enabled = yes_or_no;
        }

        private void QUIZ_APP_load(object sender, EventArgs e)
        {
            // call the button click even
            button_Next.PerformClick();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            resetRadio();

            if (button_Next.Text.Equals("Restart The Quiz"))
            {
                index = 0;
                correct = 0;
                richTextBox1_Questions.BackColor = Color.White;
                richTextBox1_Questions.ForeColor = Color.Black;
                button_Next.Text = "Next";
            }   

            if (index == questions.Length)
            {
                richTextBox1_Questions.Text = "Your Score:" + correct + " / " + questions.Length;

                if (correct >= (float)questions.Length / 2)
                {
                    richTextBox1_Questions.BackColor = Color.Green;
                    richTextBox1_Questions.ForeColor = Color.White;
                }
                else
                {
                    richTextBox1_Questions.BackColor = Color.Red;
                    richTextBox1_Questions.ForeColor = Color.White;
                }

                button_Next.Text = "Restart The Quiz";

            }
            else
            {
                // enable radiobuttons
                setEnable(true);
                //uncheck radiobuttons
                uncheck();
                // display the question
                richTextBox1_Questions.Text = questions[index];
                // display  options
                radioButtonOption1.Text = options[index, 0];
                radioButtonOption2.Text = options[index, 1];
                radioButtonOption3.Text = options[index, 2];
                radioButtonOption4.Text = options[index, 3];

                if(index == questions.Length - 1)
                {
                    button_Next.Text = "Finish and See Your Result";
                }
            }   
        }

        private void radioButtonOption1_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption1);

        }

        private void radioButtonOption2_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption2);

        }

        private void radioButtonOption3_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption3);

        }

        private void radioButtonOption4_Click(object sender, EventArgs e)
        {
            checkAnswer(radioButtonOption4);

        }

        private void QUIZ_APP_Load(object sender, EventArgs e)
        {

        }
    }
}
