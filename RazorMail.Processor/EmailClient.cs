// <copyright file=EmailClient.cs company=Justin Spradlin>
//      Copyright (c) 2011 Justin Spradlin.  ALL RIGHTS RESERVED
// </copyright>
// <product></product>
// <author>jspradlin</author>
// <created>Friday, April 29, 2011</created>
// <lastedit>Friday, April 29, 2011</lastedit>
namespace RazorMail.Processor
{
    using System;
    using System.Net.Mail;
    using System.Text;

    public static class EmailClient
    {
        #region Methods

        public static SendEmailResult SendEmail(System.Net.Mail.MailMessage message)
        {
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient mailClient = new SmtpClient();
            var log = new SendEmailResult() { Message = message };
            try
            {
                mailClient.Send(message);
            }
            catch (Exception ex)
            {
                log.Exception = ex;
            }

            return log;
        }

        #endregion Methods
    }
}