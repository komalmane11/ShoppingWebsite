using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopingWebsite
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
			ObjectDataSource1.UpdateParameters["ID"].DefaultValue = TextBox2.Text;
			ObjectDataSource1.UpdateParameters["Brand_Name"].DefaultValue = DropDownList1.Text;
			ObjectDataSource1.UpdateParameters["Quantity"].DefaultValue = TextBox1.Text;
			ObjectDataSource1.Update();
		}
    }
}