using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GravField_
{
    class GravityField
    {
        List<Planet> planets = new List<Planet>();

        public void AddPlanet(Planet planet)
        {
            planets.Add(planet);
        }
    }

    class Planet
    {
        int x;
        int y; 

        public Planet(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Form1 : Form
    {
        Bitmap background;
        Timer ticker = new Timer();
        public Form1()
        {
            InitializeComponent();
            
            background = new Bitmap(pictureBox1.Bounds.Width, pictureBox1.Bounds.Height);

            ticker.Tick += new EventHandler(onTickEvent);
            ticker.Interval = 30;
            ticker.Enabled = true;

            numericUpDown1.Minimum = 100;

            if (radioButton1.Checked == true)
            {
                numericUpDown1.Enabled = true;
            }
            else


        }
    }
}
