using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ProductType
{
    public class cMain
    {
        public static string strConnect;
        public static string user;
        public static string OfficeSpaceId;

        public bool New(string istrConnect, string iuser, string iOfficeSpaceId)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;
            
            ProductType.Form1 formProductType = new Form1();
            formProductType.ShowDialog();

/*            formProductType.Command = "New";

            formProductType.funLoad();

            if (formProductType.ShowDialog() == DialogResult.OK)
            {
                if (!formProductType.IsDisposed)
                {
                    formProductType.Close();
                    formProductType.Dispose();
                }
                return false;
            }
            if (!formProductType.IsDisposed)
            {
                formProductType.Close();
                formProductType.Dispose();
            }
            */
            return false;
        }

        public bool Edit(string istrConnect, string iuser, string iOfficeSpaceId, System.Data.DataTable dt, int currentIndex)
        {
            strConnect = istrConnect;
            user = iuser;
            OfficeSpaceId = iOfficeSpaceId;
/*
            Form1 form = new Form1();
            form.Command = "Edit";
            form.ID_TEMP = dt.Rows[currentIndex]["ID"].ToString();

            form.funLoad();

            if (form.ShowDialog() == DialogResult.OK)
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
                return false;
            }
            if (!form.IsDisposed)
            {
                form.Close();
                form.Dispose();
            }
  */
            return false;
        }

    }
}
