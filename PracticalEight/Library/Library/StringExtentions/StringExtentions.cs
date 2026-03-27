using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.StringExtentions;

public static class StringExtentions
{
    /// <summary>
    /// to capitalize first letter of any of incoming string as text
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string ToCapitalize(this string text)
    {
        if (String.IsNullOrEmpty(text))
        {
            return String.Empty;
        }

        return (char.ToUpper(text[0]) + text.Substring(1));
    }
}
