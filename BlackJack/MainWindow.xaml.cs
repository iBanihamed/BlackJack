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
        public int dealerFakeCount = 0;
        public bool playerWin = false;
        public bool dealerWin = false;
        public bool gamedraw = false;
        public bool dealerHasAce = true;
        public bool playerHasAce = true;
        public int pot = 0;

        Card dealHiddenCard;
        Deck deck = new Deck();
        Player player1 = new Player("player1", 100); //create player with 100 dollars

        public MainWindow()
        {
            InitializeComponent();

            deck.Shuffle();

            //reset count of cards for next game
            playerCount = 0;
            dealerCount = 0;

            //reset winner
            playerWin = false;
            dealerWin = false;

            //Clear Table
            PlayerCards.Children.Clear();
            DealerCards.Children.Clear();

        }

        //Player Action Buttons***********************************************************************************************
        public void ButtonDeal_Click(object sender, RoutedEventArgs e)
        {
            deck.Shuffle();
            
            //reset count of cards for next game
            playerCount = 0;
            dealerCount = 0;

            //reset winner
            playerWin = false;
            dealerWin = false;
            gamedraw = false;

            //Clear Table
            PlayerCards.Children.Clear();
            DealerCards.Children.Clear();
            TextBlock_Draw.Visibility = Visibility.Collapsed;
            TextBlock_PlayerLoses.Visibility = Visibility.Collapsed;
            TextBlock_PlayerWins.Visibility = Visibility.Collapsed;

            //Deal Cards
            //deal face down card for dealer
            dealHiddenCard = deck.DealCard();
            dealerCount = dealerCount + dealHiddenCard.rank;
            Image hiddenCardImage = new Image();
            BitmapImage bci = new BitmapImage();
            bci.BeginInit();
            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "blue_back.png", UriKind.Relative);
            bci.EndInit();
            hiddenCardImage.Source = bci;
            ResizeImage(hiddenCardImage, 80, 160);
            DealerCards.Children.Add(hiddenCardImage);

            DealPlayer();
            DealDealer();
            DealPlayer();
        }
        
        //need to add condition that this wont occur unless cards are shuffled
        public void ButtonHit_Click(object sender, RoutedEventArgs e)
        {
            DealPlayer();
            if (playerCount == 21)
                DealerFlips();
            else if (playerCount > 21)
                checkWin();
        }

        public void ButtonHold_Click(object sender, RoutedEventArgs e)
        {
            DealerFlips();
        }
        //*********************************************************************************************************************

        //Card Image methods*****************************************************************************************************
        //get image for dealt card
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
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "2D.png", UriKind.Relative);
                            break;
                        case "Three":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "3D.png", UriKind.Relative);
                            break;
                        case "Four":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "4D.png", UriKind.Relative);
                            break;
                        case "Five":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "5D.png", UriKind.Relative);
                            break;
                        case "Six":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "6D.png", UriKind.Relative);
                            break;
                        case "Seven":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "7D.png", UriKind.Relative);
                            break;
                        case "Eight":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "8D.png", UriKind.Relative);
                            break;
                        case "Nine":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "9D.png", UriKind.Relative);
                            break;
                        case "Ten":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "10D.png", UriKind.Relative);
                            break;
                        case "Jack":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "JD.png", UriKind.Relative);
                            break;
                        case "Queen":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "QD.png", UriKind.Relative);
                            break;
                        case "King":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "KD.png", UriKind.Relative);
                            break;
                        case "Ace":
                            bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "AD.png", UriKind.Relative);
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
                    bci.UriSource = new Uri(@"C:\Users\banihi2\source\repos\BlackJack\BlackJack\Images\" + "red_back.png", UriKind.Relative);
                    break;
            }
            
            bci.EndInit();
            cardImage.Source = bci;
            ResizeImage(cardImage, 80, 160);
            return cardImage;
        }

        //resize image for panels
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
        //**************************************************************************************************************************

        public void DealerFlips()
        {
            DealerCards.Children.RemoveAt(0);
            DealerCards.Children.Add(GetCardImage(dealHiddenCard));
            if ((dealerCount <= 15)&& (dealerCount < playerCount)) {
                DealDealer();
                DealerFlips();
            }
            else
            {    
                checkWin();
            }
        }
        //deal card to player
        public void DealDealer()
        {
            Card dealerCard = deck.DealCard(); 
            //ace condition
            if(dealerCard.face == "Ace")
            {
                if(dealerCount == 10)
                {
                    dealerCard.rank = 11;
                }
                else if(dealerCount > 10)
                {
                    dealerCard.rank = 1;
                }
                else
                {
                    dealerCard.rank = 1;
                    dealerHasAce = true;
                }
            }
            dealerCount = dealerCard.rank + dealerCount;
            DealerCards.Children.Add(GetCardImage(dealerCard));
        }

        //deal card to dealer
        public void DealPlayer()
        {
            Card playerCard = deck.DealCard();
            //ace condition 
            if (playerCard.face == "Ace")
            {
                if (playerCount == 10)
                {
                    playerCard.rank = 11;
                }
                else if (playerCount > 10)
                {
                    playerCard.rank = 1;
                }
                else
                {
                    playerCard.rank = 11;
                    playerHasAce = true;
                }
            }
            playerCount = playerCard.rank + playerCount;
            PlayerCards.Children.Add(GetCardImage(playerCard));
        }

        //Betting actions****************************************************************************************************************
        public void ButtonBet1_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 1;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 2*1;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet2_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 2;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 4;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet3_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 3;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 6;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet4_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 4;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 8;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet5_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 5;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 10;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet6_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 6;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 12;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet7_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 7;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 14;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet8_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 8;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 16;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        public void ButtonBet9_Click(object sender, RoutedEventArgs e)
        {
            player1.Money = player1.Money - 9;
            TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
            pot = pot + 18;
            TextBlock_PotMoney.Text = "$" + pot.ToString();
        }
        //*******************************************************************************************************************************

        //method to check who won game
        public void checkWin()
        {
           if(playerCount > 21)
            {
                if (playerHasAce == false)
                {
                    dealerWin = true;
                    TextBlock_PlayerLoses.Visibility = Visibility.Visible;
                    pot = 0;
                    TextBlock_PotMoney.Text = "$" + pot.ToString();
                }
                else
                {
                    playerCount = playerCount - 10;
                    playerHasAce = false;
                }
            }
           else if (dealerCount > 21)
            {
                if (dealerHasAce == false)
                {
                    playerWin = true;
                    TextBlock_PlayerWins.Visibility = Visibility.Visible;
                    pot = 0;
                    TextBlock_PotMoney.Text = "$" + pot.ToString();
                }
                else
                {
                    dealerCount = dealerCount - 10;
                    playerHasAce = false;
                }
            }
           else if (dealerCount == playerCount)
            {
                gamedraw = true;
                TextBlock_Draw.Visibility = Visibility.Visible;
                pot = 0;
                TextBlock_PotMoney.Text = "$" + pot.ToString();
            }
           else if (dealerCount > playerCount)
            {
                dealerWin = true;
                TextBlock_PlayerLoses.Visibility = Visibility.Visible;
                pot = 0;
                TextBlock_PotMoney.Text = "$" + pot.ToString();
            }
           else 
            {
                playerWin = true;
                player1.Money = player1.Money + pot;
                TextBlock_PlayerMoney.Text = "$" + player1.Money.ToString();
                TextBlock_PlayerWins.Visibility = Visibility.Visible;
                pot = 0;
                TextBlock_PotMoney.Text = "$" + pot.ToString();
            }        
        }
    }
}
