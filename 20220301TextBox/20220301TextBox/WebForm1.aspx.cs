using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _20220301TextBox
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断回发
            //if (!IsPostBack)
            //{

            //}
        }

        protected void tbx_TextChanged(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            double x = Convert.ToDouble(tbx.Text.Trim());
            double rate = 0;
            switch (tbx.ID.Substring(4))
            {
                case "yd": rate = 0.9144; break;
                case "ft": rate = 0.3048; break;
                case "in": rate = 0.0254; break;
                case "m": rate = 1; break;
                case "cm": rate = 0.01; break;
                case "um": rate = 0.0000001; break;
            }
            double meter = x * rate;
            this.tbx_yd.Text = (meter / 0.9144).ToString();
            this.tbx_ft.Text = (meter / 0.3048).ToString();
            this.tbx_in.Text = (meter / 0.0254).ToString();
            this.tbx_m.Text = (meter / 1).ToString();
            this.tbx_cm.Text = (meter / 0.01).ToString();
            this.tbx_um.Text = (meter / 0.0000001).ToString();
        }
    }
}