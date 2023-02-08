using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_Kurma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int alarmsaati = 99;
        int alarmdakikası = 99;
        int alarmsaniyesi = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for(int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            for (int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.Hour.ToString();
            label3.Text = DateTime.Now.Minute.ToString();
            label4.Text = DateTime.Now.Second.ToString();

            if (alarmsaati.ToString() == label2.Text && alarmdakikası.ToString() == label3.Text && alarmsaniyesi.ToString() == label4.Text)  
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\erdem\\source\\repos\\Alarm Kurma\\Video\\Nothing Breaks Like a Heart.mp4";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alarmsaati = Convert.ToInt32(comboBox1.Text);
            alarmdakikası= Convert.ToInt32(comboBox2.Text);
            listBox1.Items.Add(alarmsaati + "       : " + alarmdakikası);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
