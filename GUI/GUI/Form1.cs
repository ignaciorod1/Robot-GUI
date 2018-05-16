using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public string potVal;
        
        public Form1()
        {
            potVal = "0";         //inicialización del valor del potenciometro
            InitializeComponent();
            serialPort1.Open();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B");
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
    }
}
