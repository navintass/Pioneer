using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pioneer.Class.CLASS_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Pioneer.Controllers
{
    public class GatewayController : Controller
    {
        // GET: Gateway
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SET_FULL_MODEL()
        {
            var CLS_MODEL = new MODEL_APP();
            return Json(CLS_MODEL, JsonRequestBehavior.AllowGet);
        }
    }
}