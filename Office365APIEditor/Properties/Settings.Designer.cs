﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Office365APIEditor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastRequest {
            get {
                return ((string)(this["LastRequest"]));
            }
            set {
                this["LastRequest"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppClientID {
            get {
                return ((string)(this["LastWebAppClientID"]));
            }
            set {
                this["LastWebAppClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppClientSecret {
            get {
                return ((string)(this["LastWebAppClientSecret"]));
            }
            set {
                this["LastWebAppClientSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastNativeAppTenantName {
            get {
                return ((string)(this["LastNativeAppTenantName"]));
            }
            set {
                this["LastNativeAppTenantName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastNativeAppClientID {
            get {
                return ((string)(this["LastNativeAppClientID"]));
            }
            set {
                this["LastNativeAppClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastNativeAppRedirectURL {
            get {
                return ((string)(this["LastNativeAppRedirectURL"]));
            }
            set {
                this["LastNativeAppRedirectURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppRedirectURL {
            get {
                return ((string)(this["LastWebAppRedirectURL"]));
            }
            set {
                this["LastWebAppRedirectURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string BasicAuthSmtpAddress {
            get {
                return ((string)(this["BasicAuthSmtpAddress"]));
            }
            set {
                this["BasicAuthSmtpAddress"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>offline_access</string>
  <string>openid</string>
  <string>profile</string>
  <string>email</string>
  <string>https://outlook.office.com/mail.read</string>
  <string>https://outlook.office.com/mail.readwrite</string>
  <string>https://outlook.office.com/mail.send</string>
  <string>https://outlook.office.com/contacts.read</string>
  <string>https://outlook.office.com/contacts.readwrite</string>
  <string>https://outlook.office.com/calendars.read</string>
  <string>https://outlook.office.com/calendars.readwrite</string>
  <string>https://graph.microsoft.com/mail.read</string>
  <string>https://graph.microsoft.com/mail.readwrite</string>
  <string>https://graph.microsoft.com/mail.send</string>
  <string>https://graph.microsoft.com/contacts.read</string>
  <string>https://graph.microsoft.com/contacts.readwrite</string>
  <string>https://graph.microsoft.com/calendars.read</string>
  <string>https://graph.microsoft.com/calendars.readwrite</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection PredefinedScopes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["PredefinedScopes"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>offline_access</string>
  <string>https://graph.microsoft.com/mail.read</string>
  <string>https://graph.microsoft.com/mail.readwrite</string>
  <string>https://graph.microsoft.com/mail.send</string>
  <string>https://graph.microsoft.com/contacts.read</string>
  <string>https://graph.microsoft.com/contacts.readwrite</string>
  <string>https://graph.microsoft.com/calendars.read</string>
  <string>https://graph.microsoft.com/calendars.readwrite</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection DefaultScopes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["DefaultScopes"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection CustomDefinedScopes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["CustomDefinedScopes"]));
            }
            set {
                this["CustomDefinedScopes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastV2WebAppClientID {
            get {
                return ((string)(this["LastV2WebAppClientID"]));
            }
            set {
                this["LastV2WebAppClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastV2WebAppRedirectUri {
            get {
                return ((string)(this["LastV2WebAppRedirectUri"]));
            }
            set {
                this["LastV2WebAppRedirectUri"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastV2WebAppScopes {
            get {
                return ((string)(this["LastV2WebAppScopes"]));
            }
            set {
                this["LastV2WebAppScopes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastV2WebAppClientSecret {
            get {
                return ((string)(this["LastV2WebAppClientSecret"]));
            }
            set {
                this["LastV2WebAppClientSecret"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastV2MobileAppClientID {
            get {
                return ((string)(this["LastV2MobileAppClientID"]));
            }
            set {
                this["LastV2MobileAppClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastV2MobileAppScopes {
            get {
                return ((string)(this["LastV2MobileAppScopes"]));
            }
            set {
                this["LastV2MobileAppScopes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NeedUpgrade {
            get {
                return ((bool)(this["NeedUpgrade"]));
            }
            set {
                this["NeedUpgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastMailboxViewerClientID {
            get {
                return ((string)(this["LastMailboxViewerClientID"]));
            }
            set {
                this["LastMailboxViewerClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppAppOnlyTenantName {
            get {
                return ((string)(this["LastWebAppAppOnlyTenantName"]));
            }
            set {
                this["LastWebAppAppOnlyTenantName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppAppOnlyClientID {
            get {
                return ((string)(this["LastWebAppAppOnlyClientID"]));
            }
            set {
                this["LastWebAppAppOnlyClientID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppAppOnlyCertPath {
            get {
                return ((string)(this["LastWebAppAppOnlyCertPath"]));
            }
            set {
                this["LastWebAppAppOnlyCertPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastWebAppAppOnlyCertPass {
            get {
                return ((string)(this["LastWebAppAppOnlyCertPass"]));
            }
            set {
                this["LastWebAppAppOnlyCertPass"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogFolderPath {
            get {
                return ((string)(this["LogFolderPath"]));
            }
            set {
                this["LogFolderPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Static")]
        public string LogFileStyle {
            get {
                return ((string)(this["LogFileStyle"]));
            }
            set {
                this["LogFileStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowAutoRedirect {
            get {
                return ((bool)(this["AllowAutoRedirect"]));
            }
            set {
                this["AllowAutoRedirect"] = value;
            }
        }
    }
}
