// Updated by XamlIntelliSenseFileGenerator 09.05.2020 04:03:07
#pragma checksum "..\..\..\Views\SettingsWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75A11FD539FA16112D4390021356992284C96DF5391ACE70BD1FDC6D98AA8363"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using EasyBot.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EasyBot.Views
{


    /// <summary>
    /// SettingsWindow
    /// </summary>
    public partial class SettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 19 "..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Loops;

#line default
#line hidden


#line 24 "..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Delay;

#line default
#line hidden


#line 37 "..\..\..\Views\SettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Save;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EasyBot;component/views/settingswindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Views\SettingsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.TextBox_Loops = ((System.Windows.Controls.TextBox)(target));

#line 19 "..\..\..\Views\SettingsWindow.xaml"
                    this.TextBox_Loops.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_Numbers_Only);

#line default
#line hidden
                    return;
                case 2:
                    this.TextBox_Delay = ((System.Windows.Controls.TextBox)(target));

#line 24 "..\..\..\Views\SettingsWindow.xaml"
                    this.TextBox_Delay.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBox_Numbers_Only);

#line default
#line hidden
                    return;
                case 3:
                    this.Button_Save = ((System.Windows.Controls.Button)(target));

#line 37 "..\..\..\Views\SettingsWindow.xaml"
                    this.Button_Save.Click += new System.Windows.RoutedEventHandler(this.Button_Save_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.Button_Delete = ((System.Windows.Controls.Button)(target));

#line 39 "..\..\..\Views\SettingsWindow.xaml"
                    this.Button_Delete.Click += new System.Windows.RoutedEventHandler(this.Button_Delete_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

