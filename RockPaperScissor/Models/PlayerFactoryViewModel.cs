using System;
using System.Xml.Serialization;
using System.IO;

namespace RockPaperScissor.Models
{
    public class PlayerFactoryViewModel
    {
        public static void SaveData(PlayerViewModel pv)
        {

            var path = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\" + "PlayerData\\" + "playerdetails.txt";
    
            XmlSerializer writer = new XmlSerializer(typeof(PlayerViewModel));
            FileStream file = File.Create(path);
            writer.Serialize(file, pv);
            file.Close();

        }
    }
}