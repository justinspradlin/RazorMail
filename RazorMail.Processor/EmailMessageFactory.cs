// <copyright file=EmailMessageFactory.cs company=Justin Spradlin>
//      Copyright (c) 2011 Justin Spradlin.  ALL RIGHTS RESERVED
// </copyright>
// <product></product>
// <author>jspradlin</author>
// <created>Friday, April 29, 2011</created>
// <lastedit>Friday, April 29, 2011</lastedit>
namespace RazorMail.Processor
{
    using System.Configuration;
    using System.Net.Mail;

    /// <summary>
    /// This class contains methods to create a mail message to be sent to a user.
    /// </summary>
    public static class EmailMessageFactory
    {
        #region Methods

        public static MailMessage GetWelcomeEmail(string toAddress, string userName, string userFullName, string password, string loginUrl, string senderAddress)
        {
            var templatePath = ConfigurationManager.AppSettings["WelcomeTemplate"];

            var body = EmailTemplateResolver.GetEmailBody(
                templatePath,
                new
                {
                    UserName = userName,
                    FullName = userFullName,
                    Password = password,
                    LoginUrl = loginUrl
                });

            return new MailMessage(
                    senderAddress,
                    toAddress,
                    "Welcome to our site!",
                    body);
        }

        #endregion Methods
    }
}