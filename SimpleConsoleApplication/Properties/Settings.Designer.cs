﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleConsoleApplication.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://phoenix.sonraisystems.com/sonraidataservice.asmx")]
        public string SimpleConsoleApplication_com_sonraisystems_phoenix_SonraiDataService {
            get {
                return ((string)(this["SimpleConsoleApplication_com_sonraisystems_phoenix_SonraiDataService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://sonraipickupsvc.sonraisystems.com/SonraiPickupSvc/service.asmx")]
        public string SimpleConsoleApplication_com_sonraisystems_sonraipickupsvc_Service {
            get {
                return ((string)(this["SimpleConsoleApplication_com_sonraisystems_sonraipickupsvc_Service"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://sonraipickupsvc.sonraisystems.com/SonraiPickupSvc/service.asmx")]
        public string SimpleConsoleApplication_com_sonraisystems_sonraipickupsvc1_Service {
            get {
                return ((string)(this["SimpleConsoleApplication_com_sonraisystems_sonraipickupsvc1_Service"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://10.10.10.5:64907")]
        public string SimpleConsoleApplication_WebReferenceHoneywellWSDL_DeviceConfiguration {
            get {
                return ((string)(this["SimpleConsoleApplication_WebReferenceHoneywellWSDL_DeviceConfiguration"]));
            }
        }
    }
}
