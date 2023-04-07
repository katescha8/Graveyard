using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graveyard
{
    public class RitualShop
    {
        public string name;
    }
    public class Chapel 
    {
        public string name;
        public int price1Candle;
        public int price3Candle { get; set; }
        public int price5Candle { get; set; }
        public int funeral { get; set; }

    }
    public class Graves
    {
        public int number { get; set; }
        public string name { get; set; }
        public string life_years { get; set; }
        public int pollutionlevel { get; set; }
        public string text { get; set; }
    }
    public class Coffin
    {
        public string size { get; set; }
        public int price_pine { get; set; }
        public int price_larch { get; set; }
        public int price_linden { get; set; }
        public int price_oak { get; set; }
    }
    public class Wreath
    {
        public int whiteLily { get; set; }
        public int redRoses { get; set; }
        public int redCarnation { get; set; }
        public int artifical2 { get; set; }
        public int artifical6 { get; set; }
    }
}
