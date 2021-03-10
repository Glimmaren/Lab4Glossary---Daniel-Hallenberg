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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            FormCore coreForm = new FormCore();
            coreForm.Show();
        }
    }
}
