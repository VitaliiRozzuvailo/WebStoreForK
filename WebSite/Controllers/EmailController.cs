using System.Net.Mail;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class EmailController : SurfaceController
    {
        [HttpPost]
        public ActionResult Send (OrderModel model)
        {
            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage("no-reply@luck.kh.ua", "vrozzuvaylo@gmail.com");
                mail.Subject = "Заказ Люков!";
                mail.Body = string.Format("<p>Имя: {0}</p><p>Телефон: {1}</p><p>Е-маил: {2}</p>", model.Name, model.Phone, model.Email);
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient();
                client.Send(mail);
            }
            return CurrentUmbracoPage();
        }
    }
}