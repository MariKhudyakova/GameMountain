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
    public partial class WomensGroup : Form
    {
        public WomensGroup()
        {
            InitializeComponent();
        }

        public void m1(int count)
        {
            var dict = new Dictionary<int, string>
            {
                { 1, "value1" },
                { 2, "value2" },
                { 3, "value3" },
                { 4, "value4" },
                { 5, "value5" },
                { 6, "value6" },
                { 7, "value7" },
                { 8, "value8" },
            };
            lbl.Text = dict[count];
        }

        public void m2()
        {
            lbl.Text = "02222222222222222222222222222222222222222222";
        }

        public int count = 0; //Initialize it on contructor
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count < 9)
            {
                m1(count);
            }
            else
            {
                m2();
            }
            
        }
    }
}
