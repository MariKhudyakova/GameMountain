using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMountains
{
    public partial class InfAboutTheMountain : Form
    {
        public InfAboutTheMountain()
        {
            InitializeComponent();
        }

        private Bitmap getFormBackgroundImage()
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(this.BackgroundImage,
                    new Rectangle(0, 0, bmp.Width, bmp.Height));
            }
            return bmp;
        }

        private void InfAboutTheMountain_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttnGo_Click(object sender, EventArgs e)
        {
            bool create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "WomensGroup")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }

            if (create == false)
            {
                WomensGroup aboutRoutes = new WomensGroup();
                this.Hide();
                aboutRoutes.Show();
            }

            //if (pictureBox1.Visible)
            //{
            //    pictureBox1.Hide();
            //    //bttnGo.Text = "Скрыто";
            //}
            //else
            //{
            //    pictureBox1.Show();
            //    //bttnGo.Text = "Отображено";
            //}
        }
    }
}
