using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using WebUI.Models.Mail;

namespace WebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("ToDoAdmin", "sad549333@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodybuilder = new BodyBuilder();
            bodybuilder.TextBody = model.Body;
            mimeMessage.Body = bodybuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("sad549333@gmail.com", "hsqyhipvfidjtdep");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Index", "ToDo");
        }
    
    }
}
