using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static DynamicList.App;

namespace DynamicList
{
    
 
    public partial class MainPage : ContentPage
	{
        List<string> _games;
  
        public MainPage()
		{
          InitializeComponent();

            _games = new List<string>();
            _games.Add("mono");
            _games.Add("monodroid");
            _games.Add("monotouch");
            _games.Add("monodevelop");
            _games.Add("monopoly");
            _games.Add("monorail");
            _games.Add("mononucleosis");
            _games.Add("mononucleosis");
            _games.Add("mononucleosis");
            _games.Add("mononucleosis");
            _games.Add("mononucleosis");

           //double intHeight = Window.Current.Bounds.Height;
           //double  intWidth = Window.Current.Bounds.Width;

            var _count = _games.Count;
            double nbr = ScreenWidth * 0.02 ;

            Grid grid = this.FindByName<Grid>("gridList");
            int _c = Convert.ToInt32(Math.Floor(nbr));
            for (int i = 0; i < _c; i++ )
            {            
                grid.Children.Add(new Label
                {
                    Text = _games[i],
                    Font = Font.BoldSystemFontOfSize(24),
                    HorizontalOptions = LayoutOptions.Start
                }, i, 0);
            }
  
            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            //  this.Content = grid;
       
		}
	}
}
