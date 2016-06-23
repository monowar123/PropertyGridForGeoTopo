using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PropertyGridForGeoTopo
{
    public class Settings
    {
        private string identificatie;
        private string regDate;
        private string endRegistratioinDate;
        private string createDate;
        private string lastEditedDate;

        private static Settings obj;

        private const string fileName = "optionalSettings.xml";

        private Settings() { }
        private Settings(string _identificatie, string _regDate, string _endRegistratioinDate, string _createDate, string _lastEditedDate)
        {
            identificatie = _identificatie;
            regDate = _regDate;
            endRegistratioinDate = _endRegistratioinDate;
            createDate = _createDate;
            lastEditedDate = _lastEditedDate;
        }

        //~Settings()
        //{
        //    Save();
        //}

        public static void Dispose()
        {
            obj = null;
            GC.Collect();
        }

        public static Settings GetInstance()
        {
            if (obj == null)
                ReadXML();
                
            return obj;
        }

        [DisplayName("Create Identificatie")]
        [Description("Identificatie is created or not")]
        [Category("Settings")]
        [TypeConverter(typeof(SettingsConverter))]
        public string Identificatie
        {
            get { return identificatie; }
            set { identificatie = value; }
        }

        [DisplayName("Create Registration Date")]
        [Description("Registration Date is created or not")]
        [Category("Settings")]
        [TypeConverter(typeof(SettingsConverter))]
        public string RegDate
        {
            get { return regDate; }
            set { regDate = value; }
        }

        [DisplayName("Create EndRegistratioin Date")]
        [Description("End Registratioin Date is created or not")]
        [Category("Settings")]
        [TypeConverter(typeof(SettingsConverter))]
        public string EndRegistratioinDate
        {
            get { return endRegistratioinDate; }
            set { endRegistratioinDate = value; }
        }

        [DisplayName("Created Date")]
        [Description("Create Date is created or not")]
        [Category("Settings")]
        [TypeConverter(typeof(SettingsConverter))]
        public string CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        [DisplayName("Create Last Edited Date")]
        [Description("Last Edited Date is created or not")]
        [Category("Settings")]
        [TypeConverter(typeof(SettingsConverter))]
        public string LastEditedDate
        {
            get { return lastEditedDate; }
            set { lastEditedDate = value; }
        }

        private static void ReadXML()
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(appPath, fileName);
            FileStream fileStream = null;
            try
            {
                if (File.Exists(filePath))
                {
                    fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    XmlSerializer reader = new XmlSerializer(typeof(Settings));                  
                    obj = (Settings)reader.Deserialize(fileStream);
                }
                else
                {
                    obj = new Settings("Yes", "Yes", "Yes", "Yes", "Yes");
                    fileStream = File.Create(filePath);

                    XmlSerializer writer = new XmlSerializer(typeof(Settings));
                    writer.Serialize(fileStream, obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }

        public static void Save()
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = Path.Combine(appPath, fileName);
            StreamWriter streamWriter = null;
            try
            {
                if (File.Exists(filePath))
                {
                    streamWriter = new StreamWriter(filePath);
                }
                else
                {
                    File.Create(filePath);
                    streamWriter = new StreamWriter(filePath);
                }

                XmlSerializer writer = new XmlSerializer(typeof(Settings));
                writer.Serialize(streamWriter, obj);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                streamWriter.Close();
            }
        }

        public static void SetAllTrue()
        {
            obj.Identificatie = "Yes";
            obj.RegDate = "Yes";
            obj.EndRegistratioinDate = "Yes";
            obj.CreateDate = "Yes";
            obj.LastEditedDate = "Yes";
        }

        public static void SetAllFalse()
        {
            obj.Identificatie = "No";
            obj.RegDate = "No";
            obj.EndRegistratioinDate = "No";
            obj.CreateDate = "No";
            obj.LastEditedDate = "No";
        }
    }
}
