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
using System.Reflection;
namespace Rover
{
	/// <summary>
	/// Interaction logic for Info.xaml
	/// </summary>
	public partial class Info : Window
	{
		public Info()
		{
			InitializeComponent();
			Version.Content = Assembly.GetEntryAssembly().GetName().Version.ToString();
		}

		private void Close_click(object sender, RoutedEventArgs e)
		{
			Close();
		}
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
				this.DragMove();
		}
	}
}
