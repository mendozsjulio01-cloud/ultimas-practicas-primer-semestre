using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Practica1_Arduino_Visual
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        //SerialPort serilPort;

        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM3", 9600);
            Arduino.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");
        }
    }
}
