using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImpeCustomers.Services
{
    public class ExternalLoginUtilities
    {
        public static string GetImgUrlByName(string authenticationType) {
            string result = "";

            switch (authenticationType)
            {
                case "Google":
                    result = "/Images/Icons/google-logo.png";
                        break;
                case "Facebook":
                    result = "/Images/Icons/facebook-logo.jpeg";
                    break;
                case "LinkedIn":
                    result = "/Images/Icons/linkedin-logo.png";
                    break;
                case "Twitter":
                    result = "/Images/Icons/twitter-logo.jpg";
                    break;
                case "Microsoft":
                    result = "/Images/Icons/microsoft-logo.png";
                    break;
                default:
                    break;
            }



            return result;
        }
    }
}