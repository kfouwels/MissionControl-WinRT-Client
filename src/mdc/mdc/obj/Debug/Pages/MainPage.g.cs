﻿

#pragma checksum "C:\Data\hack\Missiondump_Client\src\mdc\mdc\Pages\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35E87962928E3B13A4B5726617E52FC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mdc.Pages
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 77 "..\..\Pages\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.Selector_OnSelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 32 "..\..\Pages\MainPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.CompanyFor_OnKeyDown;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 111 "..\..\Pages\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddComp_OnClick;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 114 "..\..\Pages\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Submit_OnClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


