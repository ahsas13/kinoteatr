using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace Cinema
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("Сеансы на " + "dd MMMMM");
            label2.Text = DateTime.Now.ToString("Скоро в прокате");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 80);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(12, 100);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yKrzARVuePw");

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=XGkDIi-RwIU&themeRefresh=1");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=i0XvzdqAb9k");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=2Tp8kAlkMVE");
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZenQzoqefx0");
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=XGkDIi-RwIU");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AuthForm Auth = new AuthForm();
            Auth.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yKrzARVuePw");
        }


        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(636, 80);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Location = new Point(636, 100);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(960, 80);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Location = new Point(960, 100);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(1277, 80);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Location = new Point(1277, 100);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(1598, 80);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(1598, 100);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=rSsV90E2vjc");
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Location = new Point(318, 94);
        }


        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Location = new Point(318, 104);
        }
    }
}

 
