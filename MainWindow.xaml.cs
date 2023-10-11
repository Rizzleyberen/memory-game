using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MemoryGame {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		// Hoeveel milliseconden de vorige frame duurde
		double deltaTime;
		// Houdt de deltaTime bij
		Stopwatch stopwatch = new();

		public MainWindow() {
			InitializeComponent();

			// Voert elke frame de update functie uit
			CompositionTarget.Rendering += Update;

			// Zet de grid grootte naar de huidige resolutie
			grid.Width = double.NaN;
			grid.Height = double.NaN;
		}

		public void Update(object? sender, EventArgs? e) {
			// Zorgt ervoor dat deltaTime de lengte is van de vorige frame
			deltaTime = stopwatch.Elapsed.TotalSeconds;
			stopwatch.Restart();
		}
	}
}
