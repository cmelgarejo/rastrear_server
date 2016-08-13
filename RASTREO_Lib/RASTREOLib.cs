using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
namespace RASTREO_Lib
{
    //public class cnn_str
    //{
    //    public static string CadenaDeConexion
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if (System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if (XL.Count > 0)
    //                return XL.Item(0).InnerText;
    //            return "Server=127.0.0.1;Port=6543;User Id=rastreo_admin;Password=rastreoadmin1341;Database=rastreo_system;CommandTimeout=100;timeout=100;MaxPoolSize=1024;";
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //    public static string MailServer
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if(System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if(XL.Count > 0)
    //                return XL.Item(1).InnerText;
    //            return "mail.rastreo.com.py";
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //    public static int MailPort
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if(System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if(XL.Count > 0)
    //                return int.Parse(XL.Item(2).InnerText);
    //            return 587;
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //    public static string MailUser
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if(System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if(XL.Count > 0)
    //                return XL.Item(3).InnerText;
    //            return "info@rastreo.com.py";
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //    public static string MailPassword
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if(System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if(XL.Count > 0)
    //                return XL.Item(4).InnerText;
    //            return "inforastreo";
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //    public static string MailFrom
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if(System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if(XL.Count > 0)
    //                return XL.Item(5).InnerText;
    //            return "info@rastreo.com.py";
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //    public static bool MailSSL
    //    {
    //        get
    //        {
    //            string sTargetDir = AppDomain.CurrentDomain.BaseDirectory;
    //            XmlDocument myXML = new XmlDocument();
    //            //if (System.IO.File.Exists(sTargetDir + "RASTREO_Server.exe.config"))
    //            //    sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREO_Server.exe.config";
    //            if(System.IO.File.Exists(sTargetDir + "RASTREOmw.config"))
    //                sTargetDir = AppDomain.CurrentDomain.BaseDirectory + "RASTREOmw.config";
    //            //else if (!System.IO.File.Exists(sTargetDir))
    //            //    return RASTREOmw.Properties.Settings.Default["DefaultCNNSTR"].ToString();
    //            myXML.Load(sTargetDir);
    //            XmlNodeList XL = myXML.SelectNodes("configuration/userSettings/RASTREOmw.Properties.Settings/setting");
    //            if(XL.Count > 0)
    //                return (XL.Item(6).InnerText == "true") ? true : false;
    //            return false;
    //            //return RASTREOmw.Properties.Settings.Default["RS_ServerCNNSTR"].ToString();
    //        }
    //    }
    //}
}
