using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PipsiProject.Models;
using System.Net.Mail;
using System.Net;

namespace PipsiProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

                                    
        public IActionResult Samochody()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Kontakt()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Kontakt(string receiver, string subject, string message, string formSender)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var senderEmail = new MailAddress("pipsitestemail@gmail.com", formSender);
                    var receiverEmail = new MailAddress(receiver);
                    var password = "pipsitestemail2020";
                    var sub = subject;
                    var body = message;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    ViewBag.Error = "Dziękujemy. Wiadomość została wysłana.";
                    return View();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Coś poszło nie tak... wiadomość nie została wysłana :(";
            }
            return View();
        }



        

        

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
