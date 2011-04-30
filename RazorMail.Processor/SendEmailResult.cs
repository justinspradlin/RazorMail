// <copyright file=SendEmailResult.cs company=Justin Spradlin>
//      Copyright (c) 2011 Justin Spradlin.  ALL RIGHTS RESERVED
// </copyright>
// <product></product>
// <author>jspradlin</author>
// <created>Friday, April 29, 2011</created>
// <lastedit>Friday, April 29, 2011</lastedit>
namespace RazorMail.Processor
{
    using System;

    public class SendEmailResult
    {
        #region Properties

        public Exception Exception
        {
            get;
            set;
        }

        public bool Failed
        {
            get { return this.Exception != null; }
        }

        public System.Net.Mail.MailMessage Message
        {
            get;
            internal set;
        }

        #endregion Properties
    }
}