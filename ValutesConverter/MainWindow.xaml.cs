using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace ValutesConverter
{
       
        /// <summary>
        /// Логика взаимодействия для MainWindow.xaml
        /// </summary>
        public partial class MainWindow : INotifyPropertyChanged
        {
                public event PropertyChangedEventHandler PropertyChanged;

                ObservableCollection<Currencie> currencieslist = new ObservableCollection<Currencie>();

                CurrencyRateReciever crr = new CurrencyRateReciever();

                RateHandler rt = new RateHandler();

                Converter converter = new Converter();

                                      

                public MainWindow()
                {
                        InitializeComponent();
                        DataContext = this.DataContext;
                        crr.LoadCurrencies();
                        rt.Load(crr.XmlRates);
                        currencieslist = rt.GetCurrenciesList();
                        CurrenciesListBox.ItemsSource = currencieslist;
                                  
                       
                }

              
                public void OnPropertyChanged(string name)
                {
                        if (this.PropertyChanged != null)
                        {
                                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
                        }
                }

                #region User Input And Calculations
                public void ReplaceComma(ref string input)
                {
                        if (input.Contains(','))
                                input.Replace(',', '.');
                       
                }



                public bool CheckCalculateInput(string input)
                {
                        bool check;
                        Double tmp;

                        check = Double.TryParse(input, out tmp);

                        return check;
                        
                }

                public Double ConvertInput(string input)
                {
                        Double tmp = Convert.ToDouble(input);
                        return tmp;

                }

                public void OnCalculateButtonClick(object sender, RoutedEventArgs e)
                {
                        string input = InputTextBox.Text;

                        ReplaceComma(ref input);

                        if (!CheckCalculateInput(input)) return;
                                
                        

                        

                        Double userinput = ConvertInput(input);

                        var selecteditem = (CurrenciesListBox.Items[CurrenciesListBox.SelectedIndex] as Currencie);

                        ResultTextBlock.Text = (userinput * selecteditem.Rate).ToString() + " рублей";

                }

                #endregion
        }
}
