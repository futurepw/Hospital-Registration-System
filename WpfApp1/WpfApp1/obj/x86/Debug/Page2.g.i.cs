﻿#pragma checksum "..\..\..\Page2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "50CEE4294EA1E07FC331708FBC61A671"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// Page2
    /// </summary>
    public partial class Page2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cardNo;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox balancebox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button query_btn;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox charge_amount_txtbox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox paid_textbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox change_texbox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button queryBtn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refund_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/医院挂号子系统;component/page2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Page2.xaml"
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
            this.cardNo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.balancebox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.query_btn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Page2.xaml"
            this.query_btn.Click += new System.Windows.RoutedEventHandler(this.query_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.charge_amount_txtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\Page2.xaml"
            this.charge_amount_txtbox.LostFocus += new System.Windows.RoutedEventHandler(this.charge_amount_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.paid_textbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Page2.xaml"
            this.paid_textbox.LostFocus += new System.Windows.RoutedEventHandler(this.paid_textbox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.change_texbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.queryBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Page2.xaml"
            this.queryBtn.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.refund_btn = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\Page2.xaml"
            this.refund_btn.Click += new System.Windows.RoutedEventHandler(this.refund_btn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

