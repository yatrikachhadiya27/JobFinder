using Microsoft.AspNetCore.Mvc;
using JobFinder.Data;
using JobFinder.Models;

namespace JobFinder.Controllers
{
    public class JobController : Controller
    {
        private dbcontext s2;

        public JobController(dbcontext dbcontext)
        {
            s2 = dbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Companies()
        {
            return View();
        }
        public IActionResult CompanyEditProfile()
        {
            return View();
        }
        public IActionResult CompanyLoginViewPage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CompanyLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CompanyLogin(CompanyModel abc)
        {
            var user = s2.Companys.FirstOrDefault(u => u.CompanyEmail == abc.CompanyEmail && u.CompanyPassword == abc.CompanyPassword);
            if (user != null)
            {
                return RedirectToAction("CompanyLoginViewPage");
            }
            else
            {
                ViewBag.Message = "Login Failed !!!";
            }
            return View(abc);
        }
        public IActionResult CompanyProfileAndLogout()
        {
            return View();
        }
        public IActionResult CompanyProfilePage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CompanySignup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CompanySignup(CompanyModel abc)
        {
            s2.Companys.Add(abc);
            s2.SaveChanges();
            return RedirectToAction("CompanyLogin");
        }
        public IActionResult CompanyUploadJobs()
        {
            return View();
        }
        public IActionResult JobDetails2()
        {
            return View();
        }
        public IActionResult JobDetails()
        {
            return View();
        }
        public IActionResult JobPorter()
        {
            return View();
        }
        public IActionResult UploadJob()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserLogin(UserModel abc)
        {
            var user = s2.Users.FirstOrDefault(u => u.UserEmail == abc.UserEmail && u.UserPassword == abc.UserPassword);
            if (user != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Message = "Login Failed !!!";
            }
            return View(abc);
        }
        [HttpGet]
        public IActionResult UserSignup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UserSignup(UserModel abc)
        {
            s2.Users.Add(abc);
            s2.SaveChanges();
            return RedirectToAction("UserLogin");
        }
    }
}