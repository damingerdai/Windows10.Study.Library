﻿#pragma checksum "D:\C#\Windows10.Study.Library\Windows10.Study.Library.Core\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35F00CC057CDD160881F858A0F64776C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Windows10.Study.Library.Core
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Windows10.Study.Library.Core.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj5;
            private global::Windows.UI.Xaml.Controls.ListView obj6;

            public MainPage_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::Windows10.Study.Library.Core.MainPage newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Windows10.Study.Library.Core.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Scenarios(obj.Scenarios, phase);
                        this.Update_Foot(obj.Foot, phase);
                    }
                }
            }
            private void Update_Scenarios(global::System.Collections.Generic.List<global::Windows10.Study.Library.Background.Scenario> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj5, obj, null);
                }
            }
            private void Update_Foot(global::System.Collections.Generic.List<global::Windows10.Study.Library.Background.Scenario> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.HeaderPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.splitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4:
                {
                    this.splitViewTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.ScenarioControl = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 108 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ScenarioControl).ItemClick += this.ScenarioControl_ItemClick;
                    #line default
                }
                break;
            case 6:
                {
                    this.FootScenario = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 117 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.FootScenario).ItemClick += this.FootScenario_ItemClick;
                    #line default
                }
                break;
            case 7:
                {
                    this.contentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 8:
                {
                    this.title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.Primitives.ToggleButton element9 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 82 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element9).Click += this.ToggleButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.Hamburger = (global::Windows.UI.Xaml.Controls.FontIcon)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

