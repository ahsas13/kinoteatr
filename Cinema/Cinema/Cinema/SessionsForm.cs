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
    public partial class SessionsForm : Form
    {
        AdminForm adminForm;

        public SessionsForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void saveChanges()
        {
            filmsSessionsBindingSource.EndEdit();
            sessionsTableAdapter.Update(kinoDataSet);
            kinoDataSet.AcceptChanges();
            this.sessionsTableAdapter.Fill(this.kinoDataSet.Сеансы);
            this.filmsTableAdapter.Fill(this.kinoDataSet.Фильмы);
        }

        private void SessionsForm_Load(object sender, EventArgs e)
        {
            this.sessionsTableAdapter.Fill(this.kinoDataSet.Сеансы);
            this.filmsTableAdapter.Fill(this.kinoDataSet.Фильмы);
        }

        private void closeThisForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SessionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
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
            addPanel.Visible = addShowBTN.Checked;
            editShowBTN.Checked = false;
            editPanel.Visible = false;
        }

        private void editSessionBTN_Click(object sender, EventArgs e)
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

        private void addSessionBTN_Click(object sender, EventArgs e)
        {
            kinoDataSet.ФильмыRow dr = kinoDataSet.Фильмы.FindByКод_фильма(int.Parse(filmsList.Rows[filmsList.SelectedRows[0].Index].Cells[0].Value.ToString()));
            kinoDataSet.Сеансы.AddСеансыRow(addDateTP.Value.Date, dr, addTypeCB.Text, Convert.ToInt32(addCostTB.Value));
            this.saveChanges();
        }

        private void deleteSelectedBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот сеанс?\nЭто действие невозможно отменить.", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in sessionsList.SelectedRows)
                {
                    filmsSessionsBindingSource.RemoveAt(item.Index);
                }
                saveChanges();
            }
        }
    }
}
