using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ValutesConverter
{
    class RateHandler
    {
                protected XmlDocument ratesdoc = new XmlDocument();

                public void Load(string a)
                {
                        
                                ratesdoc.LoadXml(a);
                        
                                            

                        
                        
                }

                public ObservableCollection <Currencie> GetCurrenciesList()
                {
                        ObservableCollection <Currencie> tmplist = new ObservableCollection<Currencie> ();

                        XmlElement xelement = ratesdoc.DocumentElement;

                        XmlNodeList xlist = xelement.SelectNodes("//Valute");
                        
                        for (int i = 0; i < xlist.Count;i++)
                        {
                                XmlNode xname = xlist[i].SelectSingleNode("Name");

                                XmlNode xvalue = xlist[i].SelectSingleNode("Value");

                                string name = xname.InnerText;

                                string tmprate = xvalue.InnerText;

                                tmprate.Replace(',', '.');

                                Double rate = Double.Parse(tmprate);

                                tmplist.Add(new Currencie(name, rate));
                        }

                        return tmplist;
                }

               

               
    }
}
