using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L14GUI
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Thread tRed;
        Thread tGreen;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGreen_Click(object sender, EventArgs e)
        {
            tGreen = new Thread(ThreadGreen);
            tGreen.Start();
        }
        public void ThreadGreen()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Green, 5), new Rectangle(rand.Next(0, this.Width), rand.Next(0, this.Height), 100, 100));
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed 100 Green ");
        }

        private void cmdRed_Click(object sender, EventArgs e)
        {
            tRed = new Thread(ThreadRed);
            tRed.Start();
        }
        public void ThreadRed()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 5), new Rectangle(rand.Next(0, this.Width), rand.Next(0, this.Height), 100, 100));
                Thread.Sleep(100);
            }
            MessageBox.Show("Completed 100 Green ");
        }
    }
}
