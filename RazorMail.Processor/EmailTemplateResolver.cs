// <copyright file=EmailTemplateResolver.cs company=Justin Spradlin>
//      Copyright (c) 2011 Justin Spradlin.  ALL RIGHTS RESERVED
// </copyright>
// <product></product>
// <author>jspradlin</author>
// <created>Friday, April 29, 2011</created>
// <lastedit>Friday, April 29, 2011</lastedit>
namespace RazorMail.Processor
{
    using System.IO;

    using RazorEngine;

    /// <summary>
    /// Summary description for TemplateResolver
    /// </summary>
    public class EmailTemplateResolver
    {
        #region Methods

        public static string GetEmailBody(string templatePath, dynamic model)
        {
            var template = File.ReadAllText(templatePath);
            var body = Razor.Parse(template, model);
            return body;
        }

        #endregion Methods
    }
}