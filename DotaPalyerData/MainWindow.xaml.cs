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
using Domain;

namespace DotaPalyerData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private OpenDotaApi _api = new OpenDotaApi();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private async void searchButton_Click(object sender, RoutedEventArgs e)
        {
            long steamId = long.Parse(steamIDTextBox.Text);
            Player player = await _api.GetCurrentPlayerInfos(steamId);
            List<PlayerHero> topHeroes = await _api.GetTopHeroesForPlayer(steamId);

            if (player != null)
            {
                PlayerName.Text = player.Profile.Name;
                PlayerName.InvalidateVisual();
            }
            
            if (topHeroes != null)
            {
                topHeroesListView.Items.Clear();

                foreach (PlayerHero hero in topHeroes)
                {
                    topHeroesListView.Items.Add(hero);
                }
            }
            else
            {
                MessageBox.Show($"Impossible de récupérer les héros joués pour le joueur {steamId}");
            }
        }
    }
}