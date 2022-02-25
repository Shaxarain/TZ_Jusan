using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TZ_Jusan.Models
{
    public static class Enter
    {

        public static List<FizLico> fizLica1 = new List<FizLico>
        {
                new FizLico(101, "123456789098", DateTime.Parse("1997-12-27"), "Kimiz", DateTime.Parse("1997-12-27"),
                    "Kimiz", "101, Rayimbeka", "Orange", "Katya", "Victorovna"),
                //error num in surname
                new FizLico(102, "000606573999", DateTime.Parse("1997-12-28"), "Maria", DateTime.Parse("1998-01-05"),
                    "Egor", "73, Leningradova", "Rim0v", "Sergey", "Dmitrievich"),
                new FizLico(103, "000000000000", DateTime.Parse("1998-11-10"), "Cap", DateTime.Parse("1999-01-01"),
                    "Liza", "1, Jhumabaeva", "Norov", "Stepan", "Larionovich"),
                new FizLico(104, "000000000000", DateTime.Parse("1998-11-10"), "Cap", DateTime.Parse("1999-01-01"),
                    "Liza", "1, Jhumabaeva", "Norov", "Stepan", "Zarionovich")
        };
        public static List<FizLico> fizLica2 = new List<FizLico>
        {
            new FizLico(235, "6373794562069", DateTime.Parse("2003-05-05"), "Alibek", DateTime.Parse("2003-05-10"),
                "Kozha", "456, Orilbaeva", "Lirikov", "Makar", "Jhanibekov"),
        };
        public static List<FizLico> fizLica3 = new List<FizLico>
        {
            new FizLico(45, "94727563078", DateTime.Parse("2010-10-26"), "Serik", DateTime.Parse("2010-10-26"),
                "Serik", "32, Altinsarina", "Beisembin", "Make", "Sakeevich"),
            new FizLico(46, "846206937596", DateTime.Parse("2010-11-11"), "Ansar", DateTime.Parse("2010-04-08"),
                "Jholbaris", "101, Dostik", "Sirov", "Ergali", "Almazovich"),
            new FizLico(47, "95676296830857", DateTime.Parse("2020-12-12"), "Kanat", DateTime.Parse("2020-12-12"),
                "Kanat", "444, Gagarina", "Siitova", "Kyralai", "Ospanovna")
        };

        public static List<UrLico> urLica = new List<UrLico>
        {
            //error count idn
                new UrLico(33, "98383657494", DateTime.Parse("2010-09-15"), "Leroy", DateTime.Parse("2011-03-12"),
                    "Kimbat", "99, Prostokvashino", "TOO Makbett", fizLica1),
                new UrLico(34, "888444666000", DateTime.Parse("2010-10-22"), "Berik", DateTime.Parse("2012-02-07"),
                    "Bota", "99, Putino", "IP Anatoliy", fizLica2),
                //error letter in idn
                new UrLico(35, "342o534294929", DateTime.Parse("2020-08-10"), "Akezhan", DateTime.Parse("2020-08-10"),
                    "Ademi", "486, Lubimova", "TOO Silko", fizLica3)
        };
    }
}
