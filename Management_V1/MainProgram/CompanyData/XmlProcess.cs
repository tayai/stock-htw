using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace CompanyData
{
    public class XmlProcess
    {
        public static string ErrMsg { get; set; }

        public static bool Transform(XmlDocument xConfig,string ID)
        {
            ConnectServer.cConection cConn = new ConnectServer.cConection("system");

            List<string> Sql_List = new List<string>();

            XmlNode nodeProcess = xConfig.SelectSingleNode("//Process[@ID='" + ID + "']");

            string WSConnectionID = nodeProcess.Attributes["WSConnectionID"].Value;
            string DBConnectionID = nodeProcess.Attributes["DBConnectionID"].Value;

            XmlNode nodeWSConnection = xConfig.SelectSingleNode("//Config/Connection/Item[@ID='" + WSConnectionID + "']");

            string WSConnection = nodeWSConnection.Attributes["Connection"].Value;
            string WSDatabase = nodeWSConnection.Attributes["Database"].Value;
            string OfficeSpaceId = nodeWSConnection.Attributes["OfficeSpaceId"].Value;

            string Sql_Insert = nodeProcess.SelectSingleNode("./Query/Insert").InnerText;
            string Sql_Delete = nodeProcess.SelectSingleNode("./Query/Delete").InnerText;
            string WSTable = nodeProcess.Attributes["WSTable"].Value;

            DataTable dtc = cConn.Retreive(WSConnection, OfficeSpaceId, WSDatabase, WSTable);

            XmlNodeList listColumn = nodeProcess.SelectNodes("./Columns/Column");

            for (int k = 0; k < dtc.Rows.Count; k++)
            {
                string TempInsert = Sql_Insert;
                string TempDelete = Sql_Delete;
                DataRow DR = dtc.Rows[k];
                for (int j = 0; j < listColumn.Count; j++)
                {
                    //<Column Type="STR" Name="ID" Parameter="@ID@" />
                    string TempType = "" + listColumn[j].Attributes["Type"].Value;
                    string TempName = "" + listColumn[j].Attributes["Name"].Value;
                    string TempParameter = "" + listColumn[j].Attributes["Parameter"].Value;
                    string TempValue = "";
                    try
                    {
                        TempValue = "" + DR[TempName];
                    }
                    catch { }
                    TempDelete = TempDelete.Replace(TempParameter, TempValue);
                    switch (TempType)
                    {
                        case "STR":
                            TempInsert = TempInsert.Replace(TempParameter, "" + DR[TempName]);
                            break;
                        case "XML":
                            string strXML = cConn.getLastDoc(WSConnection, OfficeSpaceId, WSDatabase, WSTable, int.Parse("" + DR["ID"]));
                            TempInsert = TempInsert.Replace(TempParameter, strXML);
                            break;
                    }
                }

                Sql_List.Add(TempDelete);
                Sql_List.Add(TempInsert);
            }

            //<Item ID="MSSQL01" Type="MSSQL" Server="localhost" Database="TestProcess" Login="sa" Password="nextwaver" />    
            XmlNode nodeDBConnection = xConfig.SelectSingleNode("//Config/Connection/Item[@ID='" + DBConnectionID + "']");
            string DBServer = nodeDBConnection.Attributes["Server"].Value;
            string DBDatabase = nodeDBConnection.Attributes["Database"].Value;
            string DBLogin = nodeDBConnection.Attributes["Login"].Value;
            string DBPassword = nodeDBConnection.Attributes["Password"].Value;
            string ConnectoinString = "Data Source=" + DBServer + "; uid=" + DBLogin + "; pwd=" + DBPassword + "; Initial Catalog=" + DBDatabase + ";";
            //if (!
            string errno = string.Empty;
            cConn.Execute(Sql_List.ToArray(), ConnectoinString, out errno);
            if (errno != string.Empty)
            {
                ErrMsg = errno;
                return false;
            }

            //nodeProcess.Attributes["UpdateDate"].Value = DateTime.Now.ToString("dd/MM/yyyy hh:mm");

            //xConfig.Save(Application.StartupPath + "/Config_Process.xml");
            //fnLoadConf
            return true;
        }
    }
}
