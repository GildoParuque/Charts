using Charts.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Controllers
{
    public class ChartController : Controller
    {
        private MyContext _context;

        public ChartController(MyContext context)
        {
           this._context = context;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Data()
        {
            var result = _context.SalesOrders
                        .GroupBy(x => new { group = x.zone })
                        .Select(group => new { 
                            zone = group.Key.group,
                            count = group.Count()
                        }).OrderByDescending(o => o.count).ToList();
       
            var labels = result.Select(x => x.zone).ToArray();
            var values = result.Select(x => x.count).ToArray();

            var max = values[0];
            List<object> list = new List<object>();
            list.Add(labels);
            list.Add(values);
            list.Add(max);

            return Json(list);
        }
    }
}
