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

namespace Week1_Exercises
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> AllBands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] genres = { "All", "Rock", "Pop", "Indie" };
            cbxGenre.ItemsSource = genres;
            cbxGenre.SelectedIndex = 0;

            // Create Rock Bands
            RockBand r1 = new RockBand() { BandName = "Fleetwood Mac", YearFormed = 1967, BandMembers = "Mick Fleetwood, John McVie, Christine McVie, Stevie Nicks, Mick Campbell, Neil Finn" };
            RockBand r2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = 1962, BandMembers = "Mick Jagger, Keith Richards, Ronnie Wood, Charlie Watts" };

            // Create Pop Bands
            PopBand p1 = new PopBand() { BandName = "The Beatles", YearFormed = 1960, BandMembers = "John Lennon, Paul McCartney, George Harrison, Ringo Starr" };
            PopBand p2 = new PopBand() { BandName = "Westlife", YearFormed = 1998, BandMembers = "Shane Filan, Markus Feehily, Kian Egan, Nicky Byrne" };

            // Create Indie Bands
            IndieBand i1 = new IndieBand() { BandName = "Arctic Monkeys", YearFormed = 2002, BandMembers = "Alex Turner, Jamie Cook, Matt Helders, Nick O'Malley" };
            IndieBand i2 = new IndieBand() { BandName = "The Killers", YearFormed = 2001, BandMembers = "Brandon Flowers, Dave Keuning, Mark Stoermer, Ronnie Vannucci Jr." };

            AllBands.Add(r1);
            AllBands.Add(r2);
            AllBands.Add(p1);
            AllBands.Add(p2);
            AllBands.Add(i1);
            AllBands.Add(i2);

            AllBands.Sort();

            lbxBands.ItemsSource = AllBands;
            //GetBands();
        }

        private void LbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lbxBands.SelectedItem != null)
            {
                Band selectedBand = lbxBands.SelectedItem as Band;

                tblkBandInfo.Text = $"Formed: {selectedBand.YearFormed}\n" + $"Members: {selectedBand.BandMembers}";
            }
        }

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cbxGenre.SelectedItem != null)
            {
                string selectedGenre = cbxGenre.SelectedItem as string;
                Band selectedBand = lbxBands.SelectedItem as Band;

                Band[] filteredBands = new Band[2];
                int counter = 0;

                switch(selectedGenre)
                {
                    case "All":
                        lbxBands.ItemsSource = AllBands;
                        break;

                    //case "Rock":
                        
                }
            }
        }

        /*private DateTime GetRandomDate(Band band, Random randomFactory)
        {
            DateTime startDate = new DateTime(band.YearFormed, 01, 01);
            DateTime endDate = new DateTime(2018, 09, 01);
            TimeSpan timeSpan = endDate - startDate;
            //TimeSpan newSpan = new TimeSpan(0, randomFactory.Next(0, 2019));
            DateTime newDate = startDate + newSpan;
        }*/

        /*private Band[] GetBands()
        {
            // Create Rock Bands
            RockBand r1 = new RockBand() { BandName = "Fleetwood Mac", YearFormed = 1967, BandMembers = "Mick Fleetwood, John McVie, Christine McVie, Stevie Nicks, Mick Campbell, Neil Finn" };
            RockBand r2 = new RockBand() { BandName = "The Rolling Stones", YearFormed = 1962, BandMembers = "Mick Jagger, Keith Richards, Ronnie Wood, Charlie Watts" };

            // Create Pop Bands
            PopBand p1 = new PopBand() { BandName = "The Beatles", YearFormed = 1960, BandMembers = "John Lennon, Paul McCartney, George Harrison, Ringo Starr" };
            PopBand p2 = new PopBand() { BandName = "Westlife", YearFormed = 1998, BandMembers = "Shane Filan, Markus Feehily, Kian Egan, Nicky Byrne" };

            // Create Indie Bands
            IndieBand i1 = new IndieBand() { BandName = "Arctic Monkeys", YearFormed = 2002, BandMembers = "Alex Turner, Jamie Cook, Matt Helders, Nick O'Malley" };
            IndieBand i2 = new IndieBand() { BandName = "The Killers", YearFormed = 2001, BandMembers = "Brandon Flowers, Dave Keuning, Mark Stoermer, Ronnie Vannucci Jr." };
        }*/
    }
}
