using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.ApplicationContext _context;

        public HomeController(Data.ApplicationContext context)
        {
            _context = context;
        }
        //private readonly IHostingEnvironment _hostingEnvironment;

        //public HomeController(IHostingEnvironment hostingEnvironment)
        //{
        //    _hostingEnvironment = hostingEnvironment;
        //}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Login2(string user, string password)
        {

            byte[] result = Encoding.Default.GetBytes(password);    //tbPass为输入密码的文本框  
            MD5 md5 = new MD5CryptoServiceProvider();
            string output = BitConverter.ToString(md5.ComputeHash(result)).Replace("-", "");
            var db_psd = (from a in _context.UserName
                          where a.Name == user
                          select a).FirstOrDefault().Password;
            var b = "原:" + output + ",新:" + db_psd;
            if (output == db_psd)
            {
                b = "原:" + output + ",新:" + db_psd + ",yes!";
            }
            else
            {
                b = "原:" + output + ",新:" + db_psd + ",no!";
            }
            return Content(b);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Upload()
        {

            return View();
        }

        public async Task<IActionResult> Post()
        {


            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
