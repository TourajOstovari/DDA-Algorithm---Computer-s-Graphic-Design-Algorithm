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
        static int y2 = 60; // x2
        static float y1 = 30.0f; // x1
        //==============
        static int x2 = 80; // y2
        static float x1 = 50; // y1
        public Form1()
        {
            InitializeComponent();
            //this.Paint += 
            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {


            Graphics graphics = e.Graphics;
            Pen pen = new Pen(System.Drawing.Color.Black, 5.0f);


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
            catch (Exception)
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = int.Parse(Source_X.Text);
                y1 = int.Parse(Source_Y.Text);
                x2 = int.Parse(Dest_X.Text);
                y2 = int.Parse(Dest_Y.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error Code: " + exc.HResult + "\t" + exc.Message + "\n");
            }
            Form1.ActiveForm.Invalidate();
        }
}
}
