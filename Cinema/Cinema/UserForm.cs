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
    public partial class UserForm : Form
    {
        AuthForm authForm;
        int userID;
        public UserForm(AuthForm authForm, int userID)
        {
            InitializeComponent();
            this.authForm = authForm;
            this.userID = userID;
        }

        private void updateOrdersList()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.kinoConnectionString);
            conn.Open();
            OleDbCommand commandRes = conn.CreateCommand();
            commandRes.CommandText =
                "SELECT        Заказы.[Код_заказа], Сеансы.Дата, Сеансы.[Вид_сеанса], Сеансы.Стоимость, Фильмы.[Название_фильма] " +
                "FROM            ((Заказы INNER JOIN " +
                         "Сеансы ON Заказы.[Код_сеанса] = Сеансы.[Код_сеанса]) INNER JOIN " +
                         "Фильмы ON Сеансы.[Код_фильма] = Фильмы.[Код_фильма]) " +
                "WHERE        (Заказы.[Код_клиента] = " + userID.ToString() + ") ";
            var dataReader = commandRes.ExecuteReader();
            ordersList.Rows.Clear();
            while (dataReader.Read())
            {
                ordersList.Rows.Add(dataReader["Код_заказа"].ToString(), Convert.ToDateTime(dataReader["Дата"].ToString()).ToShortDateString(), dataReader["Вид_сеанса"].ToString(), dataReader["Стоимость"].ToString(), dataReader["Название_фильма"].ToString());
            }
            conn.Close();
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            authForm.Close();
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

        private void UserForm_VisibleChanged(object sender, EventArgs e)
        {
            if (ordersList.Visible)
            {
                updateOrdersList();
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.sessionsTableAdapter.Fill(this.kinoDataSet.Сеансы);
            this.filmsTableAdapter.Fill(this.kinoDataSet.Фильмы);

        }

        private void addOrderBTN_Click(object sender, EventArgs e)
        {
            if (sessionsList.SelectedRows.Count > 0)
            {
                string sessionID = sessionsList.Rows[sessionsList.SelectedRows[0].Index].Cells[0].Value.ToString();
                OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.kinoConnectionString);
                conn.Open();

                OleDbCommand commandResult = conn.CreateCommand();
                commandResult.CommandText = "SELECT COUNT(Код_заказа) FROM Заказы WHERE Код_сеанса = "+sessionID.ToString()+"";
                int ordersCount = int.Parse(commandResult.ExecuteScalar().ToString());
                if (ordersCount < Properties.Settings.Default.rowsCount * Properties.Settings.Default.colsCount)
                {
                    commandResult = conn.CreateCommand();
                    commandResult.CommandText = "SELECT MAX(Код_заказа) FROM Заказы";
                    var pstId = commandResult.ExecuteScalar();
                    int pastId = 1;
                    if (pstId != DBNull.Value)
                    {
                        pastId += Convert.ToInt32(pstId);
                    }
                    commandResult.CommandText =
                        "INSERT INTO Заказы " +
                        "VALUES (" + pastId.ToString() + ", " + sessionID.ToString() + ", " + userID.ToString() + ") ";
                    var dataReader = commandResult.ExecuteNonQuery();
                    MessageBox.Show("Заказ успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Увы, все места уже заняты!");
                }
                conn.Close();
                updateOrdersList();
            }
        }

        private void просмотрСеансовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();

        }
    }
}
