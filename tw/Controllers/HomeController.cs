using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Presence()
        {
            return View();

        }
        public ActionResult Team()
        {
            return View();

        }
        public ActionResult Lims() //实验室LIMS软件系统
        {
            return View();
        }
        public ActionResult SupplyChain() //供应链质量管理
        {
            return View();
        }

        public ActionResult Standard() //技术标准服务
        {
            return View();
        }

        public ActionResult DataAnalysis() //第三方数据分析服务
        {
            return View();
        }

        public ActionResult Solution() //解决方案
        {
            return View();
        }
        //public ActionResult dynamic() {    //业界动态
        //    return View();
        //}

        public ActionResult Family() {    //加入我们
            return View();
        }
    }
}