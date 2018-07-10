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

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //accumulated value of cards
        public int playerCount = 0;
        public int dealerCount = 0;
        Deck deck = new Deck();

        public MainWindow()
        {
            InitializeComponent();

         
        }

        //Player Action Buttons
        public void ButtonDeal_Click(object sender, RoutedEventArgs e)
        {
            deck.Shuffle();
            
            //reset count of cards for next game
            playerCount = 0;
            dealerCount = 0;

        }
        
        //need to add condition that this wont occur unless cards are shuffled
        public void ButtonHit_Click(object sender, RoutedEventArgs e)
        {
            
            PlayerCards.Children.Add(GetCardImage(deck.DealCard()));
            

        }

        public void ButtonHold_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public Image GetCardImage(Card card)
        {
            Image cardImage = new Image();
            BitmapImage bci = new BitmapImage();
            bci.BeginInit();
                    
            switch (card.suit)
            {
                case "Heart":
                    switch (card.face)
                    {
                    case "Two":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "2H.png", UriKind.Relative);
                            break;
                    case "Three":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "3H.png", UriKind.Relative);
                            break;
                    case "Four":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "4H.png", UriKind.Relative);
                            break;
                    case "Five":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "5H.png", UriKind.Relative);
                            break;
                    case "Six":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "6H.png", UriKind.Relative);
                            break;
                    case "Seven":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "7H.png", UriKind.Relative);
                            break;
                    case "Eight":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "8H.png", UriKind.Relative);
                            break;
                    case "Nine":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "9H.png", UriKind.Relative);
                            break;
                    case "Ten":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "10H.png", UriKind.Relative);
                            break;
                    case "Jack":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "JH.png", UriKind.Relative);
                            break;
                    case "Queen":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "QH.png", UriKind.Relative);
                            break;
                    case "King":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "KH.png", UriKind.Relative);
                            break;
                    case "Ace":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "AH.png", UriKind.Relative);
                            break;
                    default:
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "blue_back.png", UriKind.Relative);
                            break;
                    }
                    break;

                case "Clover":
                    switch (card.face)
                    {
                        case "Two":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "2H.png", UriKind.Relative);
                            break;
                        case "Three":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "3H.png", UriKind.Relative);
                            break;
                        case "Four":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "4H.png", UriKind.Relative);
                            break;
                        case "Five":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "5H.png", UriKind.Relative);
                            break;
                        case "Six":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "6H.png", UriKind.Relative);
                            break;
                        case "Seven":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "7H.png", UriKind.Relative);
                            break;
                        case "Eight":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "8H.png", UriKind.Relative);
                            break;
                        case "Nine":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "9H.png", UriKind.Relative);
                            break;
                        case "Ten":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "10H.png", UriKind.Relative);
                            break;
                        case "Jack":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "JH.png", UriKind.Relative);
                            break;
                        case "Queen":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "QH.png", UriKind.Relative);
                            break;
                        case "King":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "KH.png", UriKind.Relative);
                            break;
                        case "Ace":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "AH.png", UriKind.Relative);
                            break;
                        default:
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "blue_back.png", UriKind.Relative);
                            break;
                    }
                    break;

                case "Diamond":
                    switch (card.face)
                    {
                        case "Two":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "2H.png", UriKind.Relative);
                            break;
                        case "Three":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "3H.png", UriKind.Relative);
                            break;
                        case "Four":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "4H.png", UriKind.Relative);
                            break;
                        case "Five":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "5H.png", UriKind.Relative);
                            break;
                        case "Six":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "6H.png", UriKind.Relative);
                            break;
                        case "Seven":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "7H.png", UriKind.Relative);
                            break;
                        case "Eight":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "8H.png", UriKind.Relative);
                            break;
                        case "Nine":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "9H.png", UriKind.Relative);
                            break;
                        case "Ten":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "10H.png", UriKind.Relative);
                            break;
                        case "Jack":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "JH.png", UriKind.Relative);
                            break;
                        case "Queen":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "QH.png", UriKind.Relative);
                            break;
                        case "King":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "KH.png", UriKind.Relative);
                            break;
                        case "Ace":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "AH.png", UriKind.Relative);
                            break;
                        default:
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "blue_back.png", UriKind.Relative);
                            break;
                    }
                    break;

                case "Spade":
                    switch (card.face)
                    {
                        case "Two":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "2S.png", UriKind.Relative);
                            break;
                        case "Three":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "3S.png", UriKind.Relative);
                            break;
                        case "Four":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "4S.png", UriKind.Relative);
                            break;
                        case "Five":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "5S.png", UriKind.Relative);
                            break;
                        case "Six":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "6S.png", UriKind.Relative);
                            break;
                        case "Seven":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "7S.png", UriKind.Relative);
                            break;
                        case "Eight":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "8S.png", UriKind.Relative);
                            break;
                        case "Nine":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "9S.png", UriKind.Relative);
                            break;
                        case "Ten":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "10S.png", UriKind.Relative);
                            break;
                        case "Jack":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "JS.png", UriKind.Relative);
                            break;
                        case "Queen":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "QS.png", UriKind.Relative);
                            break;
                        case "King":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "KS.png", UriKind.Relative);
                            break;
                        case "Ace":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "AS.png", UriKind.Relative);
                            break;
                        default:
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "blue_back.png", UriKind.Relative);
                            break;
                    }
                    break;


                default:
                    bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "blue_back.png", UriKind.Relative);
                    break;
            }
            
            bci.EndInit();
            cardImage.Source = bci;
            ResizeImage(cardImage, 100, 150);
            return cardImage;
        }

        private void ResizeImage(Image img, double maxWidth, double maxHeight)
        {
            double resizeWidth = img.Source.Width;
            double resizeHeight = img.Source.Height;

            double aspect = resizeWidth / resizeHeight;

            if (resizeWidth > maxWidth)
            {
                resizeWidth = maxWidth;
                resizeHeight = resizeWidth / aspect;
            }
            if (resizeHeight > maxHeight)
            {
                aspect = resizeWidth / resizeHeight;
                resizeHeight = maxHeight;
                resizeWidth = resizeHeight * aspect;
            }

            img.Width = resizeWidth;
            img.Height = resizeHeight;
        }

    }
}
