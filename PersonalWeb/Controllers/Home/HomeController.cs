using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 主框架
        /// </summary>
        /// <returns></returns>
        public ActionResult Main()
        {
            return View();
        }

        /// <summary>
        /// 右侧容器
        /// </summary>
        /// <returns></returns>
        public ActionResult RightContainer()
        {
            return View();
        }
    }
}