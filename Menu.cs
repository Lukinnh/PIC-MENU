using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI;

namespace SoftwarePIC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.FRMconsulta f = new UI.FRMconsulta();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMCliente c = new FRMCliente();
            c.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            string myText = "Vertical text";

            FontFamily fontFamily = new FontFamily("Lucida Console");
            Font font = new Font(
            fontFamily,
               14,
               FontStyle.Regular,
               GraphicsUnit.Point);
            PointF pointF = new PointF(40, 10);
            StringFormat stringFormat = new StringFormat();
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));

            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            e.Graphics.DrawString(myText, font, solidBrush, pointF, stringFormat);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
