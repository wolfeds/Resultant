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
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;

namespace Resultant
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Ссылка на JSON
        private const string linkJSON = "http://phisix-api3.appspot.com/stocks.json";

        // Сток валюты
        private Stocks StocksCurrency = new Stocks();

        public MainWindow()
        {
            InitializeComponent();
            TimeSpan interval = new TimeSpan(0, 0, 15);
            CancellationToken ct = new CancellationToken();
            RunPeriodicallyAsync(TakeInfo, interval, ct);
             
        }

        //Подпрограмма, вызывающаяся каждые 15 сек.
        private async Task RunPeriodicallyAsync(Func<Task> func,  TimeSpan interval, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await func();
                await Task.Delay(interval, cancellationToken);
            }
        }

        private async Task TakeInfo()
        {
            using (var httpClient = new HttpClient())
            {
                var requestMessage = new HttpRequestMessage
                {
                    RequestUri = new Uri(linkJSON),
                    Method = HttpMethod.Get
                };
                var response = await httpClient.SendAsync(requestMessage);

                var result = response.Content.ReadAsStringAsync().Result;
                StocksCurrency = JsonConvert.DeserializeObject<Stocks>(result);
                textBlockToDateTime.Text = "Данные верны на: " + StocksCurrency.as_of.ToLocalTime();
                dataGrid.Items.Clear();
                foreach(Stock item in StocksCurrency.stock)
                {
                    StockForVision tempSt = new StockForVision();
                    tempSt.name = item.name;
                    tempSt.amount = Math.Round(item.price.amount,2);
                    tempSt.volume = item.volume;
                    dataGrid.Items.Add(tempSt);
                }
            }
                    
        }

        async private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            await TakeInfo();
        }
    }
}
