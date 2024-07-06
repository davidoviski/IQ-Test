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
    public partial class Quiz2 : Form
    {
        int correctAwnser;
        int questionsNumber = 1;
        int score;
        int percentage;
        int totalQuestons;
        int remainingSeconds = 0;
        public Quiz2()
        {
            InitializeComponent();
            askQuestion(questionsNumber);

            totalQuestons = 18;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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


        private void eventCheckAwnsers(object sender, EventArgs e)
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
               "Вашето ниво на интелегенција од овој квиз е " + percentage * 1.65 + "IQ" + Environment.NewLine +
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
                    pictureBox1.Image = Properties.Resources.belgija;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Германија";
                    button2.Text = "Русија";
                    button3.Text = "Белгија";
                    button4.Text = "Унгарија";
                    correctAwnser = 3;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Flag_of_Vietnam_svg;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Полска";
                    button2.Text = "Виетнам";
                    button3.Text = "Србија";
                    button4.Text = "Уганда";
                    correctAwnser = 2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.germany;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Германија";
                    button2.Text = "Франција";
                    button3.Text = "Кина";
                    button4.Text = "САД";
                    correctAwnser = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.canada;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Канада";
                    button2.Text = "Јапонија";
                    button3.Text = "Австралија";
                    button4.Text = "Италија";
                    correctAwnser = 1;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.brasilll;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Шпанија";
                    button2.Text = "Бразил";
                    button3.Text = "Јужна Африка";
                    button4.Text = "Норвешка";
                    correctAwnser = 2;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.holandija;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Шведска";
                    button2.Text = "Швајцарија";
                    button3.Text = "Холандија";
                    button4.Text = "Полска";
                    correctAwnser = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.russia;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Русија";
                    button2.Text = "Индија";
                    button3.Text = "Чиле";
                    button4.Text = "Аргентина";
                    correctAwnser = 1;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.iran;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Грција";
                    button2.Text = "Египет";
                    button3.Text = "Турција";
                    button4.Text = "Иран";
                    correctAwnser = 4;
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.saudiska;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Израел";
                    button2.Text = "Саудиска Арабија";
                    button3.Text = "Нов Зеланд";
                    button4.Text = "Јужна Кореја";
                    correctAwnser = 2;
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.portigal;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Мексико";
                    button2.Text = "Португалија";
                    button3.Text = "Белгија";
                    button4.Text = "Украина";
                    correctAwnser = 2;
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.images;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Австрија";
                    button2.Text = "Унгарија";
                    button3.Text = "Чешка";
                    button4.Text = "Словачка";
                    correctAwnser = 1;
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.croatia;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Хрватска";
                    button2.Text = "Словенија";
                    button3.Text = "Бугарија";
                    button4.Text = "Романија";
                    correctAwnser = 1;
                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.litvanija;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Србија";
                    button2.Text = "Литванија";
                    button3.Text = "Латвија";
                    button4.Text = "Естонија";
                    correctAwnser = 2;
                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources.kosovo;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Босна и Херцеговина";
                    button2.Text = "Македонија";
                    button3.Text = "Албанија";
                    button4.Text = "Косово";
                    correctAwnser = 4;
                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.libija;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Мароко";
                    button2.Text = "Тунис";
                    button3.Text = "Либија\r\n";
                    button4.Text = "Алжир";
                    correctAwnser = 3;
                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources.ghana;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Бенин";
                    button2.Text = "Нигер";
                    button3.Text = "Нигерија";
                    button4.Text = "Гана";
                    correctAwnser = 4;
                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources.kamerun;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Камерун";
                    button2.Text = "Конго";
                    button3.Text = "Замбија";
                    button4.Text = "Зимбабве";
                    correctAwnser = 1;
                    break;
                case 18:
                    pictureBox1.Image = Properties.Resources.lesoto;
                    Q2lblQuestion.Text = "На која држава припаѓа знамето?";
                    button1.Text = "Ботсвана";
                    button2.Text = "Лесото";
                    button3.Text = "Свазиленд";
                    button4.Text = "Малави";
                    correctAwnser = 2;
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            remainingSeconds--;
            if (remainingSeconds >= 0)
            {
                UpdateTimerDisplay();
            }
            else
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("GAME OVER -- TIMED OUT","TIMEOUT" ,MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    questionsNumber = 1;
                    ShowMainFormAndCloseQuiz();
                    ResetTimer();
                }
            }
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
