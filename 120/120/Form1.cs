using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _120
{

    public partial class Form1 : Form
    {    int i = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                SolidBrush clBlack = new SolidBrush(Color.Black);
                Pen myWind = new Pen(Color.Yellow, 2);
                g.FillPolygon(clBlack, new Point[]
        {
             new Point(120,100),new Point(140,120),
             new Point(140,120),new Point(140,140),
             new Point(140,140),new Point(120,160),
             new Point(120,160),new Point(100,140),
             new Point(100,140),new Point(100,120),
             new Point(100,120),new Point(120,100)

        });
                i = 2;
            }
            if (i == 1)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                SolidBrush clBlack = new SolidBrush(Color.Black);
                Pen myWind = new Pen(Color.Yellow, 2);
                g.FillPolygon(clBlack, new Point[]
        {
             new Point(80,80),new Point(170,80),
             new Point(170,80),new Point(170,150),
             new Point(170,150),new Point(80,150),
             new Point(80,150),new Point(80,80),

        });
                i = 2;
            }
            if (i == 0)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.White);
                SolidBrush clBlack = new SolidBrush(Color.Black);
                Pen myWind = new Pen(Color.Yellow, 2);
                g.FillPolygon(clBlack, new Point[]
        {
             new Point(100,100),new Point(150,100),
             new Point(150,100),new Point(80,170),
             new Point(80,170),new Point(100,100)
            
        }) ;
                i = 1;
            }
           


            }
        }
    }

