﻿// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Todo.Resx {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResources {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Todo.Resx.AppResources", typeof(AppResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static string DeleteButton {
            get {
                return ResourceManager.GetString("DeleteButton", resourceCulture);
            }
        }
        
        internal static string CancelButton {
            get {
                return ResourceManager.GetString("CancelButton", resourceCulture);
            }
        }
        
        internal static string DoneLabel {
            get {
                return ResourceManager.GetString("DoneLabel", resourceCulture);
            }
        }
        
        internal static string SpeakButton {
            get {
                return ResourceManager.GetString("SpeakButton", resourceCulture);
            }
        }
        
        internal static string ApplicationTitle {
            get {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }
        
        internal static string NameLabel {
            get {
                return ResourceManager.GetString("NameLabel", resourceCulture);
            }
        }
        
        internal static string ApplicationHeading {
            get {
                return ResourceManager.GetString("ApplicationHeading", resourceCulture);
            }
        }
        
        internal static string NotesLabel {
            get {
                return ResourceManager.GetString("NotesLabel", resourceCulture);
            }
        }
        
        internal static string SaveButton {
            get {
                return ResourceManager.GetString("SaveButton", resourceCulture);
            }
        }
        
        internal static string SpeakTaskCount {
            get {
                return ResourceManager.GetString("SpeakTaskCount", resourceCulture);
            }
        }
        
        internal static string AddButton {
            get {
                return ResourceManager.GetString("AddButton", resourceCulture);
            }
        }
    }
}
