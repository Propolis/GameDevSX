﻿#pragma checksum "..\..\GamePlay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BCEDAA24C9744ACC03771C6B242A0FBAA7B46533CF58AED53E9EAECD80403056"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Menu2;
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


namespace Menu2 {
    
    
    /// <summary>
    /// GamePlay
    /// </summary>
    public partial class GamePlay : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas GameScreen;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Player;
        
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
            System.Uri resourceLocater = new System.Uri("/Menu2;component/gameplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GamePlay.xaml"
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
            this.GameScreen = ((System.Windows.Controls.Canvas)(target));
            
            #line 10 "..\..\GamePlay.xaml"
            this.GameScreen.KeyUp += new System.Windows.Input.KeyEventHandler(this.KeyboardUp);
            
            #line default
            #line hidden
            
            #line 10 "..\..\GamePlay.xaml"
            this.GameScreen.KeyDown += new System.Windows.Input.KeyEventHandler(this.KeyBoardDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Player = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

