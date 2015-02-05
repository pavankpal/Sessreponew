using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class LoginPage : System.Web.UI.Page
{
    SqlConnection con=new SqlConnection(ConfigurationManager.ConnectionStrings["mycon"].ConnectionString);
    SqlDataReader rd=null;
    SqlCommand cmd;
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        { 
        
        }
    }
    protected void btnlog_Click(object sender, EventArgs e)
    {
        try
        {

            int flag = 0;
            string id = txtid.Text;
            string pwd = txtpwd.Text;
            string str = "select * from logint";
            SqlCommand cmd = new SqlCommand(str, con);
            con.Open();
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd.HasRows)
                {
                    if (id.Equals(rd[0]) && pwd.Equals(rd[1]))
                    {
                        Session["ID"] = Session.SessionID;
                        Session["User"] = id;
                        if (rd[2].Equals("a"))
                        {

                            flag++;
                            Session["ID"] = Session.SessionID;
                            Session["User"] = id;
                            Response.Redirect("Adminhome.aspx");
                        }
                        else if (rd[2].Equals("f"))
                        {
                            flag++;
                            Response.Redirect("FacultyHome.aspx");
                        }
                        else
                        {
                            flag++;
                            Response.Redirect("StudentHome.aspx");
                        }
                    }
                }

            }
            if (flag == 0)
            {
                Label3.Text = "Invalid Id or Password";
            }

        }
        catch (SqlException ex)
        {
            Label3.Text = "contact to Site Administrator";
        }
        finally
        {
            if (rd != null)
            {
                rd.Close();
            }
            con.Close();
        }
    }
}