using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text;

namespace XCTU_COPY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #if MOCK
                serialPort = new MockSerialPort();
                MessageBox.Show("Running in Mock Mode. No hardware required.");
            #else
                serialPort = new SerialPort();
            #endif
                serialPort.DataReceived += serialPort_DataReceived;
                serialPort.ErrorReceived += serialPort_ErrorReceived;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void buttonScanPort_Click(object sender, EventArgs e)
        {
            if (LabelStatus.Text == "STATUS: CONNECTED")
            {
                MessageBox.Show("Connection in progress. Please disconnect to scan for new ports.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ComboBoxPort.Items.Clear();
            string[] availablePorts = SerialPort.GetPortNames();
            if (availablePorts.Length == 0)
            {
                MessageBox.Show("No COM ports detected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ComboBoxPort.Items.AddRange(availablePorts);
            try
            {
                ComboBoxPort.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting COM port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboBoxPort.Text = string.Empty;
                ComboBoxPort.Items.Clear();
                return;
            }
            ComboBoxPort.DroppedDown = true;
        }
        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            // Check if currently connected
            if (LabelStatus.Text == "STATUS: CONNECTED")
            {
                // Ensure the selected port is the same as the connected port
                if (ComboBoxPort.SelectedItem.ToString() != serialPort.PortName)
                {
                    MessageBox.Show("Cannot change COM port while connected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // Check if there are available ports
            if (ComboBoxPort.Items.Count == 0)
            {
                MessageBox.Show("No available ports. Please scan ports first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Check if a port is selected
            if (ComboBoxPort.SelectedItem == null)
            {
                MessageBox.Show("Please select a port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                serialPort.BaudRate = Convert.ToInt32(ComboBoxBaudRate.SelectedItem);
                serialPort.PortName = ComboBoxPort.SelectedItem.ToString();
                serialPort.Open();

                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();

                LabelStatus.Text = "STATUS: CONNECTED";
                ButtonConnect.SendToBack();
                ButttonDisconnect.BringToFront();
                PictureBoxConnectionStatus.BackColor = Color.ForestGreen;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Port is already open.\n" + ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Access to the port is denied.\n" + ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("One or more properties for the port are invalid.\n" + ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("The port name does not begin with 'COM'.\n" + ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show("The port is in an invalid state.\n" + ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check the hardware, COM port, and baud rate, then try again.\n" + ex.Message, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ButttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();

            serialPort.Close();
            ButttonDisconnect.SendToBack();
            ButtonConnect.BringToFront();
            LabelStatus.Text = "STATUS: DISCONNECTED";
            PictureBoxConnectionStatus.BackColor = Color.Red;
            ComboBoxBaudRate.SelectedIndex = -1;
            ComboBoxPort.SelectedIndex = -1;

            textBox1.Text = "";
        }
        private void button01_Click(object sender, EventArgs e)
        {
            SendData(01);
        }
        private void SendData(byte data)
        {
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();

            byte[] dataToSend = { data };
            System.Threading.Thread.Sleep(100); // Delay to ensure the Arduino is ready
            serialPort.Write(dataToSend, 0, dataToSend.Length);
            string hex = BitConverter.ToString(dataToSend);
            textBox1.AppendText(hex + Environment.NewLine);
        }
        private void button02_Click(object sender, EventArgs e)
        {
            SendData(0x02);
        }
        private void button09_Click(object sender, EventArgs e)
        {
            SendData(0x09);
        }
        private StringBuilder dataBuffer = new StringBuilder();
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string received = serialPort.ReadLine();
            Console.WriteLine(received);
            this.Invoke(new MethodInvoker(delegate {
                AppendText(received + Environment.NewLine);
            }));
        }
        private void serialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            string errorMsg = "Error: " + e.EventType.ToString();
            AppendText(errorMsg + Environment.NewLine);
        }
        private void AppendText(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendText), new object[] { text });
                return;
            }
            textBox1.AppendText(text);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            SendData(0x10);
        }
        private void button0F_Click(object sender, EventArgs e)
        {
            SendData(0x0F);
        }
        private void button0E_Click(object sender, EventArgs e)
        {
            SendData(0x0E);
        }
        private void button0D_Click(object sender, EventArgs e)
        {
            SendData(0x0D);
        }
        private void button03_Click(object sender, EventArgs e)
        {
            SendData(0x03);
        }
        private void button04_Click(object sender, EventArgs e)
        {
            SendData(0x04);
        }
        private void button05_Click(object sender, EventArgs e)
        {
            SendData(0x05);
        }
        private void button06_Click(object sender, EventArgs e)
        {
            SendData(0x06);
        }
        private void button07_Click(object sender, EventArgs e)
        {
            SendData(0x07);
        }
        private void button08_Click(object sender, EventArgs e)
        {
            SendData(0x08);
        }
    }
}