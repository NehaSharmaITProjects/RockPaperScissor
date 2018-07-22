using System;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace RockPaperScissor.Models
{
    public class PlayerFactoryViewModel
    {
        public static void SaveData(PlayerViewModel pv)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "App_Data\\" + "PlayerData\\" + "playerdetails.txt";
            XmlSerializer writer = new XmlSerializer(typeof(PlayerViewModel));

            FileStream file = null;
            try
            {
                file = File.Create(path);
                writer.Serialize(file, pv);            
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally {
                file.Close();
            }
        }
    }
}