﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Devkoes.JenkinsManager.APIHandler.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Devkoes.JenkinsManager.Model.Schema.JenkinsServerList JenkinsServers {
            get {
                return ((global::Devkoes.JenkinsManager.Model.Schema.JenkinsServerList)(this["JenkinsServers"]));
            }
            set {
                this["JenkinsServers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Devkoes.JenkinsManager.Model.Schema.SolutionJenkinsJobLinkList SolutionJobs {
            get {
                return ((global::Devkoes.JenkinsManager.Model.Schema.SolutionJenkinsJobLinkList)(this["SolutionJobs"]));
            }
            set {
                this["SolutionJobs"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DebugOutputEnabled {
            get {
                return ((bool)(this["DebugOutputEnabled"]));
            }
            set {
                this["DebugOutputEnabled"] = value;
            }
        }
    }
}
