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
    public partial class SettingsForm : Form
    {
        AdminForm adminForm;
        public SettingsForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            colsCountTB.Text = Properties.Settings.Default.colsCount.ToString();
            rowsCountTB.Text = Properties.Settings.Default.rowsCount.ToString();
        }

        private void saveChangesBTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.colsCount = Convert.ToInt32(colsCountTB.Text);
            Properties.Settings.Default.rowsCount = Convert.ToInt32(rowsCountTB.Text);
            Properties.Settings.Default.Save();
            MessageBox.Show("Изменения сохранены успешно!", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
