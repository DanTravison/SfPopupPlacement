using Syncfusion.Maui.Popup;
using System.Runtime.CompilerServices;

namespace PopupMaui;

public partial class MainPage : ContentPage
{
    TapGestureRecognizer _gesture = new()
    {
        Buttons = ButtonsMask.Secondary
    };

    public MainPage()
    {
        BindingContext = new MainViewModel();
        _gesture.Tapped += OnTapped;
        InitializeComponent();
        base.Content.GestureRecognizers.Add(_gesture);
    }
    
    void OnTapped(object? sender, TappedEventArgs e)
    {
        if (sender is View view)
        {
            Point? point = e.GetPosition(view);
            if (point.HasValue)
            {
                var sfPopup = new SfPopup();
                sfPopup.PopupStyle.CornerRadius = 0;
                sfPopup.AbsoluteX = (int) Math.Round(point.Value.X);
                sfPopup.AbsoluteY = (int) Math.Round(point.Value.Y);
                sfPopup.RelativePosition = PopupRelativePosition.AlignTop;
                sfPopup.RelativeView = view;
                sfPopup.Show();
            }
        }
    }
}
