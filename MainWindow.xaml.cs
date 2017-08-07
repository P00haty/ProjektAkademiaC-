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

namespace DontAngryChineseMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Player[] player = { new Player(), new Player(), new Player(), new Player() };
        public MainWindow()
        {
            
            InitializeComponent();

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (chckIsHuman1.IsChecked == true || chckIsHuman2.IsChecked == true || chckIsHuman3.IsChecked == true ||
                chckIsHuman4.IsChecked == true)
            {
                if (chckIsPlaying1.IsChecked == true)
                    player[0].setPlayer(txtName1.Text, cmbColor1.Text, chckIsHuman1.IsChecked);
                if (chckIsPlaying2.IsChecked == true)
                    player[1].setPlayer(txtName2.Text, cmbColor2.Text, chckIsHuman2.IsChecked);
                if (chckIsPlaying3.IsChecked == true)
                    player[2].setPlayer(txtName3.Text, cmbColor3.Text, chckIsHuman3.IsChecked);
                if (chckIsPlaying4.IsChecked == true)
                    player[3].setPlayer(txtName4.Text, cmbColor4.Text, chckIsHuman4.IsChecked);
                
                
                StandardBoard Plansza = new StandardBoard(player);
                Plansza.Show();

                
                this.Close();
            }
            else
            {
                MessageBox.Show("Brak graczy ludzkich!");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void chckIsPlaying1_Checked(object sender, RoutedEventArgs e)
        {
            lblName1.IsEnabled = true;
            txtName1.IsEnabled = true;
            lblColor1.IsEnabled = true;
            cmbColor1.IsEnabled = true;
            chckIsHuman1.IsEnabled = true;
            player[0].IsPlaying = true;
        }

        private void chckIsPlaying2_Checked(object sender, RoutedEventArgs e)
        {
            lblName2.IsEnabled = true;
            txtName2.IsEnabled = true;
            lblColor2.IsEnabled = true;
            cmbColor2.IsEnabled = true;
            chckIsHuman2.IsEnabled = true;
            player[1].IsPlaying = true;
        }

        private void chckIsPlaying3_Checked(object sender, RoutedEventArgs e)
        {
            lblName3.IsEnabled = true;
            txtName3.IsEnabled = true;
            lblColor3.IsEnabled = true;
            cmbColor3.IsEnabled = true;
            chckIsHuman3.IsEnabled = true;
            player[2].IsPlaying = true;
        }

        private void chckIsPlaying4_Checked(object sender, RoutedEventArgs e)
        {
            lblName4.IsEnabled = true;
            txtName4.IsEnabled = true;
            lblColor4.IsEnabled = true;
            cmbColor4.IsEnabled = true;
            chckIsHuman4.IsEnabled = true;
            player[3].IsPlaying = true;
        }

        private void chckIsPlaying1_Unchecked(object sender, RoutedEventArgs e)
        {
            lblName1.IsEnabled = false;
            txtName1.IsEnabled = false;
            lblColor1.IsEnabled = false;
            cmbColor1.IsEnabled = false;
            chckIsHuman1.IsEnabled = false;
            player[0].IsPlaying = false;
        }

        private void chckIsPlaying2_Unchecked(object sender, RoutedEventArgs e)
        {
            lblName2.IsEnabled = false;
            txtName2.IsEnabled = false;
            lblColor2.IsEnabled = false;
            cmbColor2.IsEnabled = false;
            chckIsHuman2.IsEnabled = false;
            player[1].IsPlaying = false;
        }

        private void chckIsPlaying3_Unchecked(object sender, RoutedEventArgs e)
        {
            lblName3.IsEnabled = false;
            txtName3.IsEnabled = false;
            lblColor3.IsEnabled = false;
            cmbColor3.IsEnabled = false;
            chckIsHuman3.IsEnabled = false;
            player[2].IsPlaying = false;
        }

        private void chckIsPlaying4_Unchecked(object sender, RoutedEventArgs e)
        {
            lblName4.IsEnabled = false;
            txtName4.IsEnabled = false;
            lblColor4.IsEnabled = false;
            cmbColor4.IsEnabled = false;
            chckIsHuman4.IsEnabled = false;
            player[3].IsPlaying = false;
        }
    }
}
