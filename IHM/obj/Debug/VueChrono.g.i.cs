﻿#pragma checksum "..\..\VueChrono.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF9C5D3E9746DDE69F83116EBC6054291AF0DA6413F60AC60BD344263AB0A209"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using IHM;
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


namespace IHM {
    
    
    /// <summary>
    /// VueChrono
    /// </summary>
    public partial class VueChrono : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\VueChrono.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelInfo;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\VueChrono.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNom;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\VueChrono.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxEtatChrono;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\VueChrono.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDémarrer;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\VueChrono.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonArrêter;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\VueChrono.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonQuitter;
        
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
            System.Uri resourceLocater = new System.Uri("/ProjectTimer;component/vuechrono.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VueChrono.xaml"
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
            this.labelInfo = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.textBoxNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBoxEtatChrono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.buttonDémarrer = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\VueChrono.xaml"
            this.buttonDémarrer.Click += new System.Windows.RoutedEventHandler(this.ClickDémarrer);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonArrêter = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\VueChrono.xaml"
            this.buttonArrêter.Click += new System.Windows.RoutedEventHandler(this.ClickArrêter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonQuitter = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\VueChrono.xaml"
            this.buttonQuitter.Click += new System.Windows.RoutedEventHandler(this.ClickQuitter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

