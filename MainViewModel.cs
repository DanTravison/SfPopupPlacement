using Syncfusion.Maui.Popup;
using System.Net.Http.Headers;

namespace PopupMaui;

internal class MainViewModel
{
    static readonly List<PopupCommand> _commands =
    [
        new PopupCommand(PopupRelativePosition.AlignTop),
        new PopupCommand(PopupRelativePosition.AlignBottom),
        new PopupCommand(PopupRelativePosition.AlignToLeftOf),
        new PopupCommand(PopupRelativePosition.AlignToRightOf),
        new PopupCommand(PopupRelativePosition.AlignTopLeft),
        new PopupCommand(PopupRelativePosition.AlignTopRight),
        new PopupCommand(PopupRelativePosition.AlignBottomLeft),
        new PopupCommand(PopupRelativePosition.AlignBottomRight)
    ];

    public IEnumerable<PopupCommand> Commands
    {
        get;
    } = _commands;
}
