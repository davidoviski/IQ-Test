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
    public partial class Quiz1 : Form
    {
        //vrednosti
        int correctAwnser;
        int questionsNumber = 1;
        int score;
        int percentage;
        int totalQuestons;
        int remainingSeconds = 0;
        public Quiz1()
        {
            InitializeComponent();
            askQuestion(questionsNumber);

            totalQuestons = 18;

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


        private void checkAwnserEvent(object sender, EventArgs e)
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
               MessageBoxButtons.OK );

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
                    Q1lblQuestion.Text = "Кој бил првиот римски цар?";
                    button1.Text = "Ромул";
                    button2.Text = "Рем";
                    button3.Text = "Нума";
                    button4.Text = "Тул";
                    correctAwnser = 1;
                    break;
                case 2:
                    Q1lblQuestion.Text = "Кој е основачот на Османлиската Империја?";
                    button1.Text = "Мехмед II";
                    button2.Text = "Осман I";
                    button3.Text = "Сулејман Величенствени";
                    button4.Text = "Мурат I";
                    correctAwnser = 2;
                    break;
                case 3:
                    Q1lblQuestion.Text = "Кој е познат како \"Отец на Македонија\"?";
                    button1.Text = "Александар Македонски";
                    button2.Text = "Филип II";
                    button3.Text = "Археологот Томбешев";
                    button4.Text = "Гоце Делчев";
                    correctAwnser = 4;
                    break;
                case 4:
                    Q1lblQuestion.Text = "Која година завршила Првата светска војна?";
                    button1.Text = "1914";
                    button2.Text = "1916";
                    button3.Text = "1918";
                    button4.Text = "1920";
                    correctAwnser = 3;
                    break;
                case 5:
                    Q1lblQuestion.Text = "Која година била откриена радиоактивноста од страна на Мари Кири?";
                    button1.Text = "1896";
                    button2.Text = "1901";
                    button3.Text = "1910";
                    button4.Text = "1923";
                    correctAwnser = 1;
                    break;
                case 6:
                    Q1lblQuestion.Text = "Која година била основана Југославија?";
                    button1.Text = "1918";
                    button2.Text = "1921";
                    button3.Text = "1943";
                    button4.Text = "1945";
                    correctAwnser = 1;
                    break;
                case 7:
                    Q1lblQuestion.Text = "Кој е најголемиот континент на Земјата?";
                    button1.Text = "Азија";
                    button2.Text = "Европа";
                    button3.Text = "Африка";
                    button4.Text = "Австралија";
                    correctAwnser = 1;
                    break;
                case 8:
                    Q1lblQuestion.Text = "Која е најголемата пустинја на светот?";
                    button1.Text = "Антарктика";
                    button2.Text = "Гоби";
                    button3.Text = "Сахара";
                    button4.Text = "Арктик";
                    correctAwnser = 1;
                    break;
                case 9:
                    Q1lblQuestion.Text = "Која е најдлабоката точка на Земјата?";
                    button1.Text = "Долина на Великата река";
                    button2.Text = "Маријански јама";
                    button3.Text = "Велика Бариерна Подводна Риф";
                    button4.Text = "Голема Рифска Подводна Стена";
                    correctAwnser = 2;
                    break;
                case 10:
                    Q1lblQuestion.Text = "Која е најголемата река во светот според должина?";
                    button1.Text = "Нил";
                    button2.Text = "Амазонка";
                    button3.Text = "Јангцекјанг";
                    button4.Text = "Мисисипи";
                    correctAwnser = 1;
                    break;
                case 11:
                    Q1lblQuestion.Text = "Кој град е најголемиот по население во светот?";
                    button1.Text = "Пекинг";
                    button2.Text = "Токио";
                    button3.Text = "Мексико Сити";
                    button4.Text = "Њујорк";
                    correctAwnser = 2;
                    break;
                case 12:
                    Q1lblQuestion.Text = "Која планета е најголема во Сончевиот систем?";
                    button1.Text = "Јупитер";
                    button2.Text = "Сатурн";
                    button3.Text = "Уран";
                    button4.Text = "Нептун";
                    correctAwnser = 1;
                    break;
                case 13:
                    Q1lblQuestion.Text = "Колку е 12 - 7?";
                    button1.Text = "5";
                    button2.Text = "7";
                    button3.Text = "6";
                    button4.Text = "4";
                    correctAwnser = 1;
                    break;
                case 14:
                    Q1lblQuestion.Text = "Колку е 4 * 6?";
                    button1.Text = "20";
                    button2.Text = "22";
                    button3.Text = "24";
                    button4.Text = "26";
                    correctAwnser = 3;
                    break;
                case 15:
                    Q1lblQuestion.Text = "Колку е 36 / 4?";
                    button1.Text = "9";
                    button2.Text = "8";
                    button3.Text = "10";
                    button4.Text = "7";
                    correctAwnser = 1;
                    break;
                case 16:
                    Q1lblQuestion.Text = "Колку е корен од 25?";
                    button1.Text = "4";
                    button2.Text = "5";
                    button3.Text = "6";
                    button4.Text = "7";
                    correctAwnser = 2;
                    break;
                case 17:
                    Q1lblQuestion.Text = "Колку е 10% од 200?";
                    button1.Text = "20";
                    button2.Text = "25";
                    button3.Text = "30";
                    button4.Text = "15";
                    correctAwnser = 1;
                    break;
                case 18:
                    Q1lblQuestion.Text = "Колку е 2 + 3 * 4?";
                    button1.Text = "10";
                    button2.Text = "12";
                    button3.Text = "14";
                    button4.Text = "16";
                    correctAwnser = 3;
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
            lblTimer.Text ="Timer: " + remainingSeconds.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            if (remainingSeconds > 0)
            {
                UpdateTimerDisplay();
            }

            if (remainingSeconds < 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Do you want to start the test again?", "Retry Test",
                                          MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Retry)
                {
                    questionsNumber = 1;
                    askQuestion(questionsNumber);
                    ResetTimer();
                }
                else
                {
                    ShowMainFormAndCloseQuiz();
                    ResetTimer();
                }
            }
            
        }
    }
}
