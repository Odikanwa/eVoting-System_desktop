﻿#pragma checksum "..\..\RegisterParty_page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F91D9EEE14F9EE541A6081CAFDD2AD6CE3B2FCB07D2B895565F56EC5F9D620B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using E_voting_Nigeria;
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


namespace E_voting_Nigeria {
    
    
    /// <summary>
    /// RegisterParty_page
    /// </summary>
    public partial class RegisterParty_page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image party_logo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox party_name;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox party_abbreviation;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox head_office;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox party_slogan;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox party_mission;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox party_vision;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\RegisterParty_page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button enroll_party_button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/E_voting_Nigeria;component/registerparty_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RegisterParty_page.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.party_logo = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.party_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.party_abbreviation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.head_office = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.party_slogan = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.party_mission = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.party_vision = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.enroll_party_button = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\RegisterParty_page.xaml"
            this.enroll_party_button.Click += new System.Windows.RoutedEventHandler(this.Enroll_party_button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
