﻿#pragma checksum "..\..\GamePlay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF572FB338391BA7076853392E62BFAF4E8927DBFE4BDBBFC2E299A601A2CC3A"
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
    public partial class GamePlay : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas GameScreen;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Character;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush ImagePlayer;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Wall;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Wall_Копировать;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Wall_Копировать1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Wall_Копировать2;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Wall_Копировать3;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\GamePlay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle Wall_Копировать4;
        
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
            this.Character = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 3:
            this.ImagePlayer = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 4:
            this.Wall = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 5:
            this.Wall_Копировать = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 6:
            this.Wall_Копировать1 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.Wall_Копировать2 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.Wall_Копировать3 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            this.Wall_Копировать4 = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

