using System;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace PixGang
{
    class ConfigFunctions
    {
        public static void SaveTriggerbotConfig(int xOffset, int yOffset, int theDelay, string fileName)
        {
            using (StreamWriter file = File.CreateText(AppContext.BaseDirectory + @"\Configs\" + fileName + ".json"))
            {
                TriggerbotConfig trig = new TriggerbotConfig
                {
                    x = xOffset,
                    y = yOffset,
                    delay = theDelay
                };

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, trig);

                MessageBox.Show("Created Config Successfully!");
            }
        }

        public static void SaveRecoilConfig(int xAxis, int yAxis, int theStrength, int theSpeed, bool adsCheck, string fileName)
        {
            using (StreamWriter file = File.CreateText(AppContext.BaseDirectory + @"\Configs\" + fileName + ".json"))
            {
                RecoilConfig recoil = new RecoilConfig
                {
                    x = xAxis,
                    y = yAxis,
                    strength = theStrength,
                    speed = theSpeed,
                    ads = adsCheck
                };

                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, recoil);

                MessageBox.Show("Created Config Successfully!");
            }
        }
    }

    public class RecoilConfig
    {
        public int x { get; set; }
        public int y { get; set; }
        public int strength { get; set; }
        public int speed { get; set; }
        public bool ads { get; set; }
    }

    public class TriggerbotConfig
    {
        public int x { get; set; }
        public int y { get; set; }
        public int delay { get; set; }
    }
}
