# How to apply OS level theme in .NET MAUI Applications for .NET MAUI DataGrid?
In this article, we will show you how to apply OS level theme in .NET MAUI Applications for [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## C#
The below code sets the visual theme of the application based on the system's light or dark mode. It listens for theme changes and applies the appropriate Syncfusion visual theme accordingly when the app appears or the system theme changes.
```
public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        if (Application.Current != null)
        {
            this.ApplyTheme(Application.Current.RequestedTheme);
            Application.Current.RequestedThemeChanged += OnRequestedThemeChanged;
        }
        base.OnAppearing();
    }

    private void OnRequestedThemeChanged(object? sender, AppThemeChangedEventArgs e)
    {
        this.ApplyTheme(e.RequestedTheme);
    }

    public void ApplyTheme(AppTheme appTheme)
    {
        if (Application.Current != null)
        {
            ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                var syncTheme = mergedDictionaries.OfType<SyncfusionThemeResourceDictionary>().FirstOrDefault();
                if (syncTheme != null)
                {
                    if (appTheme is AppTheme.Light)
                    {
                        syncTheme.VisualTheme = SfVisuals.MaterialLight;
                    }
                    else
                    {
                        syncTheme.VisualTheme = SfVisuals.MaterialDark;
                    }
                }
            }
        }
    }
}
```
 ![ThemeDemo.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI5Njg0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.7Q7ibX2r45DjahI9XMnWYKqotSPPui6vL9l8LJ0nSU8)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-Apply-OS-Level-Theme-in-.NET-MAUI-Applications-with-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to apply OS level theme in .NET MAUI Applications for .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!