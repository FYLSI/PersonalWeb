using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWeb.Controllers.Article
{
    public class ArticleController : Controller
    {
        // GET: Article

        /// <summary>
        /// 文章列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            return View();
        }

        /// <summary>
        /// 文章详情页
        /// </summary>
        /// <returns></returns>
        public ActionResult Detail()
        {
            return View();
        }
    }
}