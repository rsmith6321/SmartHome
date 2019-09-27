using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arduino
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            disableControls();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }

        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            port.Write("#STAR\n");
            button1.Text = "Disconnect";
            enableControls();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox1.Checked)
                {
                    port.Write("#LED1ON\n");
                }
                else
                {
                    port.Write("#LED1OF\n");
                }
            }
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button1.Text = "Connect";
            disableControls();
            resetDefaults();
        }

        private void enableControls()
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            groupBox1.Enabled = true;
            

        }

        private void disableControls()
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Checked = false;
            groupBox1.Enabled = false;
           
        }

        private void resetDefaults()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox2.Checked)
                {
                    port.Write("#LED2ON\n");
                }
                else
                {
                    port.Write("#LED2OF\n");
                }
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                if (checkBox3.Checked)
                {
                    port.Write("#LED3ON\n");
                }
                else
                {
                    port.Write("#LED3OF\n");
                }
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 1.Fist think choose your serial no. of your board \n\n " +
                "2.Click connect button \n\n " +
                "3.Pick your LED color on each room \n\n " +
                "4.Your status will be applied at right side of the screen \n\n ", "How to ues", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Connect button";
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void ComboBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose your serial no.";
        }

        private void ComboBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void LinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.arduinoall.com/?gclid=Cj0KCQjww7HsBRDkARIsAARsIT5sBGYT30FpqtiDpBiJsoOjVOArWvgVpuJonovdgNK6efCbeDjpdXEaAlLNEALw_wcB");
        }
    }
}
