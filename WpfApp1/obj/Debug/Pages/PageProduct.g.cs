﻿#pragma checksum "..\..\..\Pages\PageProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B18DCFF60BF039EF542B59E2C453A2BD8E6BB1F46B1043B81AD866B8FD603DD3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using WpfApp1.Pages;


namespace WpfApp1.Pages {
    
    
    /// <summary>
    /// PageProduct
    /// </summary>
    public partial class PageProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtSearch;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListProduct;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbAsk;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RbDesk;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\Pages\PageProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdList;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/pages/pageproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageProduct.xaml"
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
            this.TxtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ListProduct = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.RbAsk = ((System.Windows.Controls.RadioButton)(target));
            
            #line 102 "..\..\..\Pages\PageProduct.xaml"
            this.RbAsk.IsMouseCapturedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.RbAsk_IsMouseCapturedChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RbDesk = ((System.Windows.Controls.RadioButton)(target));
            
            #line 104 "..\..\..\Pages\PageProduct.xaml"
            this.RbDesk.IsMouseCapturedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.RbDesk_IsMouseCapturedChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Pages\PageProduct.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.BtnDel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.grdList = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 83 "..\..\..\Pages\PageProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 87 "..\..\..\Pages\PageProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnHistory_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
