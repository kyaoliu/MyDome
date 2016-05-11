using Repository;
using Repository.Filter.PageTokenView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc
{
    public static class MyHtmlHelper
    {
        public static HtmlString GenerateVerficationToken(this HtmlHelper htmlhelper)
        {
            string formValue = Utility.Encrypt(HttpContext.Current.Session.SessionID + DateTime.Now.Ticks.ToString());
            HttpContext.Current.Session[PageTokenViewBase.SessionMyToken] = formValue;

            string fieldName = PageTokenViewBase.HiddenTokenName;
            TagBuilder builder = new TagBuilder("input");
            builder.Attributes["type"] = "hidden";
            builder.Attributes["name"] = fieldName;
            builder.Attributes["value"] = formValue;
            return new HtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}
