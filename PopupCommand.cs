using Syncfusion.Maui.Popup;
using System.Windows.Input;

namespace PopupMaui;

internal class PopupCommand : ICommand
{
    public PopupCommand(PopupRelativePosition relativePosition)
    {
        RelativePosition = relativePosition;
        Text = relativePosition.ToString();
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        if (parameter is View view)
        {
            var sfPopup = new SfPopup();
            sfPopup.PopupStyle.CornerRadius = 0;
            sfPopup.AbsoluteX = 30;
            sfPopup.AbsoluteY = 30;
            sfPopup.RelativePosition = RelativePosition;
            sfPopup.RelativeView = view;
            sfPopup.Show();
        }
    }

    public string Text
    {
        get;
    }

    public PopupRelativePosition RelativePosition
    {
        get;
    }

    public event EventHandler? CanExecuteChanged;
}
