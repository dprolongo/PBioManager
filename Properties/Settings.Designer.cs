﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.17929
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBioManager.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=\"C:\\USERS\\DANI\\DOCUMENTS\\VISUAL STUDIO 2" +
            "010\\PROJECTS\\RUNNERSVC\\RUNNERSVC\\BIN\\DEBUG\\WEBAPPDB.MDF\";Integrated Security=Tru" +
            "e")]
        public string C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_BIN_DEBUG_WEBAPPDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_BIN_DEBUG" +
                    "_WEBAPPDB_MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=\"C:\\USERS\\DANI\\DOCUMENTS\\VISUAL STUDIO 2" +
            "010\\PROJECTS\\RUNNERSVC\\RUNNERSVC\\RUNNERDB.MDF\";Integrated Security=True")]
        public string C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_RUNNERDB_MDFConnectionString {
            get {
                return ((string)(this["C__USERS_DANI_DOCUMENTS_VISUAL_STUDIO_2010_PROJECTS_RUNNERSVC_RUNNERSVC_RUNNERDB_" +
                    "MDFConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=webappDB;Integrated Security=True")]
        public string webappDBConnectionString {
            get {
                return ((string)(this["webappDBConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.\\SQLEXPRESS;Initial Catalog=runnerDB;Integrated Security=True")]
        public string runnerDBConnectionString {
            get {
                return ((string)(this["runnerDBConnectionString"]));
            }
        }
    }
}
