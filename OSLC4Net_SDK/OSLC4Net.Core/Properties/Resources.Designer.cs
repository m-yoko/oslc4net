﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OSLC4Net.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OSLC4Net.Core.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC001: Error unregistering Service Provider URI {0}. Returned error code is: {1}; error message is: {2}.
        /// </summary>
        public static string DeregistrationException {
            get {
                return ResourceManager.GetString("DeregistrationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC002: Duplicate property definition annotation {1} for class {0}.
        /// </summary>
        public static string DuplicatePropertyDefinitionException {
            get {
                return ResourceManager.GetString("DuplicatePropertyDefinitionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid occurs annotation {2} for method {1} of class {0}.
        /// </summary>
        public static string InvalidOccursException {
            get {
                return ResourceManager.GetString("InvalidOccursException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC004: Invalid property definition annotation {2} for method {1} of class {0}.
        /// </summary>
        public static string InvalidPropertyDefinitionException {
            get {
                return ResourceManager.GetString("InvalidPropertyDefinitionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC005: Invalid property type {2} returned by method {1} of class {0}.
        /// </summary>
        public static string InvalidPropertyTypeException {
            get {
                return ResourceManager.GetString("InvalidPropertyTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC006: Invalid representation {2} defined for method {1} of class {0}.
        /// </summary>
        public static string InvalidRepresentationException {
            get {
                return ResourceManager.GetString("InvalidRepresentationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC007: Invalid value type {2} defined for method {1} of class {0}.
        /// </summary>
        public static string InvalidValueTypeException {
            get {
                return ResourceManager.GetString("InvalidValueTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC008: Missing mandatory OSLC annotation {1} for class {0}.
        /// </summary>
        public static string MissingAnnotationException {
            get {
                return ResourceManager.GetString("MissingAnnotationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC009: Namespace declaration not defined for namespace {0}.
        /// </summary>
        public static string MissingNamespaceDeclarationException {
            get {
                return ResourceManager.GetString("MissingNamespaceDeclarationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC010: Namespace declaration not defined for prefix {0}.
        /// </summary>
        public static string MissingNamespacePrefixException {
            get {
                return ResourceManager.GetString("MissingNamespacePrefixException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC011: Missing corresponding set method for method {1} of class {0}.
        /// </summary>
        public static string MissingSetMethodException {
            get {
                return ResourceManager.GetString("MissingSetMethodException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC012: Multiple values for method {1} of class {0} that supports at most one value.
        /// </summary>
        public static string MisusedOccursException {
            get {
                return ResourceManager.GetString("MisusedOccursException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC013: Error registering Service Provider {0}. Returned error code is: {1}; error message is: {2}.
        /// </summary>
        public static string RegistrationException {
            get {
                return ResourceManager.GetString("RegistrationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OSLC014: Relative URI value {2} for method {1} of class {0}.
        /// </summary>
        public static string RelativeURIException {
            get {
                return ResourceManager.GetString("RelativeURIException", resourceCulture);
            }
        }
    }
}