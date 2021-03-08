using GlossaryLibary;
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
    public partial class ManageForm : Form
    {

        public static Wordlist wordlist;
        public static string[] PopulateList()
        {
            string[] list = Wordlist.GetLists();

            return list;
        }

        public static string[] GetWordlist(int sortBy, string listName)
        {
            int count = 1;
            wordlist = Wordlist.LoadList(listName);
            string[] words = new string[1 + wordlist.Count()];

            for (int i = 0; i < wordlist.Languages.Length; i++)
            {
                words[0] += wordlist.Languages[i] + "\t";
            } 

            Action<string[]> showtrans = (x) =>
            {  
                for (int i = 0; i < x.Length; i++)
                {
                    words[count] += x[i] + "\t";
                }

                count++;
            };

            wordlist.List(sortBy, showtrans);
            
            return words;        
        }

        public static void RefreshList()
        {
            
        }

        public ManageForm()
        {
            InitializeComponent();

            lstbox_Wordlists.DataSource = PopulateList();
        }

        private void lstbox_Wordlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] words = GetWordlist(0, lstbox_Wordlists.Text);
            string[] sortByLanguage = words[0].Split('\t', StringSplitOptions.RemoveEmptyEntries);
            int numberOfWords = words.Length - 1;

            chkbox_SortBy.Items.Clear();
            lstbox_Words.DataSource = words;
            txtbx_Count.Text = numberOfWords.ToString();

            foreach (var lang in sortByLanguage)
            {
                chkbox_SortBy.Items.Add(lang);
            }
            
        }

        private void chkbox_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] words = GetWordlist(chkbox_SortBy.SelectedIndex, lstbox_Wordlists.Text);

            lstbox_Words.DataSource = words;

        }

        private void chkbox_SortBy_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chkbox_SortBy.Items.Count; ++ix)
                if (ix != e.Index) chkbox_SortBy.SetItemChecked(ix, false);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddWordForm addWord = new AddWordForm();
            addWord.Show();
        }
    }
}
