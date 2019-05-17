﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnonsTjanst.Controllers
{
    public class HomeController : Controller
    {
        

        public ActionResult Index(int? idin)
        {
            if (idin == null)
            {
                try
                {
                    int id = 11;
                    loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
                    if (Session["profilId"] != null)
                    {
                        //Converting your session variable value to integer
                        id = ((int)Session["profilId"]);//ut komenterad kod pga problem med sekson   Convert.ToInt32(id1.Text);
                        var anvendare = logclient.VisaAnvandarInfoId(id);
                        ViewBag.medalande = anvendare.Anvandarnamn;
                    }
                    else
                    {
                        var hej = "hejsan";
                        Console.Beep();
                        Console.BackgroundColor = System.ConsoleColor.Black;
                        Console.CursorSize = 200;
                    }

                }
                catch
                {

                }
            }
            else
            {
                int id = int.Parse(idin.ToString());
                loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
                if (logclient.VerifieraInloggning(id))
                {
                    Session["profilId"] = id;
                    var anvendare = logclient.VisaAnvandarInfoId(id);
                    string test = anvendare.Anvandarnamn;

                }
            }
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            return View(client.HamtaAllaAnnonser());
        }

        public ActionResult logain()
        {
            loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
            var test = logclient.VerifieraInloggning(1337);

            return View();
        }
        [HttpPost]
        public ActionResult logain(string anvandarnamn, string losenord, string behorrighet)
        {
            if (behorrighet == null)
            {
                behorrighet = "standard";
            }
            loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
            var anvinfo = logclient.LoggaIn(anvandarnamn, losenord, behorrighet);
            if (anvinfo != null)
            {

                Session["profilId"] = anvinfo.ProfilId.ToString(); //) ["profilId"] = Convert.ToInt32(anvinfo.ProfilId.ToString());
                Session["inlogad"] = "true";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}