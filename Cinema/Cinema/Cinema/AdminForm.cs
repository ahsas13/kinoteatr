using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinema
{
    public partial class AdminForm : Form
    {
        AuthForm authForm;
        public string Asdasd = "";
        public AdminForm(AuthForm authForm)
        {
            InitializeComponent();
            this.authForm = authForm;
        }

        private void saveChanges()
        {
            filmsBindingSource.EndEdit();
            filmsTableAdapter.Update(kinoDataSet);
            kinoDataSet.AcceptChanges();
            this.filmsTableAdapter.Fill(this.kinoDataSet.Фильмы);
        }

        private void AdminForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.filmsTableAdapter.Fill(this.kinoDataSet.Фильмы);
            }

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.authForm.Close();
        }

        private void addFilmBTN_Click(object sender, EventArgs e)
        {
            kinoDataSet.Фильмы.AddФильмыRow(addNameTB.Text, Convert.ToInt32(addLengthNUD.Value), addGenreCB.SelectedItem.ToString(), addDescrTB.Text);
            this.saveChanges();
        }

        private void editFilmBTN_Click(object sender, EventArgs e)
        {
            foreach (Control c in editPanel.Controls)
            {
                foreach (Binding b in c.DataBindings)
                {
                    b.WriteValue();
                }
            }
            this.saveChanges();
        }

        private void editShowBTN_Click(object sender, EventArgs e)
        {
            editShowBTN.Checked = !editShowBTN.Checked;
            editPanel.Visible = editShowBTN.Checked;
            addShowBTN.Checked = false;
            addPanel.Visible = false;
        }

        private void rcEditShow_Click(object sender, EventArgs e)
        {
            editShowBTN.Checked = true;
            editPanel.Visible = true;
            addShowBTN.Checked = false;
            addPanel.Visible = false;
        }

        private void addShowBTN_Click(object sender, EventArgs e)
        {
            addShowBTN.Checked = !addShowBTN.Checked;
            addPanel.Visible = editShowBTN.Checked;
            editShowBTN.Checked = false;
            editPanel.Visible = false;
        }

        private void deleteSelectedBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот фильм?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in filmsList.SelectedRows)
                {
                    filmsBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }

        private void sessionsControlBTN_Click(object sender, EventArgs e)
        {
            SessionsForm sessionsForm = new SessionsForm(this);
            this.Hide();
            sessionsForm.Show();
        }

        private void usersControlShowBTN_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm(this);
            this.Hide();
            usersForm.Show();
        }

        private void filmsList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            filmsList.AutoResizeColumns();
            filmsList.AutoResizeRows();
        }

        private void ordersControlShowBTN_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(this);
            ordersForm.Show();
            this.Hide();
        }

        private void hallPropShowBTN_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
            this.Hide();
        }

        private void просмотрСеансовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
