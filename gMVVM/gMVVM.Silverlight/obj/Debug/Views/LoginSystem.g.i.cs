﻿#pragma checksum "D:\Coding\sba-se214-g22\gMVVM\gMVVM.Silverlight\Views\LoginSystem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9F5520E1B75B34286C3083E5A440B23C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace gMVVM {
    
    
    public partial class LoginSystem : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard SwivelToBackStoryboard;
        
        internal System.Windows.Media.Animation.Storyboard SwivelToFrontStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal BusyIndicator ProcessingLogin;
        
        internal System.Windows.Controls.Border SwivelPanelBack;
        
        internal System.Windows.Controls.Border SwivelPanelFront;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/gMVVM;component/Views/LoginSystem.xaml", System.UriKind.Relative));
            this.SwivelToBackStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SwivelToBackStoryboard")));
            this.SwivelToFrontStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("SwivelToFrontStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ProcessingLogin = ((BusyIndicator)(this.FindName("ProcessingLogin")));
            this.SwivelPanelBack = ((System.Windows.Controls.Border)(this.FindName("SwivelPanelBack")));
            this.SwivelPanelFront = ((System.Windows.Controls.Border)(this.FindName("SwivelPanelFront")));
        }
    }
}

