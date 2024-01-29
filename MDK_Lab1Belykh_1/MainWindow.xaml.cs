using MDK_Lab1Belykh_1.Model;
using System;
using System.Windows;


namespace MDK_Lab1Belykh_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Date date;
        private Time time;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void TimeAddOneSec(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = "0:0:0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
            time.AddOne();
            TimeField.Text = time.Print();
        }

        private void HowManySeconds(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                MessageBox.Show($"Всего {time.ToSeconds()} секунд");
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                MessageBox.Show($"Всего {time.ToSeconds()} секунд");
            }
        }

        private void HowManyMinutes(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                MessageBox.Show($"Всего {time.ToMinutes()} минут");
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                MessageBox.Show($"Всего {time.ToMinutes()} минут");
            }

        }

        private void AddSeconds(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                time.AddSeconds(Convert.ToInt32(AddSecondField.Text));
                TimeField.Text = time.Print();
            }
            catch (Exception)
            {
                time = new Time();   
                TimeField.Text = time.Print();
                AddSecondField.Text = "0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void SubSeconds(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                time.SubSeconds(Convert.ToInt32(SubSecondField.Text));
                TimeField.Text = time.Print();
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
                SubSecondField.Text = "0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void SubTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);   
                Time otherTime = new Time(SubTimeField.Text);
                MessageBox.Show($"Разница в {time.TimeSub(otherTime)}");
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void IsMoreTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(СompareTimeField.Text);
                if (time.IsMore(otherTime))
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void IsLessTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(СompareTimeField.Text);
                if (time.IsLess(otherTime))
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void IsEqualTime(object sender, RoutedEventArgs e)
        {
            try
            {
                time = new Time(TimeField.Text);
                Time otherTime = new Time(СompareTimeField.Text);
                if (time.IsEqual(otherTime))
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                time = new Time();
                TimeField.Text = time.Print();
            }
        }

        private void DateAddOneDay(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
            }
            catch (Exception)
            {
                date = new Date();
                DateField.Text = "01.01.2000";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
            date.AddOne();
            DateField.Text = date.Print();
        }

        private void IsLeap(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                string prefix = date.IsLeapYear() ? "" : "НЕ ";
                MessageBox.Show($"Год {prefix}является високосным");
            }
            catch (Exception)
            {
                date = new Date();
                DateField.Text = date.Print();
            }
        }

        private void AddDays(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                date.AddDays(Convert.ToInt32(DaysToAddField.Text));
                DateField.Text = date.Print();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                date = new Date();   
                DateField.Text = date.Print();
                DaysToAddField.Text = "0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void SubDays(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                date.SubDays(Convert.ToInt32(DaysToSubField.Text));
                DateField.Text = date.Print();
            }
            catch (Exception)
            {
                date = new Date();   
                DateField.Text = date.Print();
                DaysToSubField.Text = "0";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void SubDate(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                Date otherDate = new Date(DateToSubField.Text);
                MessageBox.Show($"Разница в {date.DiffBetweenDays(otherDate)} дней");
            }
            catch (Exception)
            {
                date = new Date();   
                DateField.Text = date.Print();
                DaysToAddField.Text = "01.01.2000";
                MessageBox.Show("Неверные данные\n" +
                                "Установлено значение по умолчанию");
            }
        }

        private void IsMoreDate(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                Date otherDate = new Date(CompareDateField.Text);
                if (date.IsMore(otherDate))
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                date = new Date();
                DateField.Text = date.Print();
            }
        }
        
        private void IsLessDate(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                Date otherDate = new Date(CompareDateField.Text);
                if (date.IsLess(otherDate))
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                date = new Date();
                DateField.Text = date.Print();
            }
        }

        private void IsEqualDate(object sender, RoutedEventArgs e)
        {
            try
            {
                date = new Date(DateField.Text);
                Date otherDate = new Date(CompareDateField.Text);
                if (date.IsEqual(otherDate))
                {
                    MessageBox.Show("Да");
                }
                else
                {
                    MessageBox.Show("Нет");
                }
            }
            catch (Exception)
            {
                date = new Date();
                DateField.Text = date.Print();
            }
        }
    }
}