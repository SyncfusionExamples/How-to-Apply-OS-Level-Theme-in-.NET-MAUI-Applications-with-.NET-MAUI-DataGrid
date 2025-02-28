﻿using Syncfusion.Maui.Themes;

namespace SfDataGridSample
{
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

}
