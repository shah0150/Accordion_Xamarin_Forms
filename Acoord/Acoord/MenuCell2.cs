using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Acoord
{
    public class MenuCell2 : ViewCell
    {
        public MenuCell2()
        {
            Label objLabel = new Label
            {
                YAlign = TextAlignment.Center,
                TextColor = Color.Yellow,
            };
            objLabel.SetBinding(Label.TextProperty, new Binding("Text"));


            StackLayout objLayout = new StackLayout
            {
                Padding = new Thickness(20, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { objLabel }
            };

            Frame objFrame_Inner = new Frame
            {
                Padding = new Thickness(15, 15, 15, 15),
                HeightRequest = 36,
                OutlineColor = Color.Accent,
                BackgroundColor = Color.Blue,
                Content = objLayout,
            };

            Frame objFrame_Outer = new Frame
            {
                Padding = new Thickness(0, 0, 0, 10),
                Content = objFrame_Inner
            };

            View = objFrame_Outer;

            this.BindingContextChanged += MenuCell2_BindingContextChanged;
        }

        void MenuCell2_BindingContextChanged(object sender, EventArgs e)
        {
            MenuItem2 objMenuItem = (MenuItem2)this.BindingContext;
            objMenuItem.PropertyChanged += objMenuItem_PropertyChanged;
        }

        void objMenuItem_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "CellHeight":
                    this.Height = (this.BindingContext as MenuItem2).CellHeight;
                    (this.View as Frame).ForceLayout();
                    break;
            }
        }
    }
}
