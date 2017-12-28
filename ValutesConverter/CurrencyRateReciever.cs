using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ValutesConverter
{
        class CurrencyRateReciever
        {
                protected const string cbr_uri = "http://www.cbr.ru/scripts/XML_daily_eng.asp";

                

                protected string xml_rates;


                public string XmlRates
                {
                        get
                        {
                                if (xml_rates != null)
                                        return xml_rates;

                                else
                                        return String.Empty;
                        }
                }



                public void LoadCurrencies()
                {


                        WebRequest _ask_rates = WebRequest.Create(cbr_uri);

                        WebResponse _get_rates = _ask_rates.GetResponse();

                        StreamReader web_reader = new StreamReader(_get_rates.GetResponseStream());

                        xml_rates = web_reader.ReadToEnd();
                        

                }
        }
}
