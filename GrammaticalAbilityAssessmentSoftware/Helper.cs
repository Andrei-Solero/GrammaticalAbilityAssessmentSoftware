using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GrammaticalAbilityAssessmentSoftware
{
    public static class Helper
    {
        public static string FormatName(string name)
        {
            TextInfo textInfo = new CultureInfo("en-us", false).TextInfo;
            return textInfo.ToTitleCase(name);
        }
    }
}
