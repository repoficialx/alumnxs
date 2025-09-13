using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnxs48.mls
{
    internal class langload
    {
        public static string cLang { get; set; }
        public enum lang
        {
            en_US = 0,
            es_ES = 1
        }
        public static void SL(lang lang) {
            if (lang == lang.en_US)
            {
                Strings.Titulo = "new";
                Strings.Nombre = "Full Name";
                Strings.Nacimiento = "Birthday";
                Strings.Teléfono = "Phone number";
                Strings.Email = "E-Mail";
                Strings.Género = "Gender";
                Strings.Notas1 = "Notes";
                Strings.Notas2 = "Notes2";
                Strings.Notas3 = "Notes3";
                Strings.Añadir = "Add";
                Strings.HCG = "Cisgender Male";
                Strings.MCG = "Cisgender Female";
                Strings.HTG = "Transgender Male";
                Strings.MTG = "Transgender Female";
                Strings.NBN = "Non-binary";
                Strings.AGN = "Agender";
                Strings.PGN = "Pangender";
                Strings.OTR = "Other";
                Strings.PhoneMask = "+_ (000) 000-0000";
                Strings.DateMask = "00/00/0000"; // DD-MM-YYYY
            }
            else if (lang == lang.es_ES)
            {
                Strings.Titulo = "nuevx";
                Strings.Nombre = "Nombre";
                Strings.Nacimiento = "Nacimiento";
                Strings.Teléfono = "Nº de Teléfono";
                Strings.Email = "E·Mail";
                Strings.Género = "Género";
                Strings.Notas1 = "Notas";
                Strings.Notas2 = "Notas2";
                Strings.Notas3 = "Notas3";
                Strings.Añadir = "Añadir";
                Strings.HCG = "Hombre cisgénero";
                Strings.MCG = "Mujer cisgénero";
                Strings.HTG = "Hombre transgénero";
                Strings.MTG = "Mujer transgénero";
                Strings.NBN = "No binarix";
                Strings.AGN = "Agénero";
                Strings.PGN = "Pangénero";
                Strings.OTR = "Otro";
                Strings.PhoneMask = "+00 000-000-000";
                Strings.DateMask = "0000/00/00"; // YYYY-MM-DD
            }
        }
    }
    public static class Strings
    {
        // Nuevx
        public static string Titulo = "t";
        public static string Nombre = "n";
        public static string Nacimiento = "n";
        public static string Teléfono = "n";
        public static string Email = "n";
        public static string Género = "n";
        public static string Notas1 = "n";
        public static string Notas2 = "n";
        public static string Notas3 = "n";
        public static string Añadir = "n";
        public static string HCG = "n";
        public static string MCG = "n";
        public static string HTG = "n";
        public static string MTG = "n";
        public static string NBN = "n";
        public static string AGN = "n";
        public static string PGN = "n";
        public static string OTR = "n";
        public static string PhoneMask = "n";
        public static string DateMask = "n";
        //
    }

}
