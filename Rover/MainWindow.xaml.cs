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
namespace Rover
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			if (!File.Exists(@".roverwelcome"))
			{
				Info info = new Info();
				info.Show();
				FileStream fs = File.Create(".roverwelcome", 1024);
			}
			InitializeComponent();


		}
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left)
				this.DragMove();
		}
		private void Window_Deactivated(object sender, EventArgs e)
		{
			Window window = (Window)sender;
			window.Topmost = true;
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
		private void Info_Click(object sender, RoutedEventArgs e)
		{
			Info info = new Info();
			info.Show();
		}
	}
}
