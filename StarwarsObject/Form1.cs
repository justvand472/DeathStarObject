using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarwarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            DeathStar(100, 20,100);
        }
        public void DeathStar(float x, float y, float pixels)
        {
            Pen pencil = new Pen(Color.White,1);
            SolidBrush brush = new SolidBrush(Color.DimGray);     
            g.DrawArc(pencil, x, y, pixels, pixels, 275, 350);        
            g.DrawLine(pencil, x + pixels * 9 / 20, y, x + pixels * 19 / 40, y + pixels / 10);
            g.DrawLine(pencil, x + pixels * 11 / 20, y, x + pixels * 21 / 40, y + pixels / 10);
            g.DrawLine(pencil, x + pixels * 19 / 40, y + pixels / 10, x + pixels * 21 / 40, y + pixels / 10);
            g.FillEllipse(brush, x + pixels / 5, y + pixels / 5, pixels / 4, pixels / 4);
            g.DrawEllipse(pencil, x + pixels * 11 / 50, y + pixels * 11 / 50, pixels / 5, pixels / 5);
        }    
    }
}
