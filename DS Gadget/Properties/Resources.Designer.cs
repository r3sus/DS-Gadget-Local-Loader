﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DS_Gadget.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DS_Gadget.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mov esi, [0x{0:X}]
        ///mov edi, 0x1
        ///push edi
        ///call 0x{1:X}
        ///ret.
        /// </summary>
        internal static string BonfireWarp {
            get {
                return ResourceManager.GetString("BonfireWarp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mov ebp, 0x{0:X}
        ///mov ebx, 0x{1:X}
        ///mov ecx, 0xFFFFFFFF
        ///mov edx, 0x{2:X}
        ///mov eax, [0x{3:X}]
        ///mov [eax + 0x828], ebp
        ///mov [eax + 0x82C], ebx
        ///mov [eax + 0x830], ecx
        ///mov [eax + 0x834], edx
        ///mov eax, [0x{4:X}]
        ///push eax
        ///call 0x{5:X}
        ///ret.
        /// </summary>
        internal static string ItemDrop {
            get {
                return ResourceManager.GetString("ItemDrop", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mov edi, 0x{0:X}
        ///mov ecx, 0x{1:X}
        ///mov esi, 0x{2:X}
        ///mov ebp, 0x{3:X}
        ///mov ebx, 0xFFFFFFFF
        ///push 0x0
        ///push 0x1
        ///push ebp
        ///push esi
        ///push ecx
        ///push edi
        ///call 0x{4:X}
        ///ret.
        /// </summary>
        internal static string ItemGet {
            get {
                return ResourceManager.GetString("ItemGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to mov eax, 0x{0:X}
        ///mov ecx, 0x{0:X}
        ///call 0x{1:X}
        ///ret.
        /// </summary>
        internal static string LevelUp {
            get {
                return ResourceManager.GetString("LevelUp", resourceCulture);
            }
        }
    }
}
