using GlossaryLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlossaryForm
{
    public partial class FormPractice : Form
    {
        private Word word;
        private string rightWord, answer;
        int guessCount;
        public FormPractice()
        {
            InitializeComponent();
            this.KeyPreview = true;
            guessCount = 0;
            SetWord();
        }
        private void FormPractice_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                btn_guess_Click(this, new EventArgs());
            }
        }
        private void btn_guess_Click(object sender, EventArgs e)
        {
            answer = txtBox_UserWord.Text.ToLower();
          
            CheckAnswer(answer);       
        }
        private void SetWord()
        {
            word = FormCore.wordlist.GetWordToPractice();
            txtBox_UserWord.Text = "";

            lbl_FromLanguage.Text = FormCore.wordlist.Languages[word.FromLanguage].ToString() + ": "
                + word.Translations[word.FromLanguage];
            lbl_ToLanguage.Text = FormCore.wordlist.Languages[word.ToLanguage].ToString() + ": ";
            rightWord = word.Translations[word.ToLanguage];
        }     
        private void CheckAnswer(string answer)
        {
            if (answer.Equals(rightWord))
            {
                MessageBox.Show("Correct!");

                SetWord();
                guessCount = 0;
            }
            else
            {

                if (guessCount < 2)
                {
                    guessCount++;
                    MessageBox.Show($"INCORRECT!! Guess {guessCount}/3");
                    txtBox_UserWord.Text = "";
                    
                }
                else
                {
                    MessageBox.Show($"No more tries!!!" +
                        $" Right word was <{rightWord.ToUpper()}>");

                    SetWord();
                    guessCount = 0;

                }
            }
        }//gav allt arbete med att kolla och svara till denna methoden
    }
}
