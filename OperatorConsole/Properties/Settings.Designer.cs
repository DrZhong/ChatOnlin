﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiveChatStarterKit.OperatorConsole.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:1096/LCSKServices/OpServices.asmx")]
        public string OperatorConsole_LiveChatWS_Operator {
            get {
                return ((string)(this["OperatorConsole_LiveChatWS_Operator"]));
            }
            set {
                this["OperatorConsole_LiveChatWS_Operator"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection CannedMsg {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CannedMsg"]));
            }
            set {
                this["CannedMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection PresetLinks {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["PresetLinks"]));
            }
            set {
                this["PresetLinks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PlaySoundOnChatReq {
            get {
                return ((bool)(this["PlaySoundOnChatReq"]));
            }
            set {
                this["PlaySoundOnChatReq"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool PlaySoundOnChatMsg {
            get {
                return ((bool)(this["PlaySoundOnChatMsg"]));
            }
            set {
                this["PlaySoundOnChatMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GetWebRequestOffline {
            get {
                return ((bool)(this["GetWebRequestOffline"]));
            }
            set {
                this["GetWebRequestOffline"] = value;
            }
        }
    }
}
