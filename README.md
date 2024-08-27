# SfPopupPlacement
Provides an example of a Syncfusion SfPopup placement at a point in a View.

I have two primary use cases for displaying a popup at a specific point in a view:

## 1: Provide a context menu for shapes on a drawing surface: 

The containing view uses a TapGestureRecognizer to detect the tap and displays a popup
with actions that are appropriate for the shape at that location.  

*NOTE:* The shapes are NOT derived from View so they can not be used as the RelativeView.

## 2: Provide a context menu for items in a container:
This is the generalization of use case 1.

If the contained item is a view and the container provides the ability to override creation
of the item's view, such as seen with SfListView's ItemsGenerator, the solution involves
adding a TapGestureRecognizer to the item's view.

However, this method does not scale well such as when using a TreeView or ListView to display
the contents of the file system.

## The Sample
The sample refactors the Syncfusion sample provided in the ticket and adds a 'context menu'
to the MainPage.

1: Displaying a popup at a specific point in a View - context menu on the MainPage
This is enabled by installing a TapGestureRecognizer on Page.ContentView in
the MainPage constructor.

The popup is displayed in MainPage.OnTapped.

Expected: The popup's upper-left corner is placed at the tap point.
Actual: The popup's lower-left corner is placed at the tap point.

This is the issue I'm trying to resolve.

My current implementation uses SfPopup.ShowAsync with an AbsoluteX, AbsoluteY, and PopupRelativePlacement.AlignTop.
I chose AlignTop because it does not require knowledge of the popup's height or width.

However, when I use AlignTop, the popup is actually displayed at AbsoluteX, AbsoluteY - (Popup Height).

The sample uses SfPopup.Show but I see the same behavior with SfPopup.ShowAsync.

2: Defining a button on a page that display an SfPopup relative to the containing MainPage
Like the previous Syncfusion example code, the buttons display a popup on the MainPage with an AbsoluteX = 30, 
AbsoluteY = 30, and a PopupRelativePlacement value.

The logic has been refactored into a Command class and a DataTemplate.
See PopupCommand.cs and PopupButtonTemplate in MainPage.xaml.






