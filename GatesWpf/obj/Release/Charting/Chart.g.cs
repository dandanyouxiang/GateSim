﻿#pragma checksum "..\..\..\Charting\Chart.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D583002FE1CE8D13F9ED4F558240358E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GatesWpf.Charting;
using GatesWpf.DragDrop;
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


namespace GatesWpf.Charting {
    
    
    /// <summary>
    /// Chart
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Chart : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slZoom;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton btnPause;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReset;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer lbLineLabelsScroller;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GatesWpf.DragDrop.ReorderableListBox lbLineLabels;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer lbLinesScroller;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GatesWpf.DragDrop.ReorderableListBox lbLines;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Charting\Chart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GatesWpf.Charting.TickRuler tickRuler;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/GatesWpf;component/charting/chart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Charting\Chart.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.slZoom = ((System.Windows.Controls.Slider)(target));
            
            #line 18 "..\..\..\Charting\Chart.xaml"
            this.slZoom.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slZoom_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnPause = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 20 "..\..\..\Charting\Chart.xaml"
            this.btnPause.Checked += new System.Windows.RoutedEventHandler(this.btnPause_Checked);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Charting\Chart.xaml"
            this.btnPause.Unchecked += new System.Windows.RoutedEventHandler(this.btnPause_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnReset = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Charting\Chart.xaml"
            this.btnReset.Click += new System.Windows.RoutedEventHandler(this.btnReset_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lbLineLabelsScroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.lbLineLabels = ((GatesWpf.DragDrop.ReorderableListBox)(target));
            return;
            case 6:
            this.lbLinesScroller = ((System.Windows.Controls.ScrollViewer)(target));
            
            #line 31 "..\..\..\Charting\Chart.xaml"
            this.lbLinesScroller.ScrollChanged += new System.Windows.Controls.ScrollChangedEventHandler(this.lbLines_ScrollChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbLines = ((GatesWpf.DragDrop.ReorderableListBox)(target));
            return;
            case 8:
            this.tickRuler = ((GatesWpf.Charting.TickRuler)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

