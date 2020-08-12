using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class steam_price
    {
        public string Price_steam
        { private set; get; }

        public steam_price(string htmlCode)
        {
            Price_steam = Regex.Match(htmlCode, @"{""success"":true,""lowest_price"":""((\d+\,\d+)|\d+)\\u20b4"",").Groups[0].Value;
        }
    }
}
