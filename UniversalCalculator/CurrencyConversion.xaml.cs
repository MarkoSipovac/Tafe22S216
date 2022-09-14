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
	public sealed partial class CurrencyConversion : Page
	{
		public CurrencyConversion()
		{
			this.InitializeComponent();
		}

		private void currencyoutput_Click(object sender, RoutedEventArgs e)
		{
			if (fromComboBox.SelectedItem.ToString() == "US Dollar")
			{
				if(toComboBox.SelectedItem.ToString() == "Euro")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num*0.85189982;
					output1.Text = output1ans.ToString() + " Euro";
				}
				if (toComboBox.SelectedItem.ToString() == "British")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 0.72872436;
					output1.Text = output1ans.ToString() + " British";
				}
				if (toComboBox.SelectedItem.ToString() == "Indian Rupee")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 74.257327;
					output1.Text = output1ans.ToString() + " Indian Rupee";
				}
			}
			if (fromComboBox.SelectedItem.ToString() == "Euro")
			{
				if (toComboBox.SelectedItem.ToString() == "US Dollar")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 1.1739732;
					output1.Text = output1ans.ToString() + " US Dollar";
				}
				if (toComboBox.SelectedItem.ToString() == "British")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 0.8556672;
					output1.Text = output1ans.ToString() + " British";
				}
				if (toComboBox.SelectedItem.ToString() == "Indian Rupee")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 87.00755;
					output1.Text = output1ans.ToString() + " Indian Rupee";
				}
			}
			if (fromComboBox.SelectedItem.ToString() == "British")
			{
				if (toComboBox.SelectedItem.ToString() == "US Dollar")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 1.371907;
					output1.Text = output1ans.ToString() + " US Dollar";
				}
				if (toComboBox.SelectedItem.ToString() == "Euro")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 1.1686692;
					output1.Text = output1ans.ToString() + " Euro";
				}
				if (toComboBox.SelectedItem.ToString() == "Indian Rupee")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 101.68635;
					output1.Text = output1ans.ToString() + " Indian Rupee";
				}
			}
			if (fromComboBox.SelectedItem.ToString() == "Indian Rupee")
			{
				if (toComboBox.SelectedItem.ToString() == "US Dollar")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 0.0011492628;
					output1.Text = output1ans.ToString() + " US Dollar";
				}
				if (toComboBox.SelectedItem.ToString() == "Euro")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 0.013492774;
					output1.Text = output1ans.ToString() + " Euro";
				}
				if (toComboBox.SelectedItem.ToString() == "British")
				{
					double num = Convert.ToDouble(amount_TextBox.Text);
					double output1ans = num * 0.0098339397;
					output1.Text = output1ans.ToString() + " British";
				}
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(BlankPage1));
		}
	}
}
