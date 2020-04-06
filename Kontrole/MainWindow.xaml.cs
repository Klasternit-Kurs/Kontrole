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

namespace Kontrole
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Dictionary<Nesto, int> NekiRecink = new Dictionary<Nesto, int>();
		Dictionary<string, int> DrugiRecnik = new Dictionary<string, int>();
		
		public MainWindow()
		{
			InitializeComponent();
			/*var n = new Nesto("Prvo nesto");
			NekiRecink.Add(n, 10);
			NekiRecink.Add(new Nesto("Drugo nesto"), 15);
			NekiRecink.Add(new Nesto("Trece nesto"), 23);

			cmbbox.ItemsSource = NekiRecink.Keys;
			//cmbbox.SelectedIndex = 0;
			cmbbox.SelectedItem = n;*/

			DrugiRecnik.Add("Prvi", 1);
			DrugiRecnik.Add("Drugi", 2);
			DrugiRecnik.Add("Treci", 3);

			cmbbox.ItemsSource = DrugiRecnik.Keys;
			cmbbox.SelectedItem = "Prvi";


		}

		private void Promena(object sender, SelectionChangedEventArgs e)
		{
			if (cmbbox.SelectedItem != null)
			{
				lbl.Content = DrugiRecnik[cmbbox.SelectedItem.ToString()];
			}
		}
	}

	public class Nesto
	{
		public string Naziv { get; set; }
		public Nesto() { }
		public Nesto(string n)
		{
			Naziv = n;
		}

		public override string ToString() => Naziv;
		
	}
}
