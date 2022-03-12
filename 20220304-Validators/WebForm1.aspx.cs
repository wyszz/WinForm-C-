using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20220304_Validators
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Response.Write("<script>alert('验证通过')</script>");
            }
        }
       
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (this.tbx_pwd.Text.Trim() != "")
            {
                string x = this.tbx_pwd.Text.Trim();
                //自定义密码长度
                if (x.Length < 6)
                {
                    // args 是一个对象，args.Value 中存放着 tbx_pwd.Text.Trim() 这个值
                    this.CustomValidator1.ErrorMessage = "密码长度不能小于6个字符";
                    args.IsValid = false;
                }
                else if (x.Length > 15)
                {
                    this.CustomValidator1.ErrorMessage = "密码长度不能大于15个字符";
                    args.IsValid = false;
                }
                else
                {
                    args.IsValid = true;
                }
            }
        }
    }
}