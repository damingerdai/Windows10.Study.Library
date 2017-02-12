using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows10.Study.Library.Background;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Windows10.Study.Library.Core
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage Current;

        private List<Scenario> scenarios = new List<Scenario>()
        {
            new Scenario(){ Title="首页",ClassType=typeof(Windows10.Study.Library.View.FirstPage)},
            new Scenario(){ Title="C#基础学习",ClassType=typeof(Windows10.Study.Library.View.CsharpBasis)},
            new Scenario(){ Title="UWP学习",ClassType=typeof(Windows10.Study.Library.View.UWPPage)}
        };

        public List<Scenario> Scenarios { get { return scenarios; } }

        public MainPage()
        {
            this.InitializeComponent();
            Current = this;
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += MainPage_BackRequested;
        }

        private void MainPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if(contentFrame != null && contentFrame.CanGoBack)
            {
                e.Handled = true;
                contentFrame.GoBack();
            }
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = (splitView.IsPaneOpen) ? false : true;
        }

        private void PageBackRequested(object sender, BackRequestedEventArgs e)
        {
            if (contentFrame == null)
                return;
            if (contentFrame.CanGoBack)
            {
                e.Handled = true;
                contentFrame.GoBack();
            }
        }
       
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Populate the scenario list from the SampleConfiguration.cs file
            ScenarioControl.ItemsSource = scenarios;
            if (Window.Current.Bounds.Width < 640)
            {
                ScenarioControl.SelectedIndex = -1;
            }
            else
            {
                ScenarioControl.SelectedIndex = 0;
            }
        }

        private void ScenariosLinkClick(object sender, ItemClickEventArgs e)
        {
            Scenario scenario = e.ClickedItem as Scenario;
            if (scenario != null && scenario.ClassType != null)
                contentFrame.Navigate(scenario.ClassType);
            splitView.IsPaneOpen = false;
        }

        private void ScenarioControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox != null)
            {
                Scenario s = listBox.SelectedItems[0] as Scenario;
                if(s != null)
                {
                    contentFrame.Navigate(s.ClassType);
                    if (Window.Current.Bounds.Width < 640)
                    {
                        splitView.IsPaneOpen = false;
                    }
                }
            }
        }
    }
}
