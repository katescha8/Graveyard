using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.IO;


namespace Graveyard
{
    public class JSON
    {
        public static string path = File.ReadAllText("graveyard.json");
        public static RitualShop rs = new RitualShop();
        public static Coffin c = new Coffin();
        public static Wreath w = new Wreath();
        public static Chapel ch = new Chapel();
        public static Graves g = new Graves();
        public static void GetJSONfile()
        {
            RitualShopjson();
            Chapeljson();
            Gravesjson();
        }
        public static void RitualShopjson()
        {
            JsonNode data = JsonNode.Parse(path);
            JsonNode gr = data["Graveyard"];
            JsonNode rsj = gr["RitualShop"];
            JsonNode cj = rsj["Coffin"];
            JsonNode wj = rsj["Wreath"];
            rs.name = rsj["Name"].ToString();
            c.size = cj["Size"].ToString();
            c.price_pine = int.Parse((string)cj["PricePine"]);
            c.price_larch = int.Parse((string)cj["PriceLarch"]);
            c.price_linden = int.Parse((string)cj["PriceLinden"]);
            c.price_oak = int.Parse((string)cj["PriceOak"]);
            w.whiteLily = int.Parse((string)wj["WhiteLily"]);
            w.redRoses = int.Parse((string)wj["RedRoses"]);
            w.redCarnation = int.Parse((string)wj["RedCarnation"]);
            w.artifical2 = int.Parse((string)wj["Artifical2"]);
            w.artifical6 = int.Parse((string)wj["Artifical6"]);
        }
        public static void Chapeljson()
        {
            JsonNode data = JsonNode.Parse(path);
            JsonNode gr = data["Graveyard"];
            JsonNode chj = gr["Chapel"];
            ch.name = chj["Name"].ToString();
            ch.price1Candle = int.Parse((string)chj["Price1Candle"]);
            ch.price3Candle = int.Parse((string)chj["Price3Candles"]);
            ch.price5Candle = int.Parse((string)chj["Price5Candles"]);
            ch.funeral = int.Parse((string)chj["Funeral"]);
        }
        public static void Gravesjson()
        {
            JsonNode data = JsonNode.Parse(path);
            JsonNode gr = data["Graveyard"];
            JsonNode gj = gr["Graves"];
            g.name = gj["Name"].ToString();
            g.number = int.Parse((string)gj["Number"]);
            g.pollutionlevel = int.Parse((string)gj["Pollutionlevel"]);
            g.life_years = (string)gj["LifeYears"];
            g.text = (string)gj["Text"];
        }
    }
}
