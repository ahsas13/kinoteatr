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
    public partial class HallStatusForm : Form
    {
        OrdersForm ordersForm;
        int ordersCount = 0;
        public HallStatusForm(OrdersForm ordersForm, int ordersCount)
        {
            InitializeComponent();
            this.ordersForm = ordersForm;
            this.ordersCount = ordersCount;
        }

        private void HallStatusForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillPolygon(Brushes.BurlyWood, new Point[4] { new Point(0, 0), new Point(50, 0), new Point(50, 500), new Point(0, 500) }); // левая стена
            e.Graphics.FillPolygon(Brushes.BurlyWood, new Point[4] { new Point(450, 0), new Point(500, 0), new Point(500, 500), new Point(450, 500) }); // правая стена
            e.Graphics.FillPolygon(new SolidBrush(System.Drawing.ColorTranslator.FromHtml("#bd9b7b")), new Point[4] { new Point(100, 0), new Point(100, 100), new Point(400, 100), new Point(400, 0) }); // пол сцены
            e.Graphics.FillPolygon(Brushes.Black, new Point[4] { new Point(125, 0), new Point(125, 50), new Point(375, 50), new Point(375, 0) }); // рамка экрана
            e.Graphics.FillPolygon(Brushes.White, new Point[4] { new Point(150, 0), new Point(150, 50), new Point(350, 50), new Point(350, 0) }); // экран

            int chairWidth = (350 / Properties.Settings.Default.colsCount)-4;
            int chairHeight = (325 / Properties.Settings.Default.rowsCount)-4;
            int offsetX = 75;
            int offsetY = 150;
            int counter= 0;

            for (int i = 0; i < Properties.Settings.Default.rowsCount; i++) {
                for (int j = 0; j < Properties.Settings.Default.colsCount; j++) {
                    counter++;
                    if (counter <= ordersCount)
                    {
                        e.Graphics.FillRectangle(Brushes.Yellow, offsetX, offsetY, chairWidth, chairHeight);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.YellowGreen, offsetX, offsetY, chairWidth, chairHeight);
                    }
                    e.Graphics.DrawRectangle(Pens.DarkGray, offsetX, offsetY, chairWidth, chairHeight);
                    offsetX+=chairWidth+4;
                }
                offsetX = 75;
                offsetY += chairHeight+4;
            }
        }

        private void HallStatusForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ordersForm.Show();
        }

        private void HallStatusForm_Load(object sender, EventArgs e)
        {

        }
    }
}
