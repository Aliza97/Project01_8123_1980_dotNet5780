﻿#pragma checksum "..\..\addHostingUnit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D12AC4684FFCFA84D7D5691C08C49A0C0686CCAABA5ECFE5C7CB1DECF80993E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using PLWPF;
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


namespace PLWPF {
    
    
    /// <summary>
    /// addHostingUnit
    /// </summary>
    public partial class addHostingUnit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 64 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HostingUnitKey;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Owner;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox HostingUnitName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Diary;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Area;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox subArea;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox persons;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\addHostingUnit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox kids;
        
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
            System.Uri resourceLocater = new System.Uri("/PLWPF;component/addhostingunit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\addHostingUnit.xaml"
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
            this.HostingUnitKey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Owner = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.HostingUnitName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Diary = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Area = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.subArea = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.persons = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.kids = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 83 "..\..\addHostingUnit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 87 "..\..\addHostingUnit.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Return_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

