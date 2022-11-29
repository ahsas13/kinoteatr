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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

 

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void forgotPassLNK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Для восстановления пароля свяжитесь с администратором кинотеатра.");
        }
        private void Button_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.kinoConnectionString);
            conn.Open();
            OleDbCommand checkLogin = conn.CreateCommand();
            checkLogin.CommandText = "SELECT Код_клиента FROM Клиенты WHERE Логин = '" + loginTB.Text + "' AND Пароль = '" + (passTB.Text) + "'";
            int authed = Convert.ToInt32(checkLogin.ExecuteScalar());
            conn.Close();
            if (authed > 0)
            {
                if (loginTB.Text == "Admin")
                {
                    AdminForm adminForm = new AdminForm(this);
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    UserForm userForm = new UserForm(this, authed);
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Увы, вы ввели неправильный логи или пароль.\nПопытайтесь ещё раз.", "Войти не получилось", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
