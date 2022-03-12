using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _20220302FileUpLoad
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //项目的当前路径
            this.Label1.Text = "1：" + Server.MapPath("~/");
            //网页的当前路径，路径中一定带有 admin 目录
            this.Label2.Text = "2：" + Server.MapPath("./");
            //找到 admin 的父亲节点，与 ~/ 一样
            this.Label3.Text = "3：" + Server.MapPath("../");

        }
    }
}