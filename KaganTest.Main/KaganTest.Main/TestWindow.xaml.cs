using KaganTest.FileProcessing;
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

namespace KaganTest.Main
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        private FileWrapper newWrapper = new FileWrapper();
        private ExcelWrapper excelWrapper = new ExcelWrapper();
        private Test KagTest;

        int qNum = 0;
        int i;
        int score;

        public TestWindow()
        {
            InitializeComponent();

            KagTest = newWrapper.LoadTest();

            StartTest();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;

            if (img.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Correctly " + score + "/";

            NextQuestion();
        }

        private void RestartTest()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartTest(); 
        }

        private void NextQuestion2()
        {

        }

        private void NextQuestion()
        {

            foreach (var x in myGrid.Children.OfType<Image>())
            {
                x.Tag = "0";
            }


            switch (i)
            {
                case 1:

                    txtQuestion.Text = "Question 1";


                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));


                    break; 

                case 2:

                    txtQuestion.Text = "Question 2";


                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));


                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;

                case 3:

                    txtQuestion.Text = "Question 3";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));


                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));


                    break;

                case 4:

                    txtQuestion.Text = "Question 4";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;

                case 5:

                    txtQuestion.Text = "Question 5";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;
                case 6:

                    txtQuestion.Text = "Question 6";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));


                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;
                case 7:

                    txtQuestion.Text = "Question 7";

                    ans2.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;
                case 8:

                    txtQuestion.Text = "Question 8";

                    ans4.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;
                case 9:

                    txtQuestion.Text = "Question 9";

                    ans3.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;

                case 10:

                    txtQuestion.Text = "Question 10";

                    ans1.Tag = "1";

                    qImage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    ans1.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans2.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans3.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans4.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans5.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));
                    ans6.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/KaganTest.Images/1/1.jpg"));

                    break;
            }
        }

        private void StartTest()
        {
            var poolAnswers = new List<Image>(8);
            var rightAnswer = new Image() { Height = 200, Width = 200 };
            var rightEmpty = new Image() { Height = 200, Width = 200 };
            var leftEmpty = new Image() { Height = 200, Width = 200 };

            MyUniformGrid.Children.Add(leftEmpty);
            MyUniformGrid.Children.Add(rightAnswer);
            MyUniformGrid.Children.Add(rightEmpty);

            for (int i = 0; i < poolAnswers.Capacity; i++)
            {
                var Image = new Image();
                MyUniformGrid.Children.Add(Image);
                poolAnswers.Add(Image);
            }

            while (KagTest.IsCanGetNext)
            {
                var currentTest = KagTest.GetNext();
                for (int i = 0; i < currentTest.Answers.Count; i++)
                {
                    poolAnswers[i].Source = new BitmapImage(currentTest.Answers[i].PathToImage);
                }
                rightAnswer.Source = new BitmapImage(currentTest.RigthAnswerImagePath);
                Console.ReadLine();
            }

        }

        private Image GetImage(int imageIndex)
        {
            switch (imageIndex)
            {
                case 0:
                    return ans1;
                case 1:
                    return ans2;
                case 2:
                    return ans3;
                case 3:
                    return ans4;
                case 4:
                    return ans5;
                case 5:
                    return ans6;
                case 6:
                    return ans7;
                case 7:
                    return ans8;
            }

            throw new Exception();
        }
    }
}
