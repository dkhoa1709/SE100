﻿#pragma checksum "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1964866436D14DA2414600BF9C0A34165014C038DB0597CE1B67A9237DC83DF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyTraiHeo;
using QuanLyTraiHeo.ViewModel;
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
using System.Windows.Interactivity;
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


namespace FarmManagementSoftware.View.Windows {
    
    
    /// <summary>
    /// QuanLyThongTinCaTheWindow
    /// </summary>
    public partial class QuanLyThongTinCaTheWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MinDay;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtp_DateMin;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtp_DateMax;
        
        #line default
        #line hidden
        
        
        #line 181 "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txt_TimMaTen;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listviewHeo;
        
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
            System.Uri resourceLocater = new System.Uri("/FarmManagementSoftware;component/view/windows/qu%e1%ba%a3n%20l%c3%bd%20%c4%91%c3" +
                    "%a0n%20heo/quanlythongtincathewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Windows\Quản lý đàn heo\QuanLyThongTinCaTheWindow.xaml"
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
            this.MinDay = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.dtp_DateMin = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.dtp_DateMax = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Txt_TimMaTen = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.listviewHeo = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

