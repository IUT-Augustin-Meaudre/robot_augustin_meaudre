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
         Robot robot = new Robot();
        DispatcherTimer timerAffichage;

        byte[] byteList = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int i;


        public MainWindow()
        {
            InitializeComponent();
            

            serialPort1 = new ReliableSerialPort("COM5", 115200, Parity.None, 8, StopBits.One);
            serialPort1.DataReceived += SerialPort1_DataReceived;
            serialPort1.Open();
            timerAffichage = new DispatcherTimer();
            timerAffichage.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timerAffichage.Tick += TimerAffichage_Tick;
            timerAffichage.Start();
       
        }

        private void TimerAffichage_Tick(object sender, EventArgs e)
        {
            //textBoxReception.Text += robot.receivedText;
            while(0<robot.byteListReceived.Count)
            {
                byte byteReceived  = robot.byteListReceived.Dequeue();
                textBoxReception.Text += "0x" + byteReceived.ToString("X2") + " ";
            }
            
            robot.receivedText = "";
        }

        public void SerialPort1_DataReceived(object sender, DataReceivedArgs e)
        { 
            //robot.receivedText += Encoding.UTF8.GetString(e.Data, 0, e.Data.Length);

            for (int i = 0; i < e.Data.Length; i++)
            {
                robot.byteListReceived.Enqueue(e.Data[i]);

            }

            // byte.ToString();
            

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

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxReception.Text = "";
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            byteList[i] = (byte)(2 * i);
            SendMessage();

        }

        private void Grid_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter )
            {
                SendMessage();
            }
            
        }

        private void ButtonHello_Click(object sender, RoutedEventArgs e)
        {
            serialPort1.WriteLine("hello");
            textBoxEmission.Text = "";
        }

        void SendMessage()
        {
            //RichTexBox.Text += "Reçu : " + textBoxEmission.Text;
            serialPort1.WriteLine(textBoxEmission.Text);
            textBoxEmission.Text = "";
            
        }

        
    }
}