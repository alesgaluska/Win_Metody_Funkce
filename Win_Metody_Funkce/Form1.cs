using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Metody_Funkce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_upravit_Click(object sender, EventArgs e)
        {
            // manualne napsano pro jeden textbox
            string text1 = txt_box1.Text;
            text1 = text1.Replace("Davide","Karle");
            txt_box1.Text = text1;

            // pouzita funkce
            string slova = ReplaceText(txt_box2.Text);
            txt_box2.Text = slova;

            txt_box3.Text = ReplaceText(txt_box3.Text);
            txt_box4.Text = ReplaceText(txt_box4.Text);
            txt_box5.Text = ReplaceText(txt_box5.Text);
            txt_box6.Text = ReplaceText(txt_box6.Text);

        }


        // vytvorena funkce
        public string ReplaceText (string Text)
        {
            Text = Text.Replace("Davide", "Karle");
            Text = Text + Environment.NewLine + Text.Length;
            return Text;
        }

        private void txt_box1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
