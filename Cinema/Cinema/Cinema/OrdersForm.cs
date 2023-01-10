using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Cinema
{
    public partial class OrdersForm : Form
    {
        AdminForm adminForm;
        public OrdersForm(AdminForm adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
        }

        private void OrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminForm.Show();
        }

        private void closeThisFormBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<string[]> users = new List<string[]>();

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.kinoConnectionString);
            conn.Open();
            OleDbCommand clientInfoResult = conn.CreateCommand();
            clientInfoResult.CommandText = "SELECT * FROM Клиенты";
            var clientInfo = clientInfoResult.ExecuteReader();
            while (clientInfo.Read())
            {
                users.Add(new string[4] { clientInfo["Код_клиента"].ToString(), clientInfo["Логин"].ToString(), clientInfo["ФИО"].ToString(), clientInfo["Номер_паспорта"].ToString() });
            }
            conn.Close();
            this.ordersTableAdapter.Fill(this.kinoDataSet.Заказы);
            this.sessionsTableAdapter.Fill(this.kinoDataSet.Сеансы);
            this.filmsTableAdapter.Fill(this.kinoDataSet.Фильмы);
        }

        private void sessionsList_SelectionChanged(object sender, EventArgs e)
        {

            foreach (var user in users)
            {
                for (int i = 0; i < ordersList.Rows.Count; i++)
                {
                    if (ordersList.Rows[i].Cells[2].Value.ToString() == user[0])
                    {
                        ordersList.Rows[i].Cells[3].Value = user[1];
                        ordersList.Rows[i].Cells[4].Value = user[2];
                        ordersList.Rows[i].Cells[5].Value = user[3];
                    }
                }
            }

            infoProfitTB.Text = "0";
            if (sessionsList.SelectedRows.Count>0 && ordersList.Rows.Count>0)
                infoProfitTB.Text = (Convert.ToInt32(sessionsList.Rows[sessionsList.SelectedRows[0].Index].Cells[4].Value.ToString()) * ordersList.Rows.Count).ToString();
        }

        private void deleteSelectedBTN_Click(object sender, EventArgs e)
        {
            if (ordersList.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить выбранный заказ?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string orderID = ordersList.Rows[ordersList.SelectedRows[0].Index].Cells[0].Value.ToString();
                    OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.kinoConnectionString);
                    conn.Open();
                    OleDbCommand commandRes = conn.CreateCommand();
                    commandRes.CommandText =
                        "DELETE FROM Заказы " +
                        "WHERE (Заказы.[Код_заказа] = " + orderID + ") ";
                    var dataReader = commandRes.ExecuteNonQuery();
                    conn.Close();
                    for (int i = 0; i < ordersList.Rows.Count; i++)
                    {
                        if (ordersList.Rows[i].Cells[0].Value.ToString() == orderID)
                        {
                            ordersList.Rows.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
        }

        private void showHallBTN_Click(object sender, EventArgs e)
        {
            HallStatusForm hallStatusForm = new HallStatusForm(this, ordersList.Rows.Count);
            hallStatusForm.Show();
            this.Hide();
        }
    }
}
