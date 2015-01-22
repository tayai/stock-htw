﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Users
{
    public class cMain
    {
        public static string Connection;
        public static string UserName;
        public static string OfficeSpaceId;
        public static string DatabaseName = "document";
        public bool newPosition(string iConnection, string iUserName, string iOfficeSpaceId, string Database)
        {
            Connection = iConnection;
            UserName = iUserName;
            OfficeSpaceId = iOfficeSpaceId;
            DatabaseName = Database;
            frmPosition frm = new frmPosition();
            frm.Command = "New";
            bool bOutput = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bOutput = true;
            }
            if (!frm.IsDisposed)
            {
                frm.Close();
                frm.Dispose();
            }
            return bOutput;
        }
        public bool editPosition(string iConnection, string iUserName, string iOfficeSpaceId, DataTable dt, int currentIndex, string Database)
        {
            Connection = iConnection;
            UserName = iUserName;
            OfficeSpaceId = iOfficeSpaceId;
            DatabaseName = Database;
            if (dt.Rows.Count == 0) return false;

            string PARENT_CODE = dt.Rows[currentIndex]["PARENT_CODE"].ToString();

            frmPosition frm = new frmPosition();
            frm.Command = "Edit";
            frm.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            if (PARENT_CODE != "")
            {
                ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.UserName);
                NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
                NCS.Add(new NextwaverDB.NColumn("POSITION_NAME"));
                NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
                NWS.Add(new NextwaverDB.NWhere("POSITION_CODE", PARENT_CODE));

                DataTable dtTemp = cConn.Retreive(cMain.Connection, cMain.OfficeSpaceId, cMain.DatabaseName, "position", NCS, NWS);
                frm._PARENT_CODE = PARENT_CODE;
                frm._PARENT_NAME = dtTemp.Rows[0][0].ToString();
            }
            frm._POSITION_CODE = dt.Rows[currentIndex]["POSITION_CODE"].ToString(); ;
            frm._POSITION_NAME = dt.Rows[currentIndex]["POSITION_NAME"].ToString();
            bool bOutput = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bOutput = true;
            }
            if (!frm.IsDisposed)
            {
                frm.Close();
                frm.Dispose();
            }
            return bOutput;
        }
        public bool newUser(string iConnection, string iUserName, string iOfficeSpaceId, string Database)
        {
            Connection = iConnection;
            UserName = iUserName;
            OfficeSpaceId = iOfficeSpaceId;
            DatabaseName = Database;
            frmUser frm = new frmUser();
            frm.Command = "New";
            bool bOutput = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bOutput = true;
            }
            if (!frm.IsDisposed)
            {
                frm.Close();
                frm.Dispose();
            }
            return bOutput;
        }
        public bool editUser(string iConnection, string iUserName, string iOfficeSpaceId, DataTable dt, int currentIndex, string Database)
        {
            Connection = iConnection;
            UserName = iUserName;
            OfficeSpaceId = iOfficeSpaceId;
            DatabaseName = Database;
            if (dt.Rows.Count == 0) return false;

            string POSITION_CODE = dt.Rows[currentIndex]["POSITION_CODE"].ToString();
            

            frmUser frm = new frmUser();
            frm.Command = "Edit";
            frm.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();
            frm._Title = dt.Rows[currentIndex]["TITLE"].ToString();
            frm._FIRSTNAME = dt.Rows[currentIndex]["FIRSTNAME"].ToString();
            frm._LASTNAME = dt.Rows[currentIndex]["LASTNAME"].ToString();
            frm._Password = dt.Rows[currentIndex]["PASSWORD"].ToString();
            frm._USERNAME = dt.Rows[currentIndex]["USERNAME"].ToString();

            ConnectServer.cConection cConn = new ConnectServer.cConection(cMain.UserName);
            NextwaverDB.NColumns NCS = new NextwaverDB.NColumns();
            NCS.Add(new NextwaverDB.NColumn("POSITION_NAME"));
            NextwaverDB.NWheres NWS = new NextwaverDB.NWheres();
            NWS.Add(new NextwaverDB.NWhere("POSITION_CODE", POSITION_CODE));

            DataTable dtTemp = cConn.Retreive(cMain.Connection, cMain.OfficeSpaceId, cMain.DatabaseName, "position", NCS, NWS);
            frm._POSITION_CODE = POSITION_CODE;
            frm._POSITION_NAME = dtTemp.Rows[0][0].ToString();

            bool bOutput = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                bOutput = true;
            }
            if (!frm.IsDisposed)
            {
                frm.Close();
                frm.Dispose();
            }
            return bOutput;
        }
    }
}