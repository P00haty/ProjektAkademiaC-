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
using System.Windows.Shapes;

namespace DontAngryChineseMan
{
    /// <summary>
    /// Interaction logic for StandardBoard.xaml
    /// </summary>
    public partial class StandardBoard : Window
    {
        private int RoundCount { get; set; }
        private Random die = new Random();
        private Player[] player { get; set; }
        // private Pawn[][] pawn { get; set; }

        public StandardBoard(Player[] player)
        {
            InitializeComponent();
            this.player = player;
            Settings();
        }

        private void Settings()
        {
            p1Name.Content = player[0].Name;
            p2Name.Content = player[1].Name;
            p3Name.Content = player[2].Name;
            p4Name.Content = player[3].Name;
            
            if (player[0].IsPlaying==true)
            {
                SolidColorBrush Player1Color = (SolidColorBrush)new BrushConverter().ConvertFromString(player[0].Color);
                f1.Fill = Pawn1_1.Fill = Pawn1_2.Fill = Pawn1_3.Fill = Pawn1_4.Fill = Player1Color;
                Pawn1_1.Visibility = Pawn1_2.Visibility = Pawn1_3.Visibility = Pawn1_4.Visibility = Visibility.Visible;
                f1.Opacity = 0.6;
            }
            if (player[1].IsPlaying == true)
            {
                SolidColorBrush Player2Color = (SolidColorBrush)new BrushConverter().ConvertFromString(player[1].Color);
                f11.Fill = Pawn2_1.Fill = Pawn2_2.Fill = Pawn2_3.Fill = Pawn2_4.Fill = Player2Color;
                Pawn2_1.Visibility = Pawn2_2.Visibility = Pawn2_3.Visibility = Pawn2_4.Visibility = Visibility.Visible;
                f11.Opacity = 0.6;
            }
            if (player[2].IsPlaying == true)
            {
                SolidColorBrush Player3Color = (SolidColorBrush)new BrushConverter().ConvertFromString(player[2].Color);
                f31.Fill = Pawn3_1.Fill = Pawn3_2.Fill = Pawn3_3.Fill = Pawn3_4.Fill = Player3Color;
                Pawn3_1.Visibility = Pawn3_2.Visibility = Pawn3_3.Visibility = Pawn3_4.Visibility = Visibility.Visible;
                f31.Opacity = 0.6;
            }
            if (player[3].IsPlaying == true)
            {
                SolidColorBrush Player4Color = (SolidColorBrush)new BrushConverter().ConvertFromString(player[3].Color);
                f21.Fill = Pawn4_1.Fill = Pawn4_2.Fill = Pawn4_3.Fill = Pawn4_4.Fill = Player4Color;
                Pawn4_1.Visibility = Pawn4_2.Visibility = Pawn4_3.Visibility = Pawn4_4.Visibility = Visibility.Visible;
                f21.Opacity = 0.6;
            }
            
        }

        private void btnDie_Click(object sender, RoutedEventArgs e)
        {
            int dieNumber=die.Next(1, 6);
            switch(dieNumber)
            {
                case 1:
                    imgDie.Source = new BitmapImage(new Uri("/DieNumbers/1.jpg", UriKind.Relative));
                    break;
                case 2:
                    imgDie.Source = new BitmapImage(new Uri("/DieNumbers/2.jpg", UriKind.Relative));
                    break;
                case 3:
                    imgDie.Source = new BitmapImage(new Uri("/DieNumbers/3.jpg", UriKind.Relative));
                    break;
                case 4:
                    imgDie.Source = new BitmapImage(new Uri("/DieNumbers/4.jpg", UriKind.Relative));
                    break;
                case 5:
                    imgDie.Source = new BitmapImage(new Uri("/DieNumbers/5.jpg", UriKind.Relative));
                    break;
                case 6:
                    imgDie.Source = new BitmapImage(new Uri("/DieNumbers/6.jpg", UriKind.Relative));
                    break;
            }
        }

    

        //private void RecruitPawns()
        //{
        //    for(int i=0;i<4;i++)
        //    {
        //        for(int j=0;j<4;j++)
        //        {
        //            pawn[i][j] = new Pawn(player[i]);
        //        }

        //    }
        //}
    }
}
