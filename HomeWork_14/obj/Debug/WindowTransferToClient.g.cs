﻿#pragma checksum "..\..\WindowTransferToClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDE58C497C07B383F83108875995265E6559AAAA840FE3C6B6457662955F7BBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using HomeWork_14;
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


namespace HomeWork_14 {
    
    
    /// <summary>
    /// WindowTransferToClient
    /// </summary>
    public partial class WindowTransferToClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\WindowTransferToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCurrentBankAccounts;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\WindowTransferToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbClients;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\WindowTransferToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbClientBankAccounts;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WindowTransferToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbSum;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\WindowTransferToClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slSum;
        
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
            System.Uri resourceLocater = new System.Uri("/HomeWork_14;component/windowtransfertoclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WindowTransferToClient.xaml"
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
            
            #line 13 "..\..\WindowTransferToClient.xaml"
            ((HomeWork_14.WindowTransferToClient)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowTransferToClient_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbCurrentBankAccounts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\WindowTransferToClient.xaml"
            this.cbCurrentBankAccounts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbCurrentBankAccounts_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbClients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\WindowTransferToClient.xaml"
            this.cbClients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbClients_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cbClientBankAccounts = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\WindowTransferToClient.xaml"
            this.cbClientBankAccounts.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CbClientBankAccounts_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.slSum = ((System.Windows.Controls.Slider)(target));
            
            #line 59 "..\..\WindowTransferToClient.xaml"
            this.slSum.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slSum_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 63 "..\..\WindowTransferToClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Transfer);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 67 "..\..\WindowTransferToClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseWindow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
