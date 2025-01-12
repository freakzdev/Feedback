namespace Feedback
{
  public class Message : StackLayout
  {

    // Components
    private readonly Image _icon = new()
    {
      HorizontalOptions = LayoutOptions.Center,
      VerticalOptions = LayoutOptions.Center,
      Margin = new Thickness(0, 0, 0, 5),
      IsVisible = false
    };
    private readonly Label _title = new()
    {
      HorizontalOptions = LayoutOptions.Center,
      VerticalOptions = LayoutOptions.Center,
      VerticalTextAlignment = TextAlignment.Center,
      HorizontalTextAlignment = TextAlignment.Center,
      IsVisible = false,
      TextColor = Color.FromArgb("#FF4d4d4d")
    };
    private readonly Label _description = new()
    {
      HorizontalOptions = LayoutOptions.Center,
      VerticalOptions = LayoutOptions.Center,
      VerticalTextAlignment = TextAlignment.Center,
      HorizontalTextAlignment = TextAlignment.Center,
      IsVisible = false,
      TextColor = Color.FromArgb("#FF808080")
    };

    // Size Bindable Property
    public static readonly BindableProperty SizeProperty = BindableProperty.Create(
        nameof(Size),
        typeof(double),
        typeof(Message),
        (double)100,
        propertyChanged: OnSizeChanged
    );

    public double Size
    {
      get => (double)GetValue(SizeProperty);
      set => SetValue(SizeProperty, value);
    }

    private static void OnSizeChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var control = (Message)bindable;
      control.SetSize();
    }

    // Type Bindable Property
    public static readonly BindableProperty TypeProperty = BindableProperty.Create(
        nameof(Type),
        typeof(FeedbackType),
        typeof(Message),
        FeedbackType.info,
        propertyChanged: OnTypeChanged
    );

    public FeedbackType Type
    {
      get => (FeedbackType)GetValue(TypeProperty);
      set => SetValue(TypeProperty, value);
    }

    private static void OnTypeChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var control = (Message)bindable;
      control.SetIcon();
    }

    // Title Bindable Property
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(Message),
        "",
        propertyChanged: OnTitleChanged
    );

    public string Title
    {
      get => (string)GetValue(TitleProperty);
      set => SetValue(TitleProperty, value);
    }

    private static void OnTitleChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var control = (Message)bindable;
      control.SetTitle();
    }

    // Description Bindable Property
    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
        nameof(Description),
        typeof(string),
        typeof(Message),
        "",
        propertyChanged: OnDescriptionChanged
    );

    public string Description
    {
      get => (string)GetValue(DescriptionProperty);
      set => SetValue(DescriptionProperty, value);
    }

    private static void OnDescriptionChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var control = (Message)bindable;
      control.SetDescription();
    }

    // IsVisible Bindable Property (Overwriting)
    public new static readonly BindableProperty IsVisibleProperty = BindableProperty.Create(
        nameof(IsVisible),
        typeof(bool),
        typeof(Message),
        false,
        propertyChanged: OnIsVisibleChanged
    );

    public new bool IsVisible
    {
      get => (bool)GetValue(IsVisibleProperty);
      set => SetValue(IsVisibleProperty, value);
    }

    private static void OnIsVisibleChanged(BindableObject bindable, object oldValue, object newValue)
    {
      var control = (Message)bindable;
      control.SetVisibility();
      control.IsVisible = (bool)newValue;
    }

    // Class constructor
    public Message()
    {
      Orientation = StackOrientation.Vertical;
      HorizontalOptions = LayoutOptions.Center;
      VerticalOptions = LayoutOptions.Center;
      Build();
    }


    // Component builder
    private void Build()
    {
      Children.Add(_icon);
      Children.Add(_title);
      Children.Add(_description);
      SetSize();
      SetIcon();
      SetTitle();
      SetDescription();
    }

    // Properties Setters
    private void SetSize()
    {
      _icon.WidthRequest = Size;
      _icon.HeightRequest = Size;
      _title.FontSize = Size * 0.2;
      _description.FontSize = Size * 0.14;
    }
    private void SetIcon()
    {
      _icon.Source = $"feedback_{Type}.png";
    }
    private void SetTitle()
    {
      _title.Text = Title;
    }
    private void SetDescription()
    {
      _description.Text = Description;
    }
    private async void SetVisibility()
    {
      await (IsVisible ? Show() : Hide());
    }

    // Visibility Tasks
    private async Task Show()
    {
      _icon.IsVisible = true;
      await _icon.ScaleTo(1.5, 250);
      await _icon.ScaleTo(0.6, 100);
      await _icon.ScaleTo(1, 80);

      if (!string.IsNullOrEmpty(Title))
      {
        await _title.ScaleTo(0.1, 0);
        _title.IsVisible = true;
        await _title.ScaleTo(1, 80);
      }

      if (!string.IsNullOrEmpty(Description))
      {
        await _description.ScaleTo(0.1, 0);
        _description.IsVisible = true;
        await _description.ScaleTo(1, 250);
      }
      HapticFeedback.Perform(HapticFeedbackType.LongPress);
    }

    private async Task Hide()
    {
      await _description.ScaleTo(0.1, 50);
      _description.IsVisible = false;
      await _title.ScaleTo(0.1, 100);
      _title.IsVisible = false;
      await _icon.ScaleTo(1.5, 250);
      await _icon.ScaleTo(0.1, 50);
      _icon.IsVisible = false;
      HapticFeedback.Perform(HapticFeedbackType.Click);
    }

  }
}