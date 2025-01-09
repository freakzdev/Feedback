
using System.Diagnostics;
using System.Windows.Input;
using System.Reflection;

namespace Feedback
{
  public class Message : StackLayout
  {

    // Components
    private readonly Image _icon = new()
    {
      HorizontalOptions = LayoutOptions.Center,
      VerticalOptions = LayoutOptions.Center
    };
    private readonly Label _tag = new()
    {
      HorizontalOptions = LayoutOptions.Center,
      VerticalOptions = LayoutOptions.Center
    };

    // Class constructor
    public Message()
    {
      Orientation = StackOrientation.Vertical;
      HorizontalOptions = LayoutOptions.Center;
      VerticalOptions = LayoutOptions.Center;
      // Build();
      Children.Add(_icon);
      Children.Add(_tag);
      BuildIcon();
      BuildLabel();
    }


    // Components builder
    // private void Build()
    // {
    //   Children.Clear();
    //   Children.Add(_icon);
    //   Children.Add(_tag);

    // }
    private void BuildIcon()
    {

      _icon.Source = "error.png";
      _icon.WidthRequest = 100;
      _icon.HeightRequest = 100;
    }
    private void BuildLabel()
    {
      _tag.Text = "Hello World!";
    }

  }
}