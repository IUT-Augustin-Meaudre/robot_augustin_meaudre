using ExtendedSerialPort;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RobotInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ReliableSerialPort serialPort1;
        AsyncCallback SerialPort1_DataRecived;
        Robot robot = new Robot();

        public MainWindow()
        {
            InitializeComponent();
            

            serialPort1 = new ReliableSerialPort("COM15", 115200, Parity.None, 8, StopBits.One);
            serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort1.Open();

            
        }

        private void SerialPort1_DataReceived(object sender, DataReceivedArgs e)
        {
            robot.receivedText += Encoding.UTF8.GetString(e.Data, 0, e.Data.Length);
        }

        
        Boolean isColor;

        private void ButtonEnvoyer_Click(object sender, RoutedEventArgs e)
        {
            if (isColor == true)
            {
                ButtonEnvoyer.Background = Brushes.RoyalBlue;
                isColor = false;
            }
            if (isColor == false)
            {
                ButtonEnvoyer.Background = Brushes.Beige;
                isColor = true;
            }
            
            SendMessage();
        }

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter )
            {
                SendMessage();
            }
            
        }

        void SendMessage()
        {
            //RichTexBox.Text += "Reçu : " + textBoxEmission.Text;
            serialPort1.WriteLine(textBoxEmission.Text);
            textBoxEmission.Text = "";
            
        }
    }
}