#pragma checksum "..\..\..\Ustawienia.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6685597B15D7FF5D366533C1B8E439B60A92D5E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using EKantor;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EKantor {
    
    
    /// <summary>
    /// Ustawienia
    /// </summary>
    public partial class Ustawienia : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Ustawienia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxNaPewnoReset;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Ustawienia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnResetuj;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Ustawienia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPowrot;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EKantor;component/ustawienia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ustawienia.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CheckBoxNaPewnoReset = ((System.Windows.Controls.CheckBox)(target));
            
            #line 11 "..\..\..\Ustawienia.xaml"
            this.CheckBoxNaPewnoReset.Checked += new System.Windows.RoutedEventHandler(this.CheckBoxNaPewnoReset_Checked);
            
            #line default
            #line hidden
            
            #line 11 "..\..\..\Ustawienia.xaml"
            this.CheckBoxNaPewnoReset.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBoxNaPewnoReset_Unchecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnResetuj = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\Ustawienia.xaml"
            this.btnResetuj.Click += new System.Windows.RoutedEventHandler(this.btnResetuj_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnPowrot = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\Ustawienia.xaml"
            this.btnPowrot.Click += new System.Windows.RoutedEventHandler(this.btnPowrot_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

