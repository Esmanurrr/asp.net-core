﻿using System.Runtime.InteropServices;

namespace MyAspNetCoreApp.Web.Helpers
{
    public class Helper : IHelper
    {
        public string Upper(string text)
        {
            return text.ToUpper();
        }
    }
}
