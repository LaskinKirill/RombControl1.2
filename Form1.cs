using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RombControl1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
            private void Form1_Load(object sender, EventArgs e)
        {
                                   
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            Point[] pts1 = { new Point(80, 10), new Point(800, 10), new Point(800, 500), new Point(80, 500) };
            gr.FillPolygon(Brushes.Blue, pts1);
            Pen pen = new Pen(Brushes.Red, 3);
            gr.DrawPolygon(pen, pts1);
            Point[] pts2 = { new Point(430, 10), new Point(780, 240), new Point(430, 460), new Point(80, 240) };
            gr.FillPolygon(Brushes.Green, pts2);
        }
    }
}
