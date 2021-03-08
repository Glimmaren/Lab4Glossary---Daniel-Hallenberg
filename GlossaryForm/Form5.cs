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
    public partial class RemoveWord : Form
    {
        private string word;
        private string strLanguage;
        private int language;
        public RemoveWord()
        {
            InitializeComponent();

            cmbBox_Language.DataSource = ManageForm.wordlist.Languages;
            //strLanguage = cmbBox_Language.SelectedIndex;
            language = cmbBox_Language.SelectedIndex;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            strLanguage = cmbBox_Language.Text;
            word = cmbBox_word.Text;
            
            ManageForm.wordlist.Remove(language, word);
            ManageForm.wordlist.Save();

            cmbBox_word.Refresh();

        }

        private void cmbBox_Language_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] words = new string[ManageForm.wordlist.Count()];
            int count = 0;
            //language = Array.IndexOf(ManageForm.wordlist.Languages, strLanguage);
            language = cmbBox_Language.SelectedIndex;

            Action<string[]> showtrans = (x) =>
            {
                words[count] = x[language];                
                count++;
            };
          
            ManageForm.wordlist.List(language, showtrans);

            cmbBox_word.DataSource = words.ToList();
        }
    }
}
