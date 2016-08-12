using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Acoord
{
    public partial class Test : ContentPage
    {
        public Test()
        {
            InitializeComponent();
            lstItems.HasUnevenRows = true;
            lstItems.ItemTemplate = new DataTemplate(typeof(MenuCell2));
            //
            lstItems.ItemsSource = new List<MenuItem2>
    {
        new MenuItem2(),
        new MenuItem2(),
        new MenuItem2(),
        new MenuItem2(),
    };
            lstItems.ItemTapped += lstItems_ItemTapped;
        }
        void cmdButton1_Clicked(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            //
            var objItems = lstItems.ItemsSource;
            //
            foreach (MenuItem2 objMenuItem in objItems)
            {
                int intNewCellHeight = objRandom.Next(80, 160);
                objMenuItem.CellHeight = intNewCellHeight;
                objMenuItem.Text = "Cell Height = " + intNewCellHeight.ToString();
            }
        }

        void lstItems_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            (e.Item as MenuItem2).CellHeight = 200;
        }

    }
}
