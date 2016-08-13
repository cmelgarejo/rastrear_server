using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace RASTREOmw
{
    public class cnn_str
    {
        public static string CadenaDeConexion
        {
            get
            {
                string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
                XmlDocument myXML = new XmlDocument();
                //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
                //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
                if (System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
                    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
                else if (!System.IO.File.Exists(sTargetDir))
                    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
                myXML.Load(sTargetDir);
                XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
                if (XL.Count > 0)
                    return XL.Item(0).InnerText;
                return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
            }
        }
    }
}