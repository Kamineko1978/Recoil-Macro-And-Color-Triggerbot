using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace PixGang
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(Keys vKey);

        Color oldColor;
        Color newColor;

        static int xVal;
        static int yVal;
        static int triggerbotDelay;

        bool triggerbot = false;

        bool recoilMacro = false;
        bool isAds = false;

        static int strengthVal;
        static int speedVal;
        static int xAxisVal;
        static int yAxisVal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            triggerDelayLabel.Text = triggerDelay.Value.ToString();
            triggerbotDelay = triggerDelay.Value;

            Thread thread = new Thread(toggle) { IsBackground = true };
            thread.Start();
        }

        void toggle()
        {
            while (true)
            {
                if (triggerbot == true)
                {
                    Point pixel = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + xVal, Screen.PrimaryScreen.Bounds.Height / 2 + yVal);

                    if (GetAsyncKeyState(Keys.XButton1) < 0)
                    {
                        Thread.Sleep(1);
                        oldColor = Functions.grabPixelData(pixel);
                        Thread.Sleep(1);
                        newColor = Functions.grabPixelData(pixel);

                        if (oldColor == newColor)
                        {
                            //same color
                        }
                        else
                        {
                            Functions.LeftDown();
                            Thread.Sleep(1);
                            Functions.LeftUp();

                            newColor = Color.FromArgb(0, 0, 0, 0);
                            oldColor = Color.FromArgb(0, 0, 0, 0);
                            Thread.Sleep(triggerbotDelay);
                        }
                    }
                }

                if (recoilMacro == true && isAds == true)
                {
                    if (GetAsyncKeyState(Keys.LButton) < 0)
                    {
                        if (GetAsyncKeyState(Keys.RButton) < 0)
                        {
                            while (GetAsyncKeyState(Keys.RButton) < 0)
                            {
                                for (int i = 0; i < strengthVal; i++)
                                {
                                    Functions.MouseMove(xAxisVal, yAxisVal);
                                    Thread.Sleep(speedVal);
                                }

                            }
                        }
                    }       
                }

                    if(recoilMacro == true && isAds == false)
                    {
                        if (GetAsyncKeyState(Keys.LButton) < 0)
                        {
                            while (GetAsyncKeyState(Keys.LButton) < 0)
                            {
                                for (int i = 0; i < strengthVal; i++)
                                {
                                    Functions.MouseMove(xAxisVal, yAxisVal);
                                    Thread.Sleep(speedVal);
                                }
                            }
                        }
                    }
            }
        }



        //BUTTON FUNCTIONS AND SHIT BELOW

        private void xTriggerTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            xValueLabel.Text = xTriggerTrackBar.Value.ToString();
            xVal = xTriggerTrackBar.Value;
        }

        private void yTriggerTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            yValueLabel.Text = yTriggerTrackBar.Value.ToString();
            yVal = yTriggerTrackBar.Value;
        }

        private void toggleTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleTrigger.Checked == true)
            {
                triggerbot = true;

            }
            else
            {
                triggerbot = false;
            }
        }

        private void topMost_CheckedChanged(object sender, EventArgs e)
        {
            if(topMost.Checked == true)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void triggerDelay_Scroll(object sender, ScrollEventArgs e)
        {
            triggerDelayLabel.Text = triggerDelay.Value.ToString();
            triggerbotDelay = triggerDelay.Value;
        }

        private void toggleRecoil_CheckedChanged(object sender, EventArgs e)
        {
            if(toggleRecoil.Checked == true)
            {
                recoilMacro = true;
            }
            else
            {
                recoilMacro = false;
            }
        }

        private void adsToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(adsToggle.Checked == true)
            {
                isAds = true;
            }
            else
            {
                isAds = false;
            }
        }

        private void strength_Scroll(object sender, ScrollEventArgs e)
        {
            strengthLabel.Text = strength.Value.ToString();
            strengthVal = strength.Value;
        }

        private void speed_Scroll(object sender, ScrollEventArgs e)
        {
            speedLabel.Text = speed.Value.ToString();
            speedVal = speed.Value;
        }

        private void xAxis_Scroll(object sender, ScrollEventArgs e)
        {
            xAxisLabel.Text = xAxis.Value.ToString();
            xAxisVal = xAxis.Value;
        }

        private void yAxis_Scroll(object sender, ScrollEventArgs e)
        {
            yAxisLabel.Text = yAxis.Value.ToString();
            yAxisVal = yAxis.Value;
        }

        private void saveTriggerbotConfig_Click(object sender, EventArgs e)
        {
            ConfigFunctions.SaveTriggerbotConfig(xVal, yVal, triggerbotDelay, triggerbotConfigName.Text);
        }

        private void loadTriggerbotConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = AppContext.BaseDirectory + @"\Configs\";
            openFileDialog1.Filter = "Json files (*.json)|*.json";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                using (StreamReader file = File.OpenText(selectedFileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    TriggerbotConfig trigFile = (TriggerbotConfig)serializer.Deserialize(file, typeof(TriggerbotConfig));

                    xVal = trigFile.x;
                    xTriggerTrackBar.Value = trigFile.x;
                    xValueLabel.Text = xVal.ToString();

                    yVal = trigFile.y;
                    yTriggerTrackBar.Value = trigFile.y;
                    yValueLabel.Text = yVal.ToString();

                    triggerbotDelay = trigFile.delay;
                    triggerDelay.Value = trigFile.delay;
                    triggerDelayLabel.Text = triggerbotDelay.ToString();

                }
            }
        }

        private void saveRecoilConfig_Click(object sender, EventArgs e)
        {
            ConfigFunctions.SaveRecoilConfig(xAxisVal, yAxisVal, strengthVal, speedVal, isAds, recoilConfigName.Text);
        }

        private void loadRecoilConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = AppContext.BaseDirectory + @"\Configs\";
            openFileDialog1.Filter = "Json files (*.json)|*.json";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                using (StreamReader file = File.OpenText(selectedFileName))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    RecoilConfig recoilFile = (RecoilConfig)serializer.Deserialize(file, typeof(RecoilConfig));

                    xAxisVal = recoilFile.x;
                    xAxis.Value = recoilFile.x;
                    xAxisLabel.Text = xAxisVal.ToString();

                    yAxisVal = recoilFile.y;
                    yAxis.Value = recoilFile.x;
                    yAxisLabel.Text = yAxisVal.ToString();

                    strengthVal = recoilFile.strength;
                    strength.Value = recoilFile.strength;
                    strengthLabel.Text = strengthVal.ToString();

                    speedVal = recoilFile.speed;
                    speed.Value = recoilFile.speed;
                    speedLabel.Text = speedVal.ToString();

                    isAds = recoilFile.ads;
                    if(recoilFile.ads == true)
                    {
                        adsToggle.Checked = true;
                    }
                    else
                    {
                        adsToggle.Checked = false;
                    }

                }
            }
        }
    }
}
