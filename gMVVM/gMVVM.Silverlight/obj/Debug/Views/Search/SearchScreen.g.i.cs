﻿#pragma checksum "D:\Coding\sba-se214-g22\gMVVM\gMVVM.Silverlight\Views\Search\SearchScreen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35AEFFCC0267836FD26CB5B38F3177A7"
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


namespace gMVVM.Views.Search {
    
    
    public partial class SearchScreen : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.ChildWindow childWindow;
        
        internal System.Windows.Media.Animation.Storyboard StoryboardNavigateFrame;
        
        internal System.Windows.Media.Animation.Storyboard StoryboardBackClick;
        
        internal ChangePropertyAction buttonclo;
        
        internal ChangePropertyAction buttonclo1;
        
        internal BusyIndicator Processing1;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ContentControl FrameChi;
        
        internal System.Windows.Controls.Label lblTitle;
        
        internal System.Windows.Controls.Button ButtonClose;
        
        internal System.Windows.Controls.HyperlinkButton hyperlinkButton1;
        
        internal System.Windows.Controls.HyperlinkButton hyperlinkButton;
        
        internal System.Windows.Controls.Button button;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/gMVVM;component/Views/Search/SearchScreen.xaml", System.UriKind.Relative));
            this.childWindow = ((System.Windows.Controls.ChildWindow)(this.FindName("childWindow")));
            this.StoryboardNavigateFrame = ((System.Windows.Media.Animation.Storyboard)(this.FindName("StoryboardNavigateFrame")));
            this.StoryboardBackClick = ((System.Windows.Media.Animation.Storyboard)(this.FindName("StoryboardBackClick")));
            this.buttonclo = ((ChangePropertyAction)(this.FindName("buttonclo")));
            this.buttonclo1 = ((ChangePropertyAction)(this.FindName("buttonclo1")));
            this.Processing1 = ((BusyIndicator)(this.FindName("Processing1")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.FrameChi = ((System.Windows.Controls.ContentControl)(this.FindName("FrameChi")));
            this.lblTitle = ((System.Windows.Controls.Label)(this.FindName("lblTitle")));
            this.ButtonClose = ((System.Windows.Controls.Button)(this.FindName("ButtonClose")));
            this.hyperlinkButton1 = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hyperlinkButton1")));
            this.hyperlinkButton = ((System.Windows.Controls.HyperlinkButton)(this.FindName("hyperlinkButton")));
            this.button = ((System.Windows.Controls.Button)(this.FindName("button")));
        }
    }
}

