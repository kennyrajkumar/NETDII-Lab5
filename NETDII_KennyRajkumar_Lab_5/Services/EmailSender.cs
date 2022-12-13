using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETDII_KennyRajkumar_Lab_5.Services
{
    public class EmailSender : IEmailSender
    {
        //Creates IOptions method
        public EmailSender(IOptions<AuthMessageSenderOptions> options)
        {
            Options = options.Value;
        }
        //Create Options variable using our other class
        public AuthMessageSenderOptions Options { get; }

        //Creates SendEmailAsync task that will run the execute task below
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(Options.SendGridKey, subject, htmlMessage, email);
        }

        //Creates the Execute task
        private Task Execute(string apiKey, string subject, string htmlMessage, string email)
        {
            //Creates new SendGridClient using apiKey
            var client = new SendGridClient(apiKey);
            //Creates new SendGridMessage using method
            var msg = new SendGridMessage()
            {
                //Creating email format
                From = new EmailAddress("ask@kwsupport.com", "Keen's Wholesale"),
                Subject = subject,
                PlainTextContent = htmlMessage,
                HtmlContent = htmlMessage
            };

            //Creating new email address with clients email
            msg.AddTo(new EmailAddress(email));
            //Disable click tracking
            msg.SetClickTracking(false, false);
            return client.SendEmailAsync(msg);
        }
    }
}
