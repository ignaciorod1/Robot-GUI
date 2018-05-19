using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace GUI
{
    public partial class Form1 : Form
    {
        public string potVal;
        private string strBufferOut;
        private string strBufferIn;

        public Form1()
        {
            potVal = "0";                          //inicialización del valor del potenciometro
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnSend.Enabled = false;
        }

        private bool checkSp()      //comprueba si ha conexion serial
        {
            if (serialPort1.IsOpen)
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)  // regar 
        {
            if(checkSp())
            serialPort1.Write("$0");
        }

        private void button2_Click(object sender, EventArgs e)  // sembrar
        {
            if (checkSp())
                serialPort1.Write("$1");
        }

        private void button3_Click(object sender, EventArgs e)  // arar
        {
            if (checkSp())
                serialPort1.Write("$2");
        }

        private void button4_Click(object sender, EventArgs e)  // cortar
        {
            if (checkSp())
                serialPort1.Write("$3");
        }

        private void button5_Click(object sender, EventArgs e)  // demo
        {
            if (checkSp())
                serialPort1.Write("$4");
        }

        private void button6_Click(object sender, EventArgs e)  // luces
        {
            if (checkSp())
                serialPort1.Write("$5");
        }

        private void button7_Click(object sender, EventArgs e)  // stop
        {
            if (checkSp())
                serialPort1.Write("$6");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string Data = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), Data);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private delegate void LineReceivedEvent(string line);

        private void LineReceived(string pot)
        {
            label1.Text = pot;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                
                serialPort1.DiscardOutBuffer();
                strBufferOut = textBox1.Text;    // guarda en la variable de texto de entrada lo escrito en el panel
                serialPort1.Write(strBufferOut);   // lo envia al serial
                textBox1.Clear();                   // limpia la pantalla
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)   // puertos COM
        {
            strBufferOut = textBox1.Text;    // guarda en la variable de texto de entrada lo escrito en el panel
            serialPort1.Write(strBufferOut);   // lo envia al serial
        }

        private void puertoSerialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] availablePorts = SerialPort.GetPortNames();

            CbCOM.Items.Clear();    //   limpia los puertos  del menu de puertos disponibles

            foreach (string port in availablePorts) //escribe en el menu de serial potrs los puertos disponibles
            {
                CbCOM.Items.Add(port);
            }

            if(CbCOM.Items.Count > 0)
            {
                CbCOM.SelectedIndex = 0;
                BtnSend.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay puertos COM en esta epoca del año");
                CbCOM.Items.Clear();
                CbCOM.Text = "";
                strBufferIn = "";
                strBufferOut = "";
                BtnSend.Enabled = false;
            }
        }

  

        private void com3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iniciarConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnConectar.Text == "Iniciar") //Al pulsar, cambia el texto del boton al finalizar e inicia el pueto serie
                {
                    serialPort1.BaudRate = Int32.Parse(CbBaud.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.PortName = CbCOM.Text;


                    try
                    {
                        serialPort1.Open();
                        BtnConectar.Text = "Finalizar";
                        BtnSend.Enabled = true;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }

                else if (BtnConectar.Text == "Finalizar")
                {
                    serialPort1.Close();
                    BtnConectar.Text = "Iniciar";
                    BtnSend.Enabled = false;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
