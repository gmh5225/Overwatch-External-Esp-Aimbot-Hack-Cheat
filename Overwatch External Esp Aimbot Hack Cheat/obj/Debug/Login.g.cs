﻿#pragma checksum "..\..\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7DEA28127790DE1B95394BCC99EB453A578679B6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using hackathon;


namespace hackathon {
    
    
    /// <summary>
    /// Login
    /// </summary>
    public partial class Login : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal hackathon.Login LoginWindow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBLogin;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtBPassword;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOK;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBCor;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/hackathon;component/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Login.xaml"
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
            this.LoginWindow = ((hackathon.Login)(target));
            
            #line 8 "..\..\Login.xaml"
            this.LoginWindow.Closed += new System.EventHandler(this.Fermer);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\Login.xaml"
            ((System.Windows.Controls.Grid)(target)).DragEnter += new System.Windows.DragEventHandler(this.Pressed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtBLogin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 14 "..\..\Login.xaml"
            this.txtBPassword.TouchEnter += new System.EventHandler<System.Windows.Input.TouchEventArgs>(this.Pressed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnOK = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Login.xaml"
            this.btnOK.Click += new System.Windows.RoutedEventHandler(this.Pressed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtBCor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnInfo = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Login.xaml"
            this.btnInfo.Click += new System.Windows.RoutedEventHandler(this.Info);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

