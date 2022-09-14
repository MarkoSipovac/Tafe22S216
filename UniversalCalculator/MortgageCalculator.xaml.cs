using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class BlankPage2 : Page
	{
		public BlankPage2()
		{
			this.InitializeComponent();
		}


		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			float P = float.Parse(principleTxtBox.Text);
			float months = float.Parse(monthsTxtBox.Text);
			float years = float.Parse(yearsTxtBox.Text);
			float yearInterest = float.Parse(yearInterestTxtBox.Text);
			float n = (years * 12) + months;
			float i = yearInterest / 12;
			float M;

			M = (float)(P *((i * Math.Pow(1 + i, n) / Math.Pow(1 + i, n - 1))));

			monthInterestTxtBox.Text = i.ToString();
			repaymentTxtBox.Text = M.ToString();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(BlankPage1));
		}
	}
}
