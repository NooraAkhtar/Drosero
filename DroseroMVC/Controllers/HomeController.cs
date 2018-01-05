using Drosero.Domain.Interfaces;
using Drosero.Domain.Models;
using DroseroMVC.Mediators;
using DroseroMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace DroseroMVC.Controllers
{
    public class HomeController : Controller
    {
        //ReservationMediator reservationMediator;

        public HomeController()
        {
            
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        //public async Task<JsonResult> SendSms(Customer customer)
        //{
        //    try
        //    {
        //        if (reservationMediator.Save(customer).Id != 0)
        //        {
        //            var twilioSID = ConfigurationManager.AppSettings["TwilioSID"].ToString();
        //            var twilioAuthToken = ConfigurationManager.AppSettings["TwilioAuthToken"].ToString();
        //            Twilio.TwilioClient.Init(twilioSID, twilioAuthToken);

        //            SendMessageToManager(customer);

        //            var to = new PhoneNumber(customer.Mobile);
        //            var from = new PhoneNumber("+16093164237");
        //            var content = await MessageResource.CreateAsync(to: to, from: from,
        //                body: string.Format("Dear {0}, You will shortly get the confirmation call, or contact +91 9717670527.", customer.Name));

        //            return new JsonResult { Data = content };
        //        }
        //    }
        //    catch(Exception e)
        //    {

        //    }
        //    return new JsonResult { Data = "Some error try again later" };
        //}

        //private async void SendMessageToManager(Customer customer)
        //{
        //    var managerMobile = ConfigurationManager.AppSettings["managerMobile"].ToString();
        //    var to = new PhoneNumber(managerMobile);
        //    var accountNumber = ConfigurationManager.AppSettings["accountNumber"].ToString();
        //    var from = new PhoneNumber(accountNumber);
        //    var content = await MessageResource.CreateAsync(to: to, from: from,
        //        body: string.Format("Name: {0}, Mb: {1}, Time: {2}", customer.Name, customer.Mobile, customer.ReservationDate));

        //}
    }
}