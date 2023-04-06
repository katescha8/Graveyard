using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Graveyard
{
    public class XML
    {
        public static XmlDocument xDoc = new XmlDocument();
        public static RitualShop rs = new RitualShop();
        public static Coffin c = new Coffin();
        public static Wreath w = new Wreath();
        public static Chapel ch = new Chapel();
        public static Graves g = new Graves();
        public static List<object> lists = new List<object>();

        public static void GetXMLfile()
        {
            xDoc.Load("graveyard.xml");
            XmlElement root = xDoc.DocumentElement;
            ReadRitualShop(root);
            ReadChapel(root);
            ReadGraves(root);
        }
        public static void ReadRitualShop(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                Console.WriteLine("ss "+node.Name);
                if(node.Name == "RitualShop")
                {
                    lists.Add(rs);
                    rs.name = node.GetAttribute("Name");
                }
                foreach (XmlNode child0 in node.ChildNodes)
                {
                    if (child0.Name == "Coffin")
                    {
                        lists.Add(c);
                        foreach (XmlNode child in child0.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "Size":
                                    c.size = $"{child.InnerText}";
                                    break;
                                case "PricePine":
                                    c.price_pine = int.Parse(child.InnerText);
                                    break;
                                case "PriceLarch":
                                    c.price_larch = int.Parse(child.InnerText);
                                    break;
                                case "PriceLinden":
                                    c.price_linden = int.Parse(child.InnerText);
                                    break;
                                case "PriceOak":
                                    c.price_oak = int.Parse(child.InnerText);
                                    break;
                            }
                        }
                    }
                    if (child0.Name == "Wreath")
                    {
                        lists.Add(w);
                        foreach (XmlNode child in child0.ChildNodes)
                        {
                            switch (child.Name)
                            {
                                case "WhiteLily":
                                    w.whiteLily = int.Parse(child.InnerText);
                                    break;
                                case "RedRoses":
                                    w.redRoses = int.Parse(child.InnerText);
                                    break;
                                case "RedCarnation":
                                    w.redCarnation = int.Parse(child.InnerText);
                                    break;
                                case "Artifical2":
                                    w.artifical2 = int.Parse(child.InnerText);
                                    break;
                                case "Artifical6":
                                    w.artifical6 = int.Parse(child.InnerText);
                                    break;
                            }
                        }
                    }
                }
            }
        }
        public static void ReadChapel(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
                if (node.Name == "Chapel")
                {
                    ch.name = node.GetAttribute("Name");
                    lists.Add(ch);
                    foreach (XmlNode child in node.ChildNodes)
                    {
                            switch (child.Name)
                            {
                            case "Price1Candle":
                                ch.price1Candle = int.Parse(child.InnerText);
                                break;
                            case "Price3Candles":
                                ch.price3Candle = int.Parse(child.InnerText);
                                break;
                            case "Price5Candles":
                                ch.price5Candle = int.Parse(child.InnerText);
                                break;
                            case "Funeral":
                                ch.funeral = int.Parse(child.InnerText);
                                break;
                            }
                    }
                }
            }
        }
        public static void ReadGraves(XmlElement root)
        {
            foreach (XmlElement node in root)
            {
               if (node.Name == "Graves")
               {
                    g.number = node.GetAttribute("Number");
                    lists.Add(g);
                    foreach (XmlNode child in node.ChildNodes)
                    {
                        switch (child.Name)
                        {
                            case "Pollutionlevel":
                                g.pollutionlevel = int.Parse(child.InnerText);
                                break;
                            case "Name":
                                g.name = child.InnerText;
                                break;
                            case "LifeYears":
                                g.life_years = child.InnerText;
                                break;
                            case "Text":
                                g.text = child.InnerText;
                                break;
                        }
                    }
               }
            }
        }
    }
}
