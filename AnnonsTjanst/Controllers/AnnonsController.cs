﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnnonsTjanst.Controllers
{
    public class AnnonsController : Controller
    {
        public ActionResult Skapa()
        {
            //Kollar sessionsID || dirigerar om användaren till inloggningssida om denne inte är inloggad
            if (Session["profilId"] != null)
            {
                int tempId = Convert.ToInt32(Session["profilId"]);
                loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
                if (logclient.VerifieraInloggning(tempId))
                {

                }
                else
                {
                    string url = "http://193.10.202.74/Anvandare/Profil/VisaProfil";
                    Response.Redirect(url);

                    return View();
                }
            }
            else
            {
                string url = "http://193.10.202.74/Anvandare/Profil/VisaProfil";
                Response.Redirect(url);

                return View();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Skapa(ServiceReference1.Annonser annons)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
            //Sätter datum till dagens datum
            annons.datum = DateTime.Now;
            annons.betalningsmetod = "NA";
            annons.kategori = Request.Form["Kategorier"].ToString();
            //ändrar status till salu
            annons.status = "Till Salu";
            
            if (Session["profilId"] != null)
            {
                //Gör sessionsID till en temporär int som sedan verifieras genom loginclienten.
                int tempId = Convert.ToInt32(Session["profilId"]);
                if (logclient.VerifieraInloggning(tempId))
                {
                    Session["profilId"] = tempId;
                    //Sätter säljarnamn utifrån inloggningssessionens ID.
                    //Resterande information kommer ifrån "Skapa" vyn eller överst i Controllern
                    annons.saljarID = tempId;
                    string result = client.SkapaAnnons(annons);
                    ViewBag.Message = result;

                    return RedirectToAction("Index", "Home");
                }
                //Är användaren inte inloggad kommer denne att dirigeras om till inloggningssidan.
                else
                {
                    return Redirect("http://193.10.202.74/Anvandare/Profil/VisaProfil");
                }
            }
            else
            {
                return Redirect("http://193.10.202.74/Anvandare/Profil/VisaProfil");
            }
        }

        public ActionResult Detaljer(int id)
        {
            //Kollar sessionsID
            loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
            if (Session["profilId"] != null)
            {
                int tempId = Convert.ToInt32(Session["profilId"]);
                
                if (logclient.VerifieraInloggning(tempId))
                {
                    var anvendare = logclient.VisaAnvandarInfoId(tempId);
                    ViewBag.medalande = anvendare.Anvandarnamn;
                }
            }
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            //Hämtar annons för aktivt ID
            var annons = client.HamtaAnnons(id);
            //Hämtar användarnamn från objekt av Användare. Tar id som inparameter.
            var saljNamn = logclient.VisaAnvandarInfoId(client.HamtaAnnons(id).saljarID).Anvandarnamn;
            //Hittas ingen säljare/köpare sätts värdet i viewbagen till ett medelande som informarar användaren om detta.
            if (saljNamn == null)
            {
                saljNamn = "Säljaren kunde inte hittas";
            }
            //Inte relevant för vanliga användare då sålda artiklar inte kommer visas för dessa || adminfunktionalitet
            var kopNamn = client.HamtaAnnons(id).koparID;
            if ( kopNamn == null)
            {
                kopNamn = "Köparen kunde inte hittas";
            }
            ViewBag.saljarNamn = saljNamn;
            ViewBag.kopNamn = kopNamn;

            return View(annons);
        }
        public ActionResult Kop(int id)
        {
            //Kollar sessionsID
            loginReferences.InloggningServiceClient logclient = new loginReferences.InloggningServiceClient();
            if (Session["profilId"] != null)
            {
                int idny = Convert.ToInt32(Session["profilId"]);
                
                if (logclient.VerifieraInloggning(idny))
                {
                }
                //Omirigering till inloggningssidan.
                else
                {
                    string url = "http://193.10.202.74/Anvandare/Profil/VisaProfil";
                    Response.Redirect(url);

                    return View();
                }
            }
            else
            {
                string url = "http://193.10.202.74/Anvandare/Profil/VisaProfil";
                Response.Redirect(url);

                return View();
            }
            
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var annons = client.HamtaAnnons(id);
            if (Session["profilId"] != null)
            {
                // Ändra status till såld
                annons.status = "Såld";
                // Spara nuvarande användare som köpare
                annons.koparID = Convert.ToInt32(Session["profilId"]).ToString();
                // Spara ny info
                client.UppdateraAnnons(annons);

                // Skicka vidare till betalningstjänst
                return Redirect("http://193.10.202.73/betaltjanst/Betalnings/Betala?Id=" + annons.koparID.ToString() + "&AnnonsID=" + annons.annonsID.ToString());
            }
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Redigera(int id)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            //Hämtar annons för aktivt ID
            var result = client.HamtaAnnons(id);

            return View(result);
        }
        [HttpPost]
        public ActionResult Redigera(ServiceReference1.Annonser annons)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            annons.kategori = Request.Form["Kategorier"].ToString();
            //Uppdaterar databas med nya värden
            var result = client.UppdateraAnnons(annons);

            return RedirectToAction("Index", "Home");
        }


    }
}