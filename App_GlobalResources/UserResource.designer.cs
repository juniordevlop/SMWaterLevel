//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class UserResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal UserResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.UserResource", global::System.Reflection.Assembly.Load("App_GlobalResources"));
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
        ///   Looks up a localized string similar to New Password and Confirm Password must be same.&lt;br/&gt;.
        /// </summary>
        internal static string notsamepassword {
            get {
                return ResourceManager.GetString("notsamepassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, You aren&apos;t authorized role. So, Please contact to Administrator..
        /// </summary>
        internal static string pleasecontactadmin {
            get {
                return ResourceManager.GetString("pleasecontactadmin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required Confirm Password.&lt;/br&gt;.
        /// </summary>
        internal static string requireconfirmpassword {
            get {
                return ResourceManager.GetString("requireconfirmpassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required Name.&lt;br/&gt;.
        /// </summary>
        internal static string requirename {
            get {
                return ResourceManager.GetString("requirename", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required New Password.&lt;/br&gt;.
        /// </summary>
        internal static string requirenewpassword {
            get {
                return ResourceManager.GetString("requirenewpassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required Password.&lt;/br&gt;.
        /// </summary>
        internal static string requirepassword {
            get {
                return ResourceManager.GetString("requirepassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required Username.&lt;/br&gt;.
        /// </summary>
        internal static string requireusername {
            get {
                return ResourceManager.GetString("requireusername", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, You couldn&apos;t do. Because it&apos;s system default user.&lt;/br&gt;.
        /// </summary>
        internal static string systemdefaultuser {
            get {
                return ResourceManager.GetString("systemdefaultuser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username and Password didn&apos;t match.&lt;/br&gt;.
        /// </summary>
        internal static string wrongpassword {
            get {
                return ResourceManager.GetString("wrongpassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, SMWaterLevel doesn&apos;t recognize that Username.&lt;/br&gt;.
        /// </summary>
        internal static string wrongusername {
            get {
                return ResourceManager.GetString("wrongusername", resourceCulture);
            }
        }
    }
}
