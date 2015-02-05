﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FacultyHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["ID"] != null)
            {
                Label1.Text = Session["User"].ToString();
            }

            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }
    }
}