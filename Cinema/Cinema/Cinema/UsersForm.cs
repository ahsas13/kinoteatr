using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Cinema
{
    public partial class UsersForm : Form
    {
        AdminForm adminForm;
        public UsersForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void saveChanges()
        {
            usersBindingSource.EndEdit();
            usersTableAdapter.Update(kinoDataSet);
            kinoDataSet.AcceptChanges();
            this.usersTableAdapter.Fill(this.kinoDataSet.Клиенты);
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.kinoDataSet.Клиенты);
        }

        private void addShowBTN_Click(object sender, EventArgs e)
        {
            addShowBTN.Checked = !addShowBTN.Checked;
            addPanel.Visible = addShowBTN.Checked;
            editShowBTN.Checked = false;
            editPanel.Visible = false;
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

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void closeThisForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editUserBTN_Click(object sender, EventArgs e)
        {
            if (editPassTB.Text == editPassConfirmTB.Text)
            {
                if (usersList.Rows[usersList.SelectedRows[0].Index].Cells[1].Value.ToString() == "Admin" && editLoginTB.Text != "Admin")
                {
                    MessageBox.Show("Нельзя изменить логин администратора", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else if ((usersList.Rows[usersList.SelectedRows[0].Index].Cells[1].Value.ToString() != addLoginTB.Text) && 
                         (kinoDataSet.Tables["Клиенты"].Select("Логин = '" + addLoginTB.Text+"'").Length > 0))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    if (editPassTB.Text != string.Empty)
                    foreach (Control c in editPanel.Controls)
                    {
                        foreach (Binding b in c.DataBindings)
                        {
                            b.WriteValue();
                        }
                    }
                    this.saveChanges();
                }
            }
            else
            {
                MessageBox.Show("Введённые пароли должны совпадать!", "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            usersList.AutoResizeColumns();
            usersList.AutoResizeRows();
        }

        private void addUserBTN_Click(object sender, EventArgs e)
        {

            if (addPassTB.Text == addPassConfirmTB.Text)
            {
                if (kinoDataSet.Tables["Клиенты"].Select("Логин = '" + addLoginTB.Text+"'").Length > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                else
                {
                    kinoDataSet.Клиенты.AddКлиентыRow(addLoginTB.Text,(addPassTB.Text), addNameTB.Text, addPassportTB.Text);
                    saveChanges();
                }
            }
            else
            {
                MessageBox.Show("Введённые пароли должны совпадать!", "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSelectedBTN_Click(object sender, EventArgs e)
        {
            if (usersList.Rows[usersList.SelectedRows[0].Index].Cells[1].Value.ToString() != "Admin")
            {
                if (MessageBox.Show("Вы действительно хотите удалить этого пользователя?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in usersList.SelectedRows)
                    {
                        usersBindingSource.RemoveAt(item.Index);
                    }
                    saveChanges();
                }
            }
            else
            {
                MessageBox.Show("Нельзя удалить администратора!", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
