using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlossaryForm
{
    public partial class FormRemoveWord : Form
    {
        private string word;
        private string strLanguage;
        private int language;
        public event EventHandler RemoveButtonClick;//Används för att skicka event till FormCore
        public FormRemoveWord()
        {
            InitializeComponent();

            cmbBox_Language.DataSource = FormCore.wordlist.Languages;
            language = cmbBox_Language.SelectedIndex;
        }
        private void btn_RemoveWord_Click(object sender, EventArgs e)
        {
            strLanguage = cmbBox_Language.Text;
            word = cmbBox_word.Text;

            FormCore.wordlist.Remove(language, word);
            FormCore.wordlist.Save();

            if (RemoveButtonClick != null)
            {
                this.RemoveButtonClick(this, EventArgs.Empty);
            }
            cmbBox_Language.DataSource = FormCore.wordlist.Languages;
            cmbBox_word.Refresh();
        }
        private void cmbBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] words = new string[FormCore.wordlist.Count()];
            int count = 0;
            language = cmbBox_Language.SelectedIndex;

            Action<string[]> showtrans = (x) =>
            {
                words[count] = x[language];                
                count++;
            };
          
            FormCore.wordlist.List(language, showtrans);

            cmbBox_word.DataSource = words.ToList();
        }
    }
}
