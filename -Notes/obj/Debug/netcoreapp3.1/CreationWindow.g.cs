﻿#pragma checksum "..\..\..\CreationWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DBCD3D9B12E852BB2D36D04C0713A67829E44429"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Notes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Notes {
    
    
    /// <summary>
    /// CreationWindow
    /// </summary>
    public partial class CreationWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\CreationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bold_Button;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\CreationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Underlined;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CreationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Italic;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\CreationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox NoteEditor;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\CreationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Note_Title;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\CreationWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Note_Tag;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Notes;component/creationwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreationWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\CreationWindow.xaml"
            ((Notes.CreationWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.CreationWIndow_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Bold_Button = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\CreationWindow.xaml"
            this.Bold_Button.Click += new System.Windows.RoutedEventHandler(this.Bold_Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Underlined = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\CreationWindow.xaml"
            this.Underlined.Click += new System.Windows.RoutedEventHandler(this.Underlined_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Italic = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\CreationWindow.xaml"
            this.Italic.Click += new System.Windows.RoutedEventHandler(this.Italic_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NoteEditor = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 6:
            this.Note_Title = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\CreationWindow.xaml"
            this.Note_Title.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Note_Title_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Note_Tag = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\CreationWindow.xaml"
            this.Note_Tag.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Note_Tag_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

