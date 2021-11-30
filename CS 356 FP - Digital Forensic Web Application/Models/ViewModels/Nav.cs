using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS_356_FP___Digital_Forensic_Web_Application.Views.Models.ViewModels
{
    public class Nav
    {
        public static string Active(string value, string current) =>
            (value == current) ? "active" : "";
        public static string Active(int value, int current) =>
            (value == current) ? "active" : "";
    }
}
