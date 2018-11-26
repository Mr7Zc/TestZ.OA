using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestZ.OA.BLL;
using TestZ.OA.IBLL;
using TestZ.OA.Model;

namespace TestZ.OA.UI.Portal.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        UserInfoService userInfoService = new UserInfoService();//sprint.net
        public ActionResult Index()
        {
            ViewData.Model = userInfoService.GetEntities(u => true);
            return View();
        }

        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                userInfoService.Add(userInfo);
            }
            return RedirectToAction("Index");
        }
    }
}