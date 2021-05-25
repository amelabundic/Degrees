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
using System.IO;

namespace WpfFajlovi12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string putanja = @"C:\Temp\Podaci.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonPrikazi_Click(object sender, RoutedEventArgs e)
        {
            string putanja ="C:\\Windows";
            string[] fajlovi = Directory.GetFiles(putanja);

            StringBuilder sb = new StringBuilder();

            foreach (string fajl in fajlovi)
            {
                sb.AppendLine(fajl);
            }
            TextBox1.Text = sb.ToString();
        }

        private void ButtonKreiraj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists(putanja))
                {
                    MessageBox.Show("Fajl vec postoji");
                }
                else
                {
                    using (FileStream fs = File.Create(putanja))
                    {
                        MessageBox.Show("Fajl kreiran");
                    }
                }
            }
            catch (Exception xcp)
            {

                MessageBox.Show(xcp.Message);
            }
        }

        private void ButtonObrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (File.Exists(putanja))
                {
                    File.Delete(putanja);
                    MessageBox.Show("Fajl obrisan");
                }
                else
                {
                    MessageBox.Show("Ne postoji fajl");
                }
            }
            catch (Exception xcp)
            {

                MessageBox.Show(xcp.Message);
            }
        }

        private void ButtonKopiraj_Click(object sender, RoutedEventArgs e)
        {
            string odrediste = @"C:\Temp\Kopija.txt";

            try
            {
                if (File.Exists(putanja))
                {
                    File.Copy(putanja, odrediste, true);
                    MessageBox.Show("Fajl kopiran");
                }
                else
                {
                    MessageBox.Show("Fajl ne postoji");
                }
               
            }
            catch (Exception xcp)
            {

                MessageBox.Show(xcp.Message);
            }
        }

        private void ButtonPrenesi_Click(object sender, RoutedEventArgs e)
        {
            string odrediste = @"C:\Temp\Prenesi.txt";

            try
            {
                if (File.Exists(putanja))
                {
                    File.Move(putanja, odrediste);
                    MessageBox.Show("Prenos izvrsen");
                }
                else
                {
                    MessageBox.Show("Fajl ne postoji");
                }
            }
            catch (Exception xcp)
            {

                MessageBox.Show(xcp.Message);
            }

        }

        private void ButtonWriteAllText_Click(object sender, RoutedEventArgs e)
        {
            string podaci = TextBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(podaci))
            {
                MessageBox.Show("Nije dozvoljeno cuvanje praznog sadrzaja");
            }
            else
            {
                File.WriteAllText(putanja, podaci);
                MessageBox.Show("Podaci sacuvani");
            }
        }

        private void ButtonReadAllText_Click(object sender, RoutedEventArgs e)
        {
            string podaci = File.ReadAllText(putanja);

            TextBox1.Text = podaci;
        }

        private void ButtonAppenAllText_Click(object sender, RoutedEventArgs e)
        {
            string podaci = Environment.NewLine + TextBox2.Text;

            File.AppendAllText(putanja, podaci);

            MessageBox.Show("Podaci dodati u fajl");
        }

        private void ButtonWriteAllLines_Click(object sender, RoutedEventArgs e)
        {
            string[] podaci = { "Linija1","Linija2,Linija3"};

            File.WriteAllLines(putanja, podaci);
            MessageBox.Show("Podaci sacuvani");
                
        }

        private void ButtonReadAllLines_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonReadAllLines_Click_1(object sender, RoutedEventArgs e)
        {
            string podaci = File.ReadAllText(putanja);
            TextBox1.Text = podaci[0];
        }
    }
}
