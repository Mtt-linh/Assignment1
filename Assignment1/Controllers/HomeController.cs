using Assignment1.Models;
using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
       Acc_DealContext db = new Acc_DealContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Accounts.ToList();
            return View(data);
        }
    }
}