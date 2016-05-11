using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Repository.Filter.PageTokenView
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public sealed class ValidateReHttpPostTokenAttribute : FilterAttribute, IAuthorizationFilter
    {
        public IPageTokenView PageTokenView { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateReHttpPostTokenAttribute"/> class.
        /// </summary>
        public ValidateReHttpPostTokenAttribute()
        {
            //It would be better use DI inject it.
            PageTokenView = new SessionPageTokenView();
        }

        /// <summary>
        /// Called when authorization is required.
        /// </summary>
        /// <param name="filterContext">The filter context.</param>
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }

            if (!PageTokenView.TokensMatch)
            {
                //log...
                throw new Exception("Invaild Http Post!");
            }

        }
    }
}
