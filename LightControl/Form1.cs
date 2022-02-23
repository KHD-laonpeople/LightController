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

namespace LightControl
{
    public partial class connectState : Form
    {
        public string receiveData;
                                                      //채널 1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 각 채널의 값 0 ~ 255(00 ~ FF) 설정, 초기값 모든채널 0
        public byte[] sendData = { 0x01, 0x00, 0x10, 0x29, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x04 };
        public connectState()
        {
            InitializeComponent();
            portNumber.DataSource = SerialPort.GetPortNames();
            lightKind.Items.Add("Off");
            lightKind.Items.Add("Ring");
            lightKind.Items.Add("Bar");
            lightKind.Items.Add("Coxaml");
        }

        //Port Connect
        private void PortConnet(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen)
            {
                serialPort1.PortName = portNumber.Text;
                serialPort1.BaudRate = 19200;
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);

                serialPort1.Open();
                portState.Text = "연결됨";
                portNumber.Enabled = false;
            }
            else
            {
                serialPort1.Close();
                portState.Text = "연결 해제";
                portNumber.Enabled = true;
            }
        }

        //데이터 수신
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke(new EventHandler(MySerialReceived));
        }        
        private void MySerialReceived(object s, EventArgs e)
        {
            int receiveData = serialPort1.ReadByte();
            dataShowBox.Text += string.Format("{0:X2}", receiveData) + " ";
            dataShowBox.Text += "\n";
        }

        private void SendData(object sender, EventArgs e)
        {
            this.sendData = SendLightData(this.sendData, lightKind.Text);
            serialPort1.Write(sendData,0,sendData.Length);
            foreach(byte data in sendData) dataShowBox.Text += data.ToString("X2") + " ";
            dataShowBox.Text += "\n";

        }
        private byte[] SendLightData(byte[] sendData, string light)
        {
            int hex = int.Parse(lightValue.Text);
            byte value = Convert.ToByte(hex);
            value = value > (byte)180 ? (byte)180 : value;

            switch (light)
            {
                case "Ring":
                    sendData[4] = value;
                    break;
                case "Bar":
                    sendData[5] = value;
                    break;
                case "Coxaml":
                    sendData[7] = value;
                    break;
                case "Off":
                    sendData[4] = 0;
                    sendData[5] = 0;
                    sendData[7] = 0;
                    break;
            }

            return sendData;
        }
    }
}
