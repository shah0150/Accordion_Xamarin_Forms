using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace Acoord
{
  public  class MenuItem2 : BindableObject
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create<MenuItem2, string>(p => p.Text, default(string));
        public static readonly BindableProperty CellHeightProperty = BindableProperty.Create<MenuItem2, int>(p => p.CellHeight, default(int));


        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public int CellHeight
        {
            get { return (int)GetValue(CellHeightProperty); }
            set { SetValue(CellHeightProperty, value); }
        }
    }
}
