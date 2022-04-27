using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
        Template for randomizing a list of things - whether names, food, drinks, etc.

        Author: ELLAINE FONTAMILLAS
        Created: 2021, November 24

 */

namespace RandomizerApp
{
    public partial class MainInterface : Form
    {
        RandomizerClass rc = new RandomizerClass();
        public MainInterface()
        {
            InitializeComponent();
        }

        private void BtnMeld_Click(object sender, EventArgs e)
        {
            string wrd = rc.randomizer();
            this.LblText.Text = wrd;
            //MessageBox.Show("Meld Successful");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
