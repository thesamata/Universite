using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Proje_SCB
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["idver"]);
            SqlConnection Connect =
                new SqlConnection(ConfigurationManager
                        .ConnectionStrings["ConnectionStringSCB"]
                        .ConnectionString);
            Connect.Open();
            string deleteQuery = "DELETE FROM Basvuru WHERE id=" + gelenid;
            SqlCommand Commend = new SqlCommand(deleteQuery, Connect);
            Commend.ExecuteNonQuery();
            Connect.Close();
            Response.Redirect("InsanKaynaklari.aspx");
        }
    }
}
/*     \   /\
       )  ( ')
      (  /  )
SCB    \(__)|
*/
