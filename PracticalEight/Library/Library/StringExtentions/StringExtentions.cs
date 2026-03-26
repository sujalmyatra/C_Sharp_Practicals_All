using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.StringExtentions;

public static class StringExtentions
{
    public static string ToCapitalize(this string text)
    {
        if (String.IsNullOrEmpty(text))
        {
            return String.Empty;
        }

        return (char.ToUpper(text[0]) + text.Substring(1));
    }
}
