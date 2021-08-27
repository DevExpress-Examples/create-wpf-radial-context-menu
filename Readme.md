<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128640767/14.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T325071)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/RadialMenuExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/RadialMenuExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/RadialMenuExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/RadialMenuExample/MainWindow.xaml.vb))
* [TextBoxService.cs](./CS/RadialMenuExample/TextBoxService.cs) (VB: [TextBoxService.vb](./VB/RadialMenuExample/TextBoxService.vb))
* [ViewModel.cs](./CS/RadialMenuExample/ViewModel.cs) (VB: [ViewModel.vb](./VB/RadialMenuExample/ViewModel.vb))
<!-- default file list end -->
# How to: Create a Radial Context Menu


<p>This example shows how to assign a <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfBarsRadialContextMenutopic.aspx">RadialContextMenu</a> to a text box and initialize the menu with items.</p>
<p>To assign the <a href="https://documentation.devexpress.com/WPF/clsDevExpressXpfBarsRadialContextMenutopic.aspx">RadialContextMenu</a> to the text box, the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfBarsBarManager_DXContextMenutopic.aspx">BarManager.DXContextMenu</a> attached property is used.</p>
The radial menu displays three regular buttons (Copy, Cut and Paste) and one sub-menu (Select All) that provides access to two additional items (Clear and Select All). Commands are assigned to the buttons with the Command properties.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-radial-context-menu-t325071/14.2.4+/media/d84f3cf7-a3d1-11e5-80bf-00155d62480c.png"><br>The radial menu's DataContext is bound to the window's DataContext. This DataContext is set to a RadialContextMenuViewModel class descendant, which is automatically generated by the <strong>DevExpress.Mvvm.POCO.ViewModelSource</strong> object. This descendant automatically generates commands for all public methods in the RadialContextMenuViewModel class (the ClearSelectionCommand is generated for the ClearSelection method).

<br/>


