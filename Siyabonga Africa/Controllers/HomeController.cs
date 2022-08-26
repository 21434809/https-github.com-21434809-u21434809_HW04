using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Siyabonga_Africa.ViewModles;

namespace Siyabonga_Africa.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult HelpingHand()
        {
            return View();
        }
    
        public ActionResult About()
        {
            return View();
        }
    public ActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Users()
        {
            List<User> AllUsersChecklist = new List<User>();

            philanthropist Junior = new philanthropist("Junior", 2727);
            philanthropist Mpho = new philanthropist("Mpho", 2827);
            philanthropist Thato = new philanthropist("Thato", 1027);
            philanthropist Rethabile = new philanthropist("Rethabile", 2827);
            philanthropist Amogelang = new philanthropist("Amogelang", 3727);
            philanthropist Lesedi = new philanthropist("Lesedi", 3327);
            philanthropist Kamogelo = new philanthropist("Kamogelo", 4227);
            philanthropist Lethabo = new philanthropist("Lethabo", 1827);
            philanthropist Tshegofatso = new philanthropist("Tshegofatso", 2527);

            AllUsersChecklist.Add(Junior);
            AllUsersChecklist.Add(Mpho);
            AllUsersChecklist.Add(Thato);
            AllUsersChecklist.Add(Rethabile);
            AllUsersChecklist.Add(Amogelang);
            AllUsersChecklist.Add(Lesedi);
            AllUsersChecklist.Add(Kamogelo);
            AllUsersChecklist.Add(Lethabo);
            AllUsersChecklist.Add(Tshegofatso);

            underprivileged Amahle = new underprivileged("Amahle", 1111);
            underprivileged Jabulani = new underprivileged("Jabulani", 1527);
            underprivileged Kholwa = new underprivileged("Kholwa", 2727);
            underprivileged Lerato = new underprivileged("Lerato", 2127);
            underprivileged Lindiwe = new underprivileged("Lindiwe", 2927);
            underprivileged Luan = new underprivileged("Luan", 1027);
            underprivileged Friedrich = new underprivileged("Friedrich", 4527);
            underprivileged Mpho2 = new underprivileged("Mpho", 2327);
            underprivileged Mieke = new underprivileged("Mieke", 4527);
            underprivileged AmThabisaahle = new underprivileged("Thabisa", 2327);

            AllUsersChecklist.Add(Amahle);
            AllUsersChecklist.Add(Jabulani);
            AllUsersChecklist.Add(Kholwa);
            AllUsersChecklist.Add(Lerato);
            AllUsersChecklist.Add(Lindiwe);
            AllUsersChecklist.Add(Luan);
            AllUsersChecklist.Add(Friedrich);
            AllUsersChecklist.Add(Mpho2);
            AllUsersChecklist.Add(Mieke);
            AllUsersChecklist.Add(AmThabisaahle);

            admin Admin = new admin("Admin", 1234);
            AllUsersChecklist.Add(Admin);

            UserVM UsersVM = new UserVM
            {
                AllUsers = AllUsersChecklist,
            };

            return View("Users", UsersVM);
        }
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        
             public ActionResult Donate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, int PassCode)
        {
            List<User> AllUsersChecklist = new List<User>();
       
        philanthropist Junior = new philanthropist("Junior", 2727);
        philanthropist Mpho = new philanthropist("Mpho", 2827);
        philanthropist Thato = new philanthropist("Thato", 1027);
        philanthropist Rethabile = new philanthropist("Rethabile", 2827);
        philanthropist Amogelang = new philanthropist("Amogelang", 3727);
        philanthropist Lesedi = new philanthropist("Lesedi", 3327);
        philanthropist Kamogelo = new philanthropist("Kamogelo", 4227);
        philanthropist Lethabo = new philanthropist("Lethabo", 1827);
        philanthropist Tshegofatso = new philanthropist("Tshegofatso", 2527);

            AllUsersChecklist.Add(Junior);
            AllUsersChecklist.Add(Mpho);
            AllUsersChecklist.Add(Thato);
            AllUsersChecklist.Add(Rethabile);
            AllUsersChecklist.Add(Amogelang);
            AllUsersChecklist.Add(Lesedi);
            AllUsersChecklist.Add(Kamogelo);
            AllUsersChecklist.Add(Lethabo);
            AllUsersChecklist.Add(Tshegofatso);

            underprivileged Amahle = new underprivileged("Amahle", 1111);
        underprivileged Jabulani = new underprivileged("Jabulani", 1527);
        underprivileged Kholwa = new underprivileged("Kholwa", 2727);
        underprivileged Lerato = new underprivileged("Lerato", 2127);
        underprivileged Lindiwe = new underprivileged("Lindiwe", 2927);
        underprivileged Luan = new underprivileged("Luan", 1027);
        underprivileged Friedrich = new underprivileged("Friedrich", 4527);
        underprivileged Mpho2 = new underprivileged("Mpho", 2327);
        underprivileged Mieke = new underprivileged("Mieke", 4527);
        underprivileged AmThabisaahle = new underprivileged("Thabisa", 2327);

            AllUsersChecklist.Add(Amahle);
            AllUsersChecklist.Add(Jabulani);
            AllUsersChecklist.Add(Kholwa);
            AllUsersChecklist.Add(Lerato);
            AllUsersChecklist.Add(Lindiwe);
            AllUsersChecklist.Add(Luan);
            AllUsersChecklist.Add(Friedrich);
            AllUsersChecklist.Add(Mpho2);
            AllUsersChecklist.Add(Mieke);
            AllUsersChecklist.Add(AmThabisaahle);

            admin Admin = new admin("Admin", 1234);
            AllUsersChecklist.Add(Admin);

            loginVM viewModel = new loginVM
            {
                Username = username,
                Passcode = PassCode,
                AllUsers = AllUsersChecklist,
            };
            
            return View("LogedIN", viewModel);
        }
    }
}
