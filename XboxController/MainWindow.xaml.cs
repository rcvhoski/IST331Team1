using System;
using System.Collections.Generic;
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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Windows.Threading;

namespace XboxController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer _timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(1) };
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            DisplayControllerInformation();
        }

        void DisplayControllerInformation()
        {
            initalizeController();
            var GPstate = GamePad.GetState(PlayerIndex.One);
            if (GPstate.IsButtonDown(Buttons.A))
            {
                btnA.Fill = new SolidColorBrush(Colors.Green);
                GamePad.SetVibration(PlayerIndex.One, 1f,1f);
            }
            if (GPstate.IsButtonDown(Buttons.B))
                btnB.Fill = new SolidColorBrush(Colors.Red);
            if (GPstate.IsButtonDown(Buttons.X))
                btnX.Fill = new SolidColorBrush(Colors.Blue);
            if (GPstate.IsButtonDown(Buttons.Y))
                btnY.Fill = new SolidColorBrush(Colors.Yellow);
            if (GPstate.IsButtonDown(Buttons.Start))
                btnStart.Fill = new SolidColorBrush(Colors.White);
            if (GPstate.IsButtonDown(Buttons.Back))
                btnBack.Fill = new SolidColorBrush(Colors.White);
            if (GPstate.IsButtonDown(Buttons.RightTrigger))
                rightTrigger.Fill = new SolidColorBrush(Colors.Violet);
            if (GPstate.IsButtonDown(Buttons.LeftTrigger))
                leftTrigger.Fill = new SolidColorBrush(Colors.Violet);
            if (GPstate.IsButtonDown(Buttons.BigButton))
                btnPlayer.Fill = new SolidColorBrush(Colors.Green);
            if (GPstate.IsButtonDown(Buttons.RightShoulder))
                rightBumper.Fill = new SolidColorBrush(Colors.SaddleBrown);
            if (GPstate.IsButtonDown(Buttons.LeftShoulder))
                leftBumper.Fill = new SolidColorBrush(Colors.SaddleBrown);
            if (GPstate.IsButtonDown(Buttons.LeftStick))
                leftThumbstick.Fill = new SolidColorBrush(Colors.SeaGreen);
            if (GPstate.IsButtonDown(Buttons.LeftThumbstickDown))
                leftThumbstick.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            if (GPstate.IsButtonDown(Buttons.LeftThumbstickUp))
                leftThumbstick.Fill = new SolidColorBrush(Colors.BlueViolet);
            if (GPstate.IsButtonDown(Buttons.LeftThumbstickRight))
                leftThumbstick.Fill = new SolidColorBrush(Colors.Chocolate);
            if (GPstate.IsButtonDown(Buttons.LeftThumbstickLeft))
                leftThumbstick.Fill = new SolidColorBrush(Colors.BurlyWood);
            if (GPstate.IsButtonDown(Buttons.RightStick))
                rightThumbstick.Fill = new SolidColorBrush(Colors.SeaGreen);
            if (GPstate.IsButtonDown(Buttons.RightThumbstickDown))
                rightThumbstick.Fill = new SolidColorBrush(Colors.BlanchedAlmond);
            if (GPstate.IsButtonDown(Buttons.RightThumbstickUp))
                rightThumbstick.Fill = new SolidColorBrush(Colors.BlueViolet);
            if (GPstate.IsButtonDown(Buttons.RightThumbstickRight))
                rightThumbstick.Fill = new SolidColorBrush(Colors.Chocolate);
            if (GPstate.IsButtonDown(Buttons.RightThumbstickLeft))
                rightThumbstick.Fill = new SolidColorBrush(Colors.BurlyWood);
            if (GPstate.IsButtonDown(Buttons.DPadDown))
                DPad.Fill = new SolidColorBrush(Colors.RoyalBlue);
            if (GPstate.IsButtonDown(Buttons.DPadLeft))
                DPad.Fill = new SolidColorBrush(Colors.AliceBlue);
            if (GPstate.IsButtonDown(Buttons.DPadUp))
                DPad.Fill = new SolidColorBrush(Colors.Aquamarine);
            if (GPstate.IsButtonDown(Buttons.DPadRight))
                DPad.Fill = new SolidColorBrush(Colors.Azure);
 
        }

        private void initalizeController()
        {
            Brush defaultColor = new SolidColorBrush(Colors.LightGray);
            btnBack.Fill = defaultColor;
            btnStart.Fill = defaultColor;
            btnA.Fill = defaultColor;
            btnB.Fill = defaultColor;
            btnY.Fill = defaultColor;
            btnX.Fill = defaultColor;
            btnPlayer.Fill = defaultColor;
            leftThumbstick.Fill = defaultColor;
            leftTrigger.Fill = defaultColor;
            leftBumper.Fill = defaultColor;
            rightThumbstick.Fill = defaultColor;
            rightTrigger.Fill = defaultColor;
            rightBumper.Fill = defaultColor;
            DPad.Fill = defaultColor;
            GamePad.SetVibration(PlayerIndex.One, 0, 0);
        }

    }
}
