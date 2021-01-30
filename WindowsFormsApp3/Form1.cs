using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        bool canDraw = false;
        public static Color color;
        public static int x1;
        public static int x2;
        public static int y1;
        public static int y2;
        public Form1()
        {
            InitializeComponent();
        }
        Form f = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            f.Show();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f.Show();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (canDraw)
            {
                Graphics gr = e.Graphics;
                Pen p = new Pen(Color.Blue, 5);
                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);
                gr.DrawLine(p, p1, p2);
                gr.Dispose();
                canDraw = false;
            }
            
        }
        
        private void drawToolStripMenuItem1_Click(object sender, EventArgs e) 
        {
            canDraw = false;
            canDraw = true;
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }
    }
}
