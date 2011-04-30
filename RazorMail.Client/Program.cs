// <copyright file=Program.cs company=Justin Spradlin>
//      Copyright (c) 2011 Justin Spradlin.  ALL RIGHTS RESERVED
// </copyright>
// <product></product>
// <author>jspradlin</author>
// <created>Friday, April 29, 2011</created>
// <lastedit>Friday, April 29, 2011</lastedit>
namespace RazorMail.Client
{
    using System;
    using System.Configuration;

    using RazorMail.Processor;

    /// <summary>
    /// Main program
    /// </summary>
    class Program
    {
        #region Methods

        /// <summary>
        /// The main entry point for the console application.
        /// </summary>
        /// <param name="args">The command line arguments</param>
        static void Main(string[] args)
        {
            // Get the settings from the App.Config file
            var loginUrl = ConfigurationManager.AppSettings["LoginUrl"];
            var senderAddress = ConfigurationManager.AppSettings["SenderAddress"];

            // Create the mail object
            var email = EmailMessageFactory.GetWelcomeEmail(
                "jdoe@example.com",
                "jdoe123",
                "John Doe",
                "nerdyp@ss",
                loginUrl,
                senderAddress);

            // Send the message
            var result = EmailClient.SendEmail(email);

            // Check the result
            if (result.Failed)
            {
                Console.WriteLine(result.Exception.Message);
            }
            else
            {
                Console.WriteLine("Sent mail:");
                Console.Write(result.Message.Body);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        #endregion Methods
    }
}