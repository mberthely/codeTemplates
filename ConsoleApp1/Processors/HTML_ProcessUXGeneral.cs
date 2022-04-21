using ConsoleApp1.Extensions;
using System;

namespace ConsoleApp1
{
    internal class HTML_ProcessUXGeneral
    {
        public HTML_ProcessUXGeneral()
        {
        }

        internal static ReponseItem LinkMenu(TableConfigItem c)
        {
            var r = new ReponseItem();
            r.FileName = $"MENU LINK";

            r.Text += $@"
                  <li><a href=""{c.EntityName.ToSepararConGuionMedioLowercase()}"">{c.EntityName.ToSepararConEspacio()}</a></li>
                ";

            return r;
        }
    }
}