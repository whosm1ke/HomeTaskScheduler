﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeTaskScheduler.Application.Resources {
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
    internal class TaskResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TaskResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HomeTaskScheduler.Application.Resources.TaskResources", typeof(TaskResources).Assembly);
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
        ///   Looks up a localized string similar to At least one course Id is required.
        /// </summary>
        internal static string CourseIdsIsRequired {
            get {
                return ResourceManager.GetString("CourseIdsIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Course Id&apos;s can not be null.
        /// </summary>
        internal static string CourseIdsNotNull {
            get {
                return ResourceManager.GetString("CourseIdsNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Task Type.
        /// </summary>
        internal static string InvalidTaskType {
            get {
                return ResourceManager.GetString("InvalidTaskType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Max mark must be between 1 and 100..
        /// </summary>
        internal static string MaxMArkBetween1And100 {
            get {
                return ResourceManager.GetString("MaxMArkBetween1And100", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one student Id is required.
        /// </summary>
        internal static string StudentIdsIsRequired {
            get {
                return ResourceManager.GetString("StudentIdsIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Student Id&apos;s can not be null.
        /// </summary>
        internal static string StudentIdsNotNull {
            get {
                return ResourceManager.GetString("StudentIdsNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task instructions must be less than 2000 characters. You entered {0} characters..
        /// </summary>
        internal static string TaskInstructionsNoLongerThan2000 {
            get {
                return ResourceManager.GetString("TaskInstructionsNoLongerThan2000", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task title is required..
        /// </summary>
        internal static string TaskTitleIsRequired {
            get {
                return ResourceManager.GetString("TaskTitleIsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Task title must be less than 200 characters. You entered {0} characters..
        /// </summary>
        internal static string TaskTitleNoLongerThan200 {
            get {
                return ResourceManager.GetString("TaskTitleNoLongerThan200", resourceCulture);
            }
        }
    }
}
