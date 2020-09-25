using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace Interface
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Client Client;

        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> listFlags = new List<string>();
            Console.WriteLine("entrou");

            ////Verificar checkBoxes
            //if (checkNsfw.IsChecked == true) listFlags.Add("nsfw");
            //if(checkPolitical.IsChecked == true) listFlags.Add("political");
            //if(checkRacist.IsChecked == true) listFlags.Add("racist");
            //if(checkSexist.IsChecked == true) listFlags.Add("sexist");
            //if(checkReligious.IsChecked == true) listFlags.Add("religious");

            ////Quantidade de virgulas
            //int countComma = listFlags.Count - 1;

            ////String builder
            //StringBuilder urlJokeApi = new StringBuilder();
            //urlJokeApi.Append("https://sv443.net/jokeapi/v2/joke/Any");

            ////Quantidade de flags
            //if (listFlags.Count > 0)
            //{
            //    //Acrescenta as flags selecionadas
            //    urlJokeApi.Append("?blacklistFlags=");
            //    foreach (var lf in listFlags)
            //    {
            //        urlJokeApi.Append(lf);
            //        if (countComma > 0)
            //        {
            //            urlJokeApi.Append(",");
            //            countComma--;
            //        }
            //    }
            //}
            //Client = new Client(urlJokeApi.ToString());
            //ViewData();
        }

        //newtonsoftjson

        private void ViewData()
        {
            var data = Client.StartHttpClientAsync();
            var Joke = Client.DeserializeJson(data.ToString());
        }
    }
}
