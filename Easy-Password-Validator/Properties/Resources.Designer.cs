﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Easy_Password_Validator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Easy_Password_Validator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Password is in list of known bad passwords..
        /// </summary>
        internal static string FailedBadList {
            get {
                return ResourceManager.GetString("FailedBadList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have at least one digit in password..
        /// </summary>
        internal static string FailedDigit {
            get {
                return ResourceManager.GetString("FailedDigit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must have entropy score of at least {0}..
        /// </summary>
        internal static string FailedEntropy {
            get {
                return ResourceManager.GetString("FailedEntropy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password must be at least {0} characters long..
        /// </summary>
        internal static string FailedLength {
            get {
                return ResourceManager.GetString("FailedLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have at least one lowercase letter in password..
        /// </summary>
        internal static string FailedLowercase {
            get {
                return ResourceManager.GetString("FailedLowercase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password can have a maximum of {0} characters that neighbor each other on the keyboard..
        /// </summary>
        internal static string FailedPattern {
            get {
                return ResourceManager.GetString("FailedPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have at least one punctuation mark in password..
        /// </summary>
        internal static string FailedPunctuation {
            get {
                return ResourceManager.GetString("FailedPunctuation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password can have a maximum of {0} adjacent repeat characters..
        /// </summary>
        internal static string FailedRepeat {
            get {
                return ResourceManager.GetString("FailedRepeat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have at least {0} unique characters in password..
        /// </summary>
        internal static string FailedUnique {
            get {
                return ResourceManager.GetString("FailedUnique", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Must have at least one uppercase letter in password..
        /// </summary>
        internal static string FailedUppercase {
            get {
                return ResourceManager.GetString("FailedUppercase", resourceCulture);
            }
        }
    }
}
