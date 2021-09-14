using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplicationContd
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ch = DropDownList1.SelectedValue;
            switch (ch)
            {
                case "Personal":
                    MultiView1.SetActiveView(Personal);
                    break;
                case "Educational":
                    MultiView1.SetActiveView(Educational);
                    break;
                case "Upload":
                    MultiView1.SetActiveView(Upload);
                    break;
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname=FileUpload1.FileName;
            if (fname!=null)
            {
                string path =@"C:\Users\deore\Desktop\IBMSept1\ASp.NET WebAppsDemos\FirstWebApplicationContd\UploadedDocuments\";
                FileUpload1.SaveAs(string.Concat(path,fname));
                Response.Write("Uplaoded Successfully...");
            }
        }
    }
}