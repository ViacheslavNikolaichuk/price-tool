using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SteamItem_price_tool
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_dmarket.ColumnCount = 6;
            dataGridView_dmarket.Columns[0].Name = "Name";
            dataGridView_dmarket.Columns[1].Name = "Price_dmarket";
            dataGridView_dmarket.Columns[2].Name = "Price_steam";
            dataGridView_dmarket.Columns[3].Name = "Max_price";
            dataGridView_dmarket.Columns[4].Name = "Profit";
            dataGridView_dmarket.Columns[5].Name = "Link";

            dataGridView_steam.ColumnCount = 6;
            dataGridView_steam.Columns[0].Name = "Name";
            dataGridView_steam.Columns[1].Name = "Price_steam";
            dataGridView_steam.Columns[2].Name = "Price_dmarket";
            dataGridView_steam.Columns[3].Name = "Max_price";
            dataGridView_steam.Columns[4].Name = "Profit";
            dataGridView_steam.Columns[5].Name = "Link";

            dataGridView_error.ColumnCount = 5;
            dataGridView_error.Columns[0].Name = "Raw_Name";
            dataGridView_error.Columns[1].Name = "Curent_Name";
            dataGridView_error.Columns[2].Name = "Raw_Price";
            dataGridView_error.Columns[3].Name = "Curent_price";
            dataGridView_error.Columns[4].Name = "Steam_price_?";

            dataGridView_full_info.ColumnCount = 8;
            dataGridView_full_info.Columns[0].Name = "Raw_Name";
            dataGridView_full_info.Columns[1].Name = "Curent_Name";
            dataGridView_full_info.Columns[2].Name = "Raw_Price";
            dataGridView_full_info.Columns[3].Name = "Curent_price";
            dataGridView_full_info.Columns[4].Name = "Steam_price";
            dataGridView_full_info.Columns[5].Name = "Profit_buy";
            dataGridView_full_info.Columns[6].Name = "Profit_sell";
            dataGridView_full_info.Columns[7].Name = "Link";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;

            int array_lenght = (int)numericUpDown_page_counter.Value * 56;/*every page have 56 items on it*/
            string[] steam_link_price = new string[array_lenght];
            string[] steam_link_price_err = new string[array_lenght];
            string[] steam_link = new string[array_lenght];
            double[] dmarket_price = new double[array_lenght];
            string[] dmarket_price_tmp = new string[array_lenght];
            string[] dmarket_name = new string[array_lenght];
            string[] dmarket_name_raw = new string[array_lenght];
            string[] dmarket_link = new string[array_lenght];
            double[] steam_item_price = new double[array_lenght];
            string[] steam_item_price_tmp = new string[array_lenght];
            double[] expected_price_steam = new double[array_lenght];
            double[] profit_buy = new double[array_lenght];
            double[] dmarket_max_price = new double[array_lenght];
            double[] steam_max_price = new double[array_lenght];

            double[] profit_sell = new double[array_lenght];
            bool[] is_correct = new bool[array_lenght];
            bool tmr;
            int i;
            int j;

            for (i = 0; i < array_lenght; i++)
            {
                steam_link_price[i] = "";
                steam_link_price_err[i] = "";
                steam_link[i] = "";
                dmarket_price[i] = 0;
                dmarket_price_tmp[i] = "";
                dmarket_name[i] = "";
                dmarket_name_raw[i] = "";
                dmarket_link[i] = "";
                steam_item_price[i] = 0;
                steam_item_price_tmp[i] = "";
                expected_price_steam[i] = 0;
                profit_buy[i] = 0;
                dmarket_max_price[i] = 0;
                steam_max_price[i] = 0;
                profit_sell[i] = 0;
            }

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string htmlCode;
            string[] input_html_line = File.ReadAllLines("dota2_market_html.txt");
            string error_direct = "error.txt";
            string dmarket_price_pattern = @"<div class=""price"">(((\d+\.\d+)|\d+)|((\d+ \d+)|(\d+ \d+\.\d+))) <small></small></div>";
            //string dmarket_link_pattern = @"<a class=""item hot"" href="" / item / 2588898078 - 1625510296 - Curious + Snaptrap / "">";
            string name_pattern = @"<div class=""name"" style=""color: ";
            string steam_price_pattern = @"{""success"":true,""lowest_price"":""((\d+\,\d+)|\d+)\\u20b4""";
            string too_many_requests_pattern = @"The remote server returned an error: \(429\) Too Many Requests.";

            /*var column1 = new DataGridViewColumn();
            dataGridView.Columns.Add(column1);
            column1.HeaderText = "Name";*/

            dataGridView_dmarket.Rows.Clear();
            dataGridView_steam.Rows.Clear();
            dataGridView_error.Rows.Clear();
            dataGridView_full_info.Rows.Clear();

            //Parsing prices
            i = 0;
            j = 450;
            bool x;
            for (int counter = 1; counter <= (int)numericUpDown_page_counter.Value; counter++)
            {
                x = true;
                do
                {
                    is_correct[i] = true;
                    if (Regex.Match(input_html_line[j], dmarket_price_pattern).Success == true)
                    {
                        dmarket_price_tmp[i] = Regex.Match(input_html_line[j], dmarket_price_pattern).Groups[1].Value;
                        dmarket_price_tmp[i] = dmarket_price_tmp[i].Replace(" ", "");
                        dmarket_price[i] = double.Parse(dmarket_price_tmp[i], System.Globalization.CultureInfo.InvariantCulture);
                        i++;
                    }
                    if (i == 56 * counter)//55
                    {
                        x = false;
                        j += 1040;//1040
                    }
                    j++;
                } while (x);
            }

            //Parsing names
            i = 0;
            j = 450;
            for (int counter = 1; counter <= (int)numericUpDown_page_counter.Value; counter++)
            {
                x = true;
                do
                {
                    if (Regex.Match(input_html_line[j], name_pattern).Success == true)
                    {
                        dmarket_name[i] = input_html_line[j + 1];
                        dmarket_name_raw[i] = dmarket_name[i];
                        i++;
                    }
                    if (i == 56 * counter)//55
                    {
                        x = false;
                        j += 1040;//1040
                    }
                    j++;
                } while (x);
            }

            int expected_number = 15;
            //Creating a link to the steam market and geting a price
            for (i = 0; i < array_lenght; i++)//56
            {
                //exception handling
                if (Regex.Match(dmarket_name[i], @"Насмешка").Success == true)
                {
                    dmarket_name[i] = dmarket_name[i].Replace("Насмешка", "Taunt");
                }
                if (Regex.Match(dmarket_name[i], @"Autographed").Success == true)
                {
                    dmarket_name[i] = dmarket_name[i].Replace("Autographed ", "");
                }
                /*if (Regex.Match(dmarket_name[i], @"Комментатор:").Success == true)
                {
                    dmarket_name[i] = dmarket_name[i].Replace("Комментатор:", "Announcer%3A");
                }коментатор turn it on one day*/

                //exclusion of items
                if (Regex.Match(dmarket_name[i], @"Fortunes's").Success == true)
                {
                    dmarket_name[i] = dmarket_name[i].Replace("Fortunes's", "Fortune's");
                }

                //absolute exception
                if (Regex.Match(dmarket_name[i], @"Genuine Weather ").Success == true ||
                    Regex.Match(dmarket_name[i], @"Карточка игрока: ").Success == true ||
                    Regex.Match(dmarket_name[i], @"Стиль интерфейса").Success == true ||
                    Regex.Match(dmarket_name[i], @"Rune").Success == true ||
                    Regex.Match(dmarket_name[i], @"\(").Success == true ||
                    Regex.Match(dmarket_name[i], @"Master Artificer's Hammer").Success == true ||
                    Regex.Match(dmarket_name[i], @"Artificer's Hammer").Success == true ||
                    Regex.Match(dmarket_name[i], @"Загрузочный экран").Success == true ||
                    Regex.Match(dmarket_name[i], @"Набор").Success == true ||
                    Regex.Match(dmarket_name[i], @"Комментатор:").Success == true /*колись прибрати*/ ||
                    Regex.Match(dmarket_name[i], @"Announcer:").Success == true /*колись прибрати*/ ||
                    Regex.Match(dmarket_name[i], @"Elder").Success == true ||
                    Regex.Match(dmarket_name[i], @"Unusual").Success == true ||
                    Regex.Match(dmarket_name[i], @"Heroic").Success == true ||
                    Regex.Match(dmarket_name[i], @"Inscribed").Success == true ||
                    Regex.Match(dmarket_name[i], @"Autographed Trove Carafe").Success == true ||
                    Regex.Match(dmarket_name[i], @"Cursed").Success == true ||
                    Regex.Match(dmarket_name[i], @"Рецепт").Success == true ||
                    Regex.Match(dmarket_name[i], @"Exalted").Success == true ||
                    Regex.Match(dmarket_name[i], @"Frozen").Success == true ||
                    Regex.Match(dmarket_name[i], @"Corrupted").Success == true ||
                    Regex.Match(dmarket_name[i], @"Auspicious").Success == true ||
                    Regex.Match(dmarket_name[i], @"Удачливый").Success == true ||
                    Regex.Match(dmarket_name[i], @"Infused").Success == true ||
                    Regex.Match(dmarket_name[i], @"Genuine Именной ярлык").Success == true ||
                    Regex.Match(dmarket_name[i], @"Genuine Ярлык для описания").Success == true ||
                    Regex.Match(dmarket_name[i], @"Genuine Классический значок:").Success == true ||
                    Regex.Match(dmarket_name[i], @"Genuine Значок:").Success == true ||
                    Regex.Match(dmarket_name[i], @"Комплект").Success == true ||
                    Regex.Match(dmarket_name[i], @"Грявол").Success == true ||
                    Regex.Match(dmarket_name[i], @"Новый стиль").Success == true ||
                    Regex.Match(dmarket_name[i], @"Смявол").Success == true ||
                    Regex.Match(dmarket_name[i], @"Taunt: Party On").Success == true ||
                    Regex.Match(dmarket_name[i], @"Мега-убийства:").Success == true ||
                    Regex.Match(dmarket_name[i], @"Кинетический").Success == true)
                {
                    dmarket_name[i] = "error";
                    //dmarket_name_raw[i] = dmarket_name[i];
                    dmarket_price[i] = 0;
                    is_correct[i] = false;
                }

                dmarket_name[i] = dmarket_name[i].Replace(":", "%3A");
                dmarket_name[i] = dmarket_name[i].Replace("!", "%21");
                dmarket_name[i] = dmarket_name[i].Replace("?", "%3F");
                dmarket_name[i] = dmarket_name[i].Replace("'", "%27");
                dmarket_name[i] = dmarket_name[i].Replace("«", "");
                dmarket_name[i] = dmarket_name[i].Replace("»", "");
                ///////////////
                if (is_correct[i] == true)
                {
                    //creating link with and download
                    steam_link_price[i] = ("https://steamcommunity.com/market/priceoverview/?currency=18&appid=570&market_hash_name=" + dmarket_name[i].Replace(" ", "%20"));
                    steam_link[i] = ("https://steamcommunity.com/market/listings/570/" + dmarket_name[i].Replace(" ", "%20"));
                    try
                    {
                        htmlCode = client.DownloadString(steam_link_price[i]);
                        if (Regex.Match(htmlCode, steam_price_pattern).Success == true)
                        {
                            steam_item_price_tmp[i] = Regex.Match(htmlCode, steam_price_pattern).Groups[1].Value;
                            steam_item_price_tmp[i] = steam_item_price_tmp[i].Replace(" ", "");
                            steam_item_price[i] = double.Parse(steam_item_price_tmp[i]);
                        }
                    }
                    catch(Exception ex)
                    {
                        tmr = true;
                        if(Regex.Match(ex.Message, too_many_requests_pattern).Success == true)
                        {
                            j = 0;
                            do
                            {
                                j++;
                                Thread.Sleep(1000);
                                try
                                {
                                    htmlCode = client.DownloadString(steam_link_price[i]);
                                    if (Regex.Match(htmlCode, steam_price_pattern).Success == true)
                                    {
                                        steam_item_price_tmp[i] = Regex.Match(htmlCode, steam_price_pattern).Groups[1].Value;
                                        steam_item_price_tmp[i] = steam_item_price_tmp[i].Replace(" ", "");
                                        steam_item_price[i] = double.Parse(steam_item_price_tmp[i]);
                                        tmr = false;
                                    }                                    
                                }
                                catch { }
                                if (j == 30)
                                {
                                    MessageBox.Show(
                                        "It's been 30 seconds since an error (429)\nPress 'ОК' to continue",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                                }
                                if (j == 40)
                                {
                                    MessageBox.Show(
                                        "It's been 40 seconds since an error (429)\nChange your VPN server\nPress 'ОК' to continue",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                                }
                                if (j == 100)
                                {
                                    MessageBox.Show(
                                        "It's been 100 seconds since an error (429)\nChange your VPN server\nPress 'ОК' to continue",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                                }
                                if (j == 200)
                                {
                                    MessageBox.Show(
                                        "It's been 200 seconds since an error (429)\nSomething went wrong\nPress 'ОК' to continue",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);
                                }
                            } while (tmr == true);
                        }
                        else
                        {
                            steam_item_price[i] = 0;
                            //Record of erroneous links
                            using (var writer = new StreamWriter(error_direct, true))
                            {
                                //adding an entry to old data
                                writer.WriteLine(dmarket_name[i] + " " + steam_link_price[i] + " " + ex.Message);
                            }
                        }
                    }
                    
                    if (i == expected_number)
                    {
                        Thread.Sleep(20000);
                        expected_number += 15;
                    }
                    label_counter.Text = i.ToString();
                    Thread.Sleep(1000);
                }
                //output of erroneous data
                else
                {
                    string[] row_error = new string[] { dmarket_name_raw[i], dmarket_name[i], dmarket_price_tmp[i], dmarket_price[i].ToString(), steam_item_price[i].ToString() };
                    dataGridView_error.Rows.Add(row_error);
                }
            }

            for (i = 0; i < array_lenght; i++)
            {
                //calculation
                if (steam_item_price[i] != 0 && dmarket_price[i] != 0)
                {
                    //whether to buy d_market
                    //the formula was created at the request of the customer
                    //profit is derived from the difference in prices in the two markets and the difference between currencies
                    expected_price_steam[i] = (dmarket_price[i] - (dmarket_price[i] * double.Parse(discount.Text))) / double.Parse(coef_buy.Text);
                    if (expected_price_steam[i] <= steam_item_price[i])
                    {
                        profit_buy[i] = steam_item_price[i] / expected_price_steam[i];
                        dmarket_max_price[i] = steam_item_price[i] * double.Parse(coef_buy.Text);
                        //dmarket_buy[i] = "true";

                        //Output information to the table for purchase on dmarket
                        string[] row_buy = new string[] { dmarket_name_raw[i], dmarket_price[i].ToString(), steam_item_price[i].ToString(), dmarket_max_price[i].ToString(), profit_buy[i].ToString(), steam_link[i] };
                        dataGridView_dmarket.Rows.Add(row_buy);
                    }
                    else
                    {
                        profit_buy[i] = 0;
                        //dmarket_buy[i] = "false";
                    }

                    //whether to sell in steam
                    //the formula was created at the request of the customer
                    //profit is derived from the difference in prices in the two markets and the difference between currencies
                    expected_price_steam[i] = (dmarket_price[i] - (dmarket_price[i] * double.Parse(discount.Text))) / double.Parse(coef_sell.Text);
                    if (steam_item_price[i] <= expected_price_steam[i])
                    {
                        profit_sell[i] = expected_price_steam[i] / steam_item_price[i];
                        steam_max_price[i] = profit_sell[i] * steam_item_price[i];

                        //Output information to the table for purchase in steam
                        string[] row_sell = new string[] { dmarket_name_raw[i], steam_item_price[i].ToString(), dmarket_price[i].ToString(), steam_max_price[i].ToString(), profit_sell[i].ToString(), steam_link[i] };
                        dataGridView_steam.Rows.Add(row_sell);
                    }
                    else
                    {
                        profit_sell[i] = 0;
                    }
                }
            }

            //output of all information
            for (i = 0; i < array_lenght; i++)
            {
                string[] row_full_info = new string[] { dmarket_name_raw[i], dmarket_name[i], dmarket_price_tmp[i],
                    dmarket_price[i].ToString(), steam_item_price[i].ToString(), profit_buy[i].ToString(),
                    profit_sell[i].ToString(), steam_link[i] };
                dataGridView_full_info.Rows.Add(row_full_info);
            }

            button_start.Visible = true;
            MessageBox.Show(
                "The program has completed its work\nPress 'ОК' to continue",
                "Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
