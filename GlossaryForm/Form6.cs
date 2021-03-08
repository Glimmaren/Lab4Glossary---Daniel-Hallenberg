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
    public partial class PracticeForm : Form //TODO KLIPP BANDEN MELLAN MANGEFORM, FIXA LAYOUT!!!!
    {
        private Word word;
        private string translateThis, rightWord, answer;
        int guessCount;
        
        public PracticeForm()
        {
            InitializeComponent();
            word = ManageForm.wordlist.GetWordToPractice();
            lbl_FromLanguage.Text = ManageForm.wordlist.Languages[word.FromLanguage].ToString();
            lbl_ToLanguage.Text = ManageForm.wordlist.Languages[word.ToLanguage].ToString();
            translateThis = word.Translations[word.FromLanguage];
            rightWord = word.Translations[word.ToLanguage];

            lbl_GlossWord.Text = translateThis;
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            answer = txtBox_UserWord.Text;

            if (answer.Equals(rightWord))
            {
                lbl_CorrectInCorrect.Text = "CORRECT!!";
                Thread.Sleep(500);

                lbl_CorrectInCorrect.Text = "";
                txtBox_UserWord.Text = "";

                word = ManageForm.wordlist.GetWordToPractice();
                lbl_FromLanguage.Text = ManageForm.wordlist.Languages[word.FromLanguage].ToString();
                lbl_ToLanguage.Text = ManageForm.wordlist.Languages[word.ToLanguage].ToString();
                translateThis = word.Translations[word.FromLanguage];
                lbl_GlossWord.Text = translateThis;
                rightWord = word.Translations[word.ToLanguage];
                guessCount = 0;
            }
            else if (guessCount >= 3)
            {
                lbl_CorrectInCorrect.Text = $"No more tries!!! Right word was {rightWord}";
                guessCount = 0;

                lbl_CorrectInCorrect.Text = "";
                txtBox_UserWord.Text = "";

                word = ManageForm.wordlist.GetWordToPractice();
                lbl_FromLanguage.Text = ManageForm.wordlist.Languages[word.FromLanguage].ToString();
                lbl_ToLanguage.Text = ManageForm.wordlist.Languages[word.ToLanguage].ToString();
                translateThis = word.Translations[word.FromLanguage];
                lbl_GlossWord.Text = translateThis;
                rightWord = word.Translations[word.ToLanguage];
                guessCount = 0;
            }
            else
            {
                lbl_CorrectInCorrect.Text = "INCORRECT!!, Try Again";
                Thread.Sleep(200);
                guessCount++;
            }
        }
    }
}
