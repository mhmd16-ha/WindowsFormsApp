using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        Stack seq = new Stack();
        private void btn_Undo(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) { 
            int LastIndex = textBox1.Text.Length - 1;
            string last = textBox1.Text.Substring(LastIndex, 1);
            seq.Push(last);
            textBox1.Text= textBox1.Text.Substring(0, LastIndex);
            MessageBox.Show((textBox1.Text));
            }
        } 

       

        private void btn_Redo(object sender, EventArgs e)
        {
            if (seq.Count > 0)
            {
                textBox1.Text += seq.Pop();
            }
           
        }
    }
}
