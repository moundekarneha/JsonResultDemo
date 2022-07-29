using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JsonResultDemo.Models;

namespace JsonResultDemo.Controllers
{
    public class ProductController : Controller
    {
        List<ProductData> list = new List<ProductData>()
        {
            new ProductData(){Id=101,Name="img1",Price=12M},
            new ProductData(){Id=102,Name="img2",Price=11M},
            new ProductData(){Id=103,Name="img3",Price=10M},
            new ProductData(){Id=104,Name="img4",Price=16M},
        };

        // GET: Product//Json Result
        public JsonResult ProductViewData()
        {
            return Json(list,JsonRequestBehavior.AllowGet);
        }
    }
}