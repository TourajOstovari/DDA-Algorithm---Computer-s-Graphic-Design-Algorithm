using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_first_practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Paint += 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(System.Drawing.Color.Black, 5.0f);

            int y2 = 20; // x2
            float y1 = 30.0f; // x1
            //==============
            int x2 = 180; // y2
            float x1 = 50; // y1
            //==============
            float rep_x1 = x1;
            float rep_y1 = y1;
            System.Collections.Generic.List<float> collect = new List<float>();
            

            System.Collections.Generic.Dictionary<int, int> pairs = new Dictionary<int, int>();

            float m =float.Parse(((float.Parse((y2 - y1).ToString()) / float.Parse((x2 - x1).ToString())).ToString("f3")));
            if(m>1)
            {
                while ((x1 <= x2 || x1 != x2) && (y1 != y2))
                {
                    collect.Add(x1);
                    x1 += m;
                    y1 += 1.0f;
                }
                for (float i = rep_y1; i <= y2;)
                {
                    try
                    {
                        graphics.DrawLine(pen, i++, float.Parse((Math.Round(collect[(int)i])).ToString()), i, float.Parse((Math.Round(collect[(int)i])).ToString()));
                    }
                    catch (Exception)
                    { }
                }
            }
            else if(m<1)
            {
                while ((x1!=x2) && (y1<=y2 || y1!=y2))
                {
                    collect.Add(y1);
                    y1 += m;
                    x1+=1;
                }
                for (float i = rep_x1; i <= x2;)
                {
                    try
                    {
                        graphics.DrawLine(pen, i++, float.Parse((Math.Round(collect[(int)i])).ToString()), i, float.Parse((Math.Round(collect[(int)i])).ToString()));
                    }
                    catch (Exception)
                    {}
                }
            }
            else if(m == 1)
            {
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }
            graphics.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
