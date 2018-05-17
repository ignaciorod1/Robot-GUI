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
        private string inputText;

        public Form1()
        {
            potVal = "0";                          //inicialización del valor del potenciometro
            InitializeComponent();
            serialPort1.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  // regar 
        {
            serialPort1.Write("$0");
        }

        private void button2_Click(object sender, EventArgs e)  // sembrar
        {
            serialPort1.Write("$1");
        }

        private void button3_Click(object sender, EventArgs e)  // arar
        {
            serialPort1.Write("$2");
        }

        private void button4_Click(object sender, EventArgs e)  // cortar
        {
            serialPort1.Write("$3");
        }

        private void button5_Click(object sender, EventArgs e)  // demo
        {
            serialPort1.Write("$4");
        }

        private void button6_Click(object sender, EventArgs e)  // luces
        {
            serialPort1.Write("$5");
        }

        private void button7_Click(object sender, EventArgs e)  // stop
        {
            serialPort1.Write("$6");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string potVal = serialPort1.ReadLine();
            this.BeginInvoke(new LineReceivedEvent(LineReceived), potVal);
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
            inputText = textBox1.Text;    // guarda en la variable de texto de entrada lo escrito en el panel
            serialPort1.Write(inputText);   // lo envia al serial
        }

        private void label3_Click(object sender, EventArgs e)   // puertos COM
        {
            inputText = textBox1.Text;    // guarda en la variable de texto de entrada lo escrito en el panel
            serialPort1.Write(inputText);   // lo envia al serial
        }
    }
}
