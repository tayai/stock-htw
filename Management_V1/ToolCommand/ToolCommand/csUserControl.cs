using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ToolCommand
{
    public class csUserControl
    {

        public string OfficeSpaceId;
        public string ID_TEMP;
        public string UserName;
       

        public ucForm getPanel(string strConnect, string user, string Position, string Command)
        {
            ucForm pa = new ucForm();
            switch (Command)
            {
                //case "TESTES":
                //    Label labTemp = new Label();
                //    labTemp.Text = "text";
                //    pa._Header = "ระบบลงเวลา";
                //    Timecard.tmcMain.UserName = UserName;
                //    Timecard.tm_control test = new Timecard.tm_control();
                    
                //    test.users = user;
                    
                //    test.Connection = strConnect;
                //    test.iOfficeSpaceId = OfficeSpaceId;
                //    test.Dock = DockStyle.Fill;
                //    test.funLoad();
                    
                //    pa._MainPanel.Controls.Add(test);
                   
                //    break;

                
            }

            return pa;
        }
    }
}
