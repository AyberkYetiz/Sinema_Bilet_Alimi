using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bileti_Alım_Sayfası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sinema:"+ comboBox1.Text);
            listBox1.Items.Add("Film:"+ comboBox2.Text);
            listBox1.Items.Add("Seans:"+ comboBox3.Text);
            listBox1.Items.Add("Tarih:"+ dateTimePicker1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kullanıcı adı:"+ textBox1.Text);
            listBox1.Items.Add("Kullanıcı Şifresi:"+ textBox2.Text);
        }
    }
}
