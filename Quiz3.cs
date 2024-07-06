using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPP
{
    public partial class Quiz3 : Form
    {
        int correctAwnser;
        int questionsNumber = 1;
        int score;
        int percentage;
        int totalQuestons;
        int remainingSeconds = 0;
        public Quiz3()
        {
            InitializeComponent();
            askQuestion(questionsNumber);

            totalQuestons = 14;
        }
        private void ShowMainFormAndCloseQuiz()
        {
            // Show Form1
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Show();
            }

            // Close the current quiz form
            this.Close();
        }

        private void checkAnwsersEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAwnser)
            {
                score++;
            }
            if (questionsNumber == totalQuestons)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestons);

                DialogResult result = MessageBox.Show(
               "Квизот заврши!" + Environment.NewLine +
               "Вие имате " + score + " точно одговорени прашања" + Environment.NewLine +
               "Вашето ниво на интелегенција од овој квиз е " + percentage*1.65+ "IQ" + Environment.NewLine +
               "За да продолжите притиснете OK!",
               "Резултати на квиз",
               MessageBoxButtons.OK);

                if (result == DialogResult.OK)
                {
                    ShowMainFormAndCloseQuiz();
                }
            }
            questionsNumber++;
            askQuestion(questionsNumber);
        }
        private void askQuestion(int qnum)
        {
            StartTimer();
            switch (qnum)
            {
                case 1:
                    //pictureBox1.Image = Properties.Resources.belgija;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "7 9 5 11   4 15 12 7   13 8 11?";
                    button1.Text = "8";
                    button2.Text = "10";
                    button3.Text = "11";
                    button4.Text = "13";
                    correctAwnser = 2;
                    break;
                case 2:
                    //pictureBox1.Image = Properties.Resources.Flag_of_Vietnam_svg;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "2 5 7   4 7 5   3 6?";
                    button1.Text = "4";
                    button2.Text = "6";
                    button3.Text = "8";
                    button4.Text = "10";
                    correctAwnser = 2;
                    break;
                case 3:
                    //pictureBox1.Image = Properties.Resources.germany;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "2, 5, 8, 11,? ";
                    button1.Text = "8";
                    button2.Text = "12";
                    button3.Text = "14";
                    button4.Text = "16";
                    correctAwnser = 3;
                    break;
                case 4:
                    //pictureBox1.Image = Properties.Resources.canada;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "121, 144, 169, 196,?";
                    button1.Text = "225";
                    button2.Text = "230";
                    button3.Text = "275";
                    button4.Text = "221";
                    correctAwnser = 1;
                    break;
                case 5:
                    //pictureBox1.Image = Properties.Resources.brasilll;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "4, 6, 9, 6, 14, 6,?";
                    button1.Text = "14";
                    button2.Text = "9";
                    button3.Text = "16";
                    button4.Text = "19";
                    correctAwnser = 4;
                    break;
                case 6:
                    //pictureBox1.Image = Properties.Resources.holandija;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "2, 3, 5, 9, 17, 33, 65,? ";
                    button1.Text = "104";
                    button2.Text = "129";
                    button3.Text = "97";
                    button4.Text = "135";
                    correctAwnser = 2;
                    break;
                case 7:
                    //pictureBox1.Image = Properties.Resources.russia;
                    Q3lblQuestion.Text = "Кој број логично треба да биде нареден?";
                    Q3lblask.Text = "1, 3, 12, 52, 265,?";
                    button1.Text = "1188";
                    button2.Text = "1390";
                    button3.Text = "1489";
                    button4.Text = "1596";
                    correctAwnser = 4;
                    break;
                case 8:
                    //pictureBox1.Image = Properties.Resources.iran;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "8 10 14 18 ? 34 50 66";
                    button1.Text = "20";
                    button2.Text = "26";
                    button3.Text = "28";
                    button4.Text = "30";
                    correctAwnser = 2;
                    break;
                case 9:
                    //pictureBox1.Image = Properties.Resources.saudiska;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "7 9 8 6 10 9 5 11 10 ? 12";
                    button1.Text = "4";
                    button2.Text = "5";
                    button3.Text = "11";
                    button4.Text = "28";
                    correctAwnser = 1;
                    break;
                case 10:
                    //pictureBox1.Image = Properties.Resources.portigal;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "? 9 27 81";
                    button1.Text = "0";
                    button2.Text = "1";
                    button3.Text = "3";
                    button4.Text = "5";
                    correctAwnser = 3;
                    break;
                case 11:
                    //pictureBox1.Image = Properties.Resources.images;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "64, ?, 1024, 4096";
                    button1.Text = "98";
                    button2.Text = "167";
                    button3.Text = "199";
                    button4.Text = "256";
                    correctAwnser = 1;
                    break;
                case 12:
                    //pictureBox1.Image = Properties.Resources.croatia;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "144, ?, 206, 240";
                    button1.Text = "155";
                    button2.Text = "167";
                    button3.Text = "170";
                    button4.Text = "174";
                    correctAwnser = 4;
                    break;
                case 13:
                    //pictureBox1.Image = Properties.Resources.litvanija;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "16, 64, ?, 1024, 4096";
                    button1.Text = "98 ";
                    button2.Text = "156";
                    button3.Text = "256";
                    button4.Text = "298";
                    correctAwnser = 3;
                    break;
                case 14:
                    //pictureBox1.Image = Properties.Resources.kosovo;
                    Q3lblQuestion.Text = "Кој број недостасува?";
                    Q3lblask.Text = "56, 75, 94, ? , 132";
                    button1.Text = "113";
                    button2.Text = "128";
                    button3.Text = "130";
                    button4.Text = "131";
                    correctAwnser = 1;
                    break;
                

            }
        }
        private void StartTimer()
        {
            remainingSeconds = 15;
            timer1.Enabled = true;
            timer1.Start();
        }
        private void ResetTimer()
        {
            remainingSeconds = 15;
        }
        private void UpdateTimerDisplay()
        {
            lblTimer.Text = "Timer: " + remainingSeconds.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            if (remainingSeconds >= 0)
            {
                UpdateTimerDisplay();
            }

            if (remainingSeconds < 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("GAME OVER -- TIMED OUT","TIMEOUT", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    questionsNumber = 1;
                    askQuestion(questionsNumber);
                    ResetTimer();
                }
            }
        }
    }
}
