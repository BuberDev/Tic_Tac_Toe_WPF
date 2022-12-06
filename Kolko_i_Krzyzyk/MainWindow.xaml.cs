using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Kolko_i_Krzyzyk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bool IsPlayer1Turn { get; set; } = true;

        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
            


        }


        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;
            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background =Brushes.White;
            Button_1_0.Background =Brushes.White;
            Button_2_0.Background =Brushes.White;
            Button_0_1.Background =Brushes.White;
            Button_1_1.Background =Brushes.White;
            Button_2_1.Background =Brushes.White;
            Button_0_2.Background =Brushes.White;
            Button_1_2.Background =Brushes.White;
            Button_2_2.Background =Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // IsPlayer1Turn ^= true;  - the same code as that below
            if (IsPlayer1Turn)
                IsPlayer1Turn = false;
            else
                IsPlayer1Turn = true;

            var button = sender as Button;
            Counter++;

            if (Counter > 9) { 
                NewGame();
                return;
            }


            /*if (IsPlayer1Turn)
                button.Content = "0";
            else
                button.Content = "X"; */ //   The same code as that below
            button.Content = IsPlayer1Turn ? "O" : "X";


            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }

            
           
        }

        private bool CheckIfPlayerWon()
        {
            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content ==
                Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }


            if (Button_1_0.Content.ToString() != string.Empty && Button_1_0.Content == 
                Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }

            if (Button_2_0.Content.ToString() != string.Empty && Button_2_0.Content == 
                Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content ==
                Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }

            if (Button_0_1.Content.ToString() != string.Empty &&  Button_0_1.Content == 
                Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;
            }

            if (Button_0_2.Content.ToString() != string.Empty &&  Button_0_2.Content == 
                Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_0.Content.ToString() != string.Empty && Button_0_0.Content == 
                Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_2.Content.ToString() != string.Empty && Button_0_2.Content == 
                Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }

            return false;
        }

       

       


    }
}
