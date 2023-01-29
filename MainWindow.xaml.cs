using System.Windows;
using System.Windows.Media;

namespace QuizApp
{

    public partial class MainWindow : Window
    {
        public int Score = 0, currentQS = 0;
        private bool isChecked = true;
        public char ans;
        public string Question;
        public string[] Options=new string[4];
        private static  readonly DataBase dataBase = new DataBase();
        private void firstTime()
        {
            dataBase.openConnection();
            string[] temp = dataBase.Question(++currentQS);
            Question = temp[0];
            ans = temp[1].Trim()[0];
            string[] tmp = dataBase.Options(currentQS);
            Options[0] = tmp[0];
            Options[1] = tmp[1];
            Options[2] = tmp[2];
            Options[3] = tmp[3];
            dataBase.closeConnection();
            QuestionBlock.Text = Question.Trim();
            OptionA.Content = Options[0].Trim();
            OptionB.Content = Options[1].Trim();
            OptionC.Content = Options[2].Trim();
            OptionD.Content = Options[3].Trim();
        }
        public MainWindow()
        {
            InitializeComponent();
            firstTime();
        }
        private void Next_QS(object sender, RoutedEventArgs e)
        {
            dataBase.openConnection();
            string[] temp = dataBase.Question(++currentQS);
            Question= temp[0];
            ans = temp[1].Trim()[0];
            string[] tmp = dataBase.Options(currentQS);
            Options[0]= tmp[0];
            Options[1]= tmp[1];
            Options[2]= tmp[2];
            Options[3]= tmp[3];
            dataBase.closeConnection();
            QuestionBlock.Text = Question.Trim();
            OptionA.Content = Options[0].Trim();
            OptionB.Content = Options[1].Trim();
            OptionC.Content = Options[2].Trim();
            OptionD.Content = Options[3].Trim();
            OptionA.Background = Brushes.Transparent;
            OptionB.Background = Brushes.Transparent;
            OptionC.Background = Brushes.Transparent;
            OptionD.Background = Brushes.Transparent;
            isChecked = true;
        }

        private void A(object sender, RoutedEventArgs e)
        {
            updatePage('A');
        }

        private void B(object sender, RoutedEventArgs e)
        {
            updatePage('B');
        }

        private void C(object sender, RoutedEventArgs e)
        {
            updatePage('C');
        }

        private void D(object sender, RoutedEventArgs e)
        {
            updatePage('D');
        }

        public void updatePage(char selected)
        {
            if (selected == ans && isChecked) Score++;
            isChecked = false;
            ScoreText.Text = Score.ToString().Trim();
            if (ans == 'A' || ans == 'a')
                OptionA.Background = Brushes.Green;
            if(ans=='B'||ans=='b')
                OptionB.Background = Brushes.Green;
            if (ans =='C'||ans=='c')
                OptionC.Background = Brushes.Green;
            if(ans=='D'||ans=='d')
                OptionD.Background = Brushes.Green;
        }
    }
}
