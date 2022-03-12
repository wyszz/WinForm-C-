using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _20220302FileUpLoad
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
            //判断是否是有效文件,得到一个布尔值
            if (!this.FileUpload1.HasFile)
            {
               //弹窗，alert警告
                Response.Write("<script>alert('请选择JPG或TXT文件！')</script>");
                return;
            }
            //存放提交上传的不带路径的文件名，包括文件扩展名
            string uploadfile = this.FileUpload1.FileName;
            //获取扩展名
            string fileeextn = System.IO.Path.GetExtension(uploadfile);
            //调用系统时间重新以固定模式命名，防止多用户文件重名
            string filename = DateTime.Now.ToString("yyyyMMddhhmmssff") + fileeextn;
            //判断图片格式是否正确
            if (fileeextn.ToLower()==".jpg"||fileeextn.ToLower()==".jpeg")
            {
                // ~ 表示相对路径,定义一个路径，项目的当前路径
                string dcty = "~/Images";
                //获取物理路径，判断路径是否存在
                if (!Directory.Exists(Server.MapPath(dcty)))
                {
                    //如果不存在，创建这个路径
                    Directory.CreateDirectory(Server.MapPath(dcty));
                }
                dcty += "/";
                //保存为绝对路径 
                this.FileUpload1.SaveAs(Server.MapPath(dcty) + filename);
                //将图片的路径赋值为一个确定的路径
                this.Image1.ImageUrl = dcty + filename;
            }
            else if (fileeextn.ToLower()==".txt")
            {
                string dcty = "~/TextFiles";
                //获取物理路径，判断路径是否存在
                if (!Directory.Exists(Server.MapPath(dcty)))
                {
                    //如果不存在，创建这个路径
                    Directory.CreateDirectory(Server.MapPath(dcty));
                }
                dcty += "/";
                //保存为绝对路径 
                this.FileUpload1.SaveAs(Server.MapPath(dcty) + filename);
                //打开文本文件,初始化文件流，文件绝对路径，文件模式:打开，文件访问方式:读
                FileStream fs = new FileStream(Server.MapPath(dcty) + filename, FileMode.Open, FileAccess.Read);
                //文件读取流，以默认编码方式打开 
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
                //给textbox赋值，读取从头到尾
                this.TextBox1.Text = sr.ReadToEnd();
                //关闭读取sr
                sr.Close();
                //关闭读取fs，！！有顺序要求
                fs.Close();
            }
        }
    }
}