using System;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;
using System.Windows.Markup;






namespace temperatura
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool puertoCerrado = false;
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            //serialPort.DataReceived += SerialPort_DataReceivedEventHandler(DataReceivedEventHandler);
            serialPort.PortName = "COM7"; // Cambia esto al puerto correcto
            serialPort.BaudRate = 9600;
            //serialPort.Open();"
            soundPlayer = new SoundPlayer("D:\\codigo led\\temperatura\\Warning Siren-SoundBible.com-898272278.wav");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (puertoCerrado == false)
            {
                conectar();
            }
            else
            {
                noConectado();
            }
        }
        private void conectar()
        {
            try
            {
                puertoCerrado = true;
                serialPort.Open();
                botonConectar.Text = "DESCONECTAR";
                botonConectar.BackColor = Color.Black;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);


            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
        private void noConectado()
        {
            try
            {
                puertoCerrado = false;
                serialPort.Close();
                botonConectar.Text = "CONECTAR";
                botonConectar.BackColor = Color.Blue;
                listBox1.Items.Clear();
                temperaturaLabel.Text = "Temperatura %";
                humedadLabel.Text = "HUMEDAD %";

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

        }


        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine().Trim();

                if (string.IsNullOrWhiteSpace(data))
                    return;

                // ❌ Ignora si Arduino manda "Error"
                if (data == "Error")
                    return;

                this.Invoke(new MethodInvoker(delegate
                {
                    string[] valores = data.Split(',');

                    if (valores.Length == 2)
                    {
                        humedadLabel.Text = valores[0];
                        temperaturaLabel.Text = valores[1];
                        listBox1.Items.Add("Humedad: " + valores[0] + " Tempertura: " + valores[1]);
                    }
                }));
            }
            catch { }
        }





        private void humedadLabel_Click(object sender, EventArgs e)
        {

        }
        private void From1_Load(object sender, EventArgs e)
        {
        }
      
        private void temperaturaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
