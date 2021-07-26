using System;
using System.Collections.Generic;
using System.Text;

namespace Photoapp2
{
    public class Photo
    {
        public String Id { get; set; }
        public String Title { get; set; }
        public String Style { get; set; }
        public int  View { get; set; }
        public String Privacy { get; set; }

        public int Price { get; set; }

        public Photo()
        {
            Id = "";
            Title = "";
            Style = "";
            View = 0;
            Privacy = "";
            Price = 0;

        }
        public Photo(String a, String b, String c, int d, String e, int f)
        {
            Id = a;
            Title = b;
            Style = c;
            View = d;
            Privacy = e;
            Price = f;
        }

        override public string ToString()
        {
            return " ID: " + Id + " Title: " + Title + " Description: " + Style + " View: " + View + " Privacy: " + Privacy + " Price: $ " + Price;
        }




    }
}
