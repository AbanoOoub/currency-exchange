using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConvertMoney
{
    public partial class MainPage : ContentPage
    {
        Data d = new Data();
        List<string> Countries = new List<string>();
        List<Dictionary<string, double>> list_dic = new List<Dictionary<string, double>>();
        Dictionary<string, double> Bit_dic      = new Dictionary<string, double>();
        Dictionary<string, double> USD_dic      = new Dictionary<string, double>();
        Dictionary<string, double> EGY_dic      = new Dictionary<string, double>();
        Dictionary<string, double> Emirates_dic = new Dictionary<string, double>();
        Dictionary<string, double> Tunisian_dic = new Dictionary<string, double>();
        Dictionary<string, double> African_dic  = new Dictionary<string, double>();
        Dictionary<string, double> Russian_dic  = new Dictionary<string, double>();
        Dictionary<string, double> Zealand_dic  = new Dictionary<string, double>();
        Dictionary<string, double> Kuwaiti_dic  = new Dictionary<string, double>();
        Dictionary<string, double> Hong_dic     = new Dictionary<string, double>();
       
        public MainPage()
        {
            InitializeComponent();
           
            AddCountries();
            Initialize_Bitdic();
            Initialize_USDdic();
            Initialize_EGYdic();
            Initialize_Emiratesdic();
            Initialize_Tunisiandic();
            Initialize_Africandic();
            Initialize_Russiandic();
            Initialize_Zealandsdic();
            Initialize_Kuwaitidic();
            Initialize_Hongdic();
            Initialize_listdic();
            foreach (var N in Countries)
            {
                picker1.Items.Add(N);
                picker2.Items.Add(N);
            }
        }
        public void AddCountries()
        {
            Countries.Add("Bitcoin Cash");
            Countries.Add("United States Dollar");
            Countries.Add("Egyptian Pound");
            Countries.Add("United Arab Emirates Dirham");
            Countries.Add("Tunisian Dinar");
            Countries.Add("South African Rand");
            Countries.Add("Russian Ruble");
            Countries.Add("New Zealand Dollar");
            Countries.Add("Kuwaiti Dinar");
            Countries.Add("Hong Kong Dollar");
            
        }
        public void Initialize_Bitdic()
        {
            Bit_dic.Add("UnitedStatesDollar", 11850.00);
            Bit_dic.Add("EgyptianPound", 196632.98);
            Bit_dic.Add("UnitedArabEmiratesDirham", 43526.24);
            Bit_dic.Add("TunisianDinar", 34210.95);
            Bit_dic.Add("SouthAfricanRand", 165410.60);
            Bit_dic.Add("RussianRuble", 746549.06);
            Bit_dic.Add("NewZealandDollar", 17685.41);
            Bit_dic.Add("KuwaitiDinar", 3600.67);
            Bit_dic.Add("HongKongDollar", 92648.17);
        }
        public void Initialize_USDdic()
        {
            USD_dic.Add("BitcoinCash", 0.000085);
            USD_dic.Add("EgyptianPound", 16.59);
            USD_dic.Add("UnitedArabEmiratesDirham", 3.67);
            USD_dic.Add("TunisianDinar", 2.89);
            USD_dic.Add("SouthAfricanRand", 13.96);
            USD_dic.Add("RussianRuble", 63.05);
            USD_dic.Add("NewZealandDollar", 1.49);
            USD_dic.Add("KuwaitiDinar", 0.30);
            USD_dic.Add("HongKongDollar", 7.82);
        }
        public void Initialize_EGYdic()
        {
            EGY_dic.Add("BitcoinCash", 0.00017);
            EGY_dic.Add("UnitedStatesDollar", 0.060);
            EGY_dic.Add("UnitedArabEmiratesDirham", 0.22);
            EGY_dic.Add("TunisianDinar", 0.17);
            EGY_dic.Add("SouthAfricanRand", 0.84);
            EGY_dic.Add("RussianRuble", 3.80);
            EGY_dic.Add("NewZealandDollar", 0.090);
            EGY_dic.Add("KuwaitiDinar", 0.018);
            EGY_dic.Add("HongKongDollar", 0.47);
        }
        
        public void Initialize_Emiratesdic()
        {
            Emirates_dic.Add("BitcoinCash", 0.000023);
            Emirates_dic.Add("UnitedStatesDollar", 0.27);
            Emirates_dic.Add("EgyptianPound", 4.52);
            Emirates_dic.Add("TunisianDinar", 0.79);
            Emirates_dic.Add("SouthAfricanRand", 3.80);
            Emirates_dic.Add("RussianRuble", 17.17);
            Emirates_dic.Add("NewZealandDollar", 0.41);
            Emirates_dic.Add("KuwaitiDinar", 0.083);
            Emirates_dic.Add("HongKongDollar", 2.13);
        }                                
        public void Initialize_Tunisiandic()
        {
            Tunisian_dic.Add("BitcoinCash", 0.000029);
            Tunisian_dic.Add("UnitedStatesDollar", 0.35);
            Tunisian_dic.Add("EgyptianPound", 5.75);
            Tunisian_dic.Add("UnitedArabEmiratesDirham", 1.27);
            Tunisian_dic.Add("SouthAfricanRand", 4.84);
            Tunisian_dic.Add("RussianRuble", 21.84);
            Tunisian_dic.Add("NewZealandDollar", 0.52);
            Tunisian_dic.Add("KuwaitiDinar", 0.11);
            Tunisian_dic.Add("HongKongDollar", 2.71);
        }                                
        public void Initialize_Africandic()
        {
            African_dic.Add("BitcoinCash", 0.0000061);
            African_dic.Add("UnitedStatesDollar", 0.072);
            African_dic.Add("EgyptianPound", 1.19);
            African_dic.Add("UnitedArabEmiratesDirham", 0.26);
            African_dic.Add("TunisianDinar", 0.21);
            African_dic.Add("RussianRuble", 4.52);
            African_dic.Add("NewZealandDollar", 0.11);
            African_dic.Add("KuwaitiDinar", 0.022);
            African_dic.Add("HongKongDollar", 0.56);
        }                               
        public void Initialize_Russiandic()
        {
            Russian_dic.Add("BitcoinCash", 0.0000013);
            Russian_dic.Add("UnitedStatesDollar", 0.016);
            Russian_dic.Add("EgyptianPound", 0.26);
            Russian_dic.Add("UnitedArabEmiratesDirham", 0.058);
            Russian_dic.Add("TunisianDinar", 0.046);
            Russian_dic.Add("SouthAfricanRand", 0.22);
            Russian_dic.Add("NewZealandDollar", 0.024);
            Russian_dic.Add("KuwaitiDinar", 0.0048);
            Russian_dic.Add("HongKongDollar", 0.12);
        }                               
        public void Initialize_Zealandsdic()
        {
            Zealand_dic.Add("BitcoinCash", 0.000056);
            Zealand_dic.Add("UnitedStatesDollar", 0.67);
            Zealand_dic.Add("EgyptianPound", 11.11);
            Zealand_dic.Add("UnitedArabEmiratesDirham", 2.46);
            Zealand_dic.Add("TunisianDinar", 1.93);
            Zealand_dic.Add("SouthAfricanRand", 9.35);
            Zealand_dic.Add("RussianRuble", 42.21);
            Zealand_dic.Add("KuwaitiDinar", 0.20);
            Zealand_dic.Add("HongKongDollar", 5.24);
        }                               
        public void Initialize_Kuwaitidic()
        {
            Kuwaiti_dic.Add("BitcoinCash", 0.00028);
            Kuwaiti_dic.Add("UnitedStatesDollar", 3.29);
            Kuwaiti_dic.Add("EgyptianPound", 54.52);
            Kuwaiti_dic.Add("UnitedArabEmiratesDirham", 12.07);
            Kuwaiti_dic.Add("TunisianDinar", 9.49);
            Kuwaiti_dic.Add("SouthAfricanRand", 45.87);
            Kuwaiti_dic.Add("RussianRuble", 207.17);
            Kuwaiti_dic.Add("NewZealandDollar", 4.91);
            Kuwaiti_dic.Add("HongKongDollar", 25.71);
        }                              
        public void Initialize_Hongdic()
        {
            Hong_dic.Add("BitcoinCash", 0.000011);
            Hong_dic.Add("UnitedStatesDollar", 0.13);
            Hong_dic.Add("EgyptianPound", 2.12);
            Hong_dic.Add("UnitedArabEmiratesDirham", 0.47);
            Hong_dic.Add("TunisianDinar", 0.37);
            Hong_dic.Add("SouthAfricanRand", 1.78);
            Hong_dic.Add("RussianRuble", 8.06);
            Hong_dic.Add("NewZealandDollar", 0.19);
            Hong_dic.Add("KuwaitiDinar", 0.039);
        }                           
        public void Initialize_listdic()
        {
            list_dic.Add(Bit_dic);
            list_dic.Add(USD_dic);
            list_dic.Add(EGY_dic);
            list_dic.Add(Emirates_dic);
            list_dic.Add(Tunisian_dic);
            list_dic.Add(African_dic);
            list_dic.Add(Russian_dic);
            list_dic.Add(Zealand_dic);
            list_dic.Add(Kuwaiti_dic);
            list_dic.Add(Hong_dic);
        }

        private void Picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string x =  picker1.SelectedItem.ToString();
            d.country1 = x.Replace(" ", string.Empty);
            

        }
        private void Picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string y = picker2.SelectedItem.ToString();
            d.country2 = y.Replace(" ", string.Empty);
           
        }

        public void OtherCountry(Data T)
        {
            
                if (T.country1 == T.country2)
                    DisplayAlert("Warning", "you must choose different counties", "Ok");
                else if (amount.Text == "amount" || amount.Text == null)
                    DisplayAlert("Warning", "you must enter value", "Ok");
                else if (Convert.ToDouble(amount.Text) <= 0)
                    DisplayAlert("Warning", "you must enter value greater than Zero", "Ok");
                else
                {
                    switch (T.country2)
                    {
                        case "BitcoinCash":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "Bitcoin Cash";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "UnitedStatesDollar":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "United States Dollar";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "EgyptianPound":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "Egyptian Pound";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "UnitedArabEmiratesDirham":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "United Arab Emirates Dirham";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "TunisianDinar":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "Tunisian Dinar";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "SouthAfricanRand":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "South African Rand";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "RussianRuble":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "Russian Ruble";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "NewZealandDollar":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "New Zealand Dollar";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "KuwaitiDinar":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "Kuwaiti Dinar";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                        case "HongKongDollar":
                            T.money = Convert.ToDouble(amount.Text) * T.dic[T.country2];
                            value.Text = T.money.ToString();
                            MoneyName.Text = "Hong Kong Dollar";
                            rate.Source = "@drawable/" + T.country1 + T.country2;
                            rate.IsVisible = true;
                            rate.RelScaleTo(1.5, 250);
                            break;
                    }
                }
            }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (rate.IsVisible)
                DisplayAlert("Warning", "please change the amount or country", "OK");
            else
            {
                switch (d.country1)
                {
                    case "BitcoinCash":
                        d.dic = Bit_dic;
                        OtherCountry(d);

                        break;
                    case "UnitedStatesDollar":
                        d.dic = USD_dic;
                        OtherCountry(d);
                        break;
                    case "EgyptianPound":
                        d.dic = EGY_dic;
                        OtherCountry(d);
                        break;
                    case "UnitedArabEmiratesDirham":
                        d.dic = Emirates_dic;
                        OtherCountry(d);
                        break;
                    case "TunisianDinar":
                        d.dic = Tunisian_dic;
                        OtherCountry(d);
                        break;
                    case "SouthAfricanRand":
                        d.dic = African_dic;
                        OtherCountry(d);
                        break;
                    case "RussianRuble":
                        d.dic = Russian_dic;
                        OtherCountry(d);
                        break;
                    case "NewZealandDollar":
                        d.dic = Zealand_dic;
                        OtherCountry(d);
                        break;
                    case "KuwaitiDinar":
                        d.dic = Kuwaiti_dic;
                        OtherCountry(d);
                        break;
                    case "HongKongDollar":
                        d.dic = Hong_dic;
                        OtherCountry(d);
                        break;
                }
            }
        }
        private void focused(object sender, EventArgs e)
        {
            rate.IsVisible = false;
            amount.Text = string.Empty;
            rate.ScaleTo(0.50, 250);
        }

        private void Picker1_Focused(object sender, FocusEventArgs e)
        {
            if (rate.IsVisible)
                rate.IsVisible = false;
            value.Text = string.Empty;
            MoneyName.Text = string.Empty;
            rate.ScaleTo(0.50, 250);
        }

        private void Picker2_Focused(object sender, FocusEventArgs e)
        {
            if (rate.IsVisible)
                rate.IsVisible = false;
            value.Text = string.Empty;
            MoneyName.Text = string.Empty;
            rate.ScaleTo(0.50, 250);
        }
    }
}

