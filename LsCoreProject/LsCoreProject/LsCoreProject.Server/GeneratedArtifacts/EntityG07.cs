﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    public sealed partial class Role : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Role entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Role()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Role(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Role> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Role.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Role_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Role_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Name
        {
            get
            {
                return global::LightSwitchApplication.Role.DetailsClass.GetValue(this, global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.Name);
            }
            set
            {
                global::LightSwitchApplication.Role.DetailsClass.SetValue(this, global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.Name, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Name_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.RoleAssignment> RoleAssignments
        {
            get
            {
                return global::LightSwitchApplication.Role.DetailsClass.GetValue(this, global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RoleAssignments);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.RoleAssignment> RoleAssignmentsQuery
        {
            get
            {
                return global::LightSwitchApplication.Role.DetailsClass.GetQuery(this, global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RoleAssignments);
            }
        }

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.RolePermission> RolePermissions
        {
            get
            {
                return global::LightSwitchApplication.Role.DetailsClass.GetValue(this, global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RolePermissions);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.RolePermission> RolePermissionsQuery
        {
            get
            {
                return global::LightSwitchApplication.Role.DetailsClass.GetQuery(this, global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RolePermissions);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Role,
                global::LightSwitchApplication.Role.DetailsClass,
                global::LightSwitchApplication.Role.DetailsClass.IImplementation,
                global::LightSwitchApplication.Role.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.Name;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass>.Entry
                __RoleEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass>.Entry(
                    global::LightSwitchApplication.Role.DetailsClass.__Role_CreateNew,
                    global::LightSwitchApplication.Role.DetailsClass.__Role_Created,
                    global::LightSwitchApplication.Role.DetailsClass.__Role_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Role __Role_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Role> es)
            {
                return new global::LightSwitchApplication.Role(es);
            }
            private static void __Role_Created(global::LightSwitchApplication.Role e)
            {
                e.Role_Created();
            }
            private static bool __Role_AllowSaveWithErrors(global::LightSwitchApplication.Role e)
            {
                bool result = false;
                e.Role_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Role.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, string> Name
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.Name) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RoleAssignment> RoleAssignments
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RoleAssignments) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RoleAssignment>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RolePermission> RolePermissions
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RolePermissions) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RolePermission>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new string Name { get; set; }
                new global::System.Collections.IEnumerable RoleAssignments { get; }
                new global::System.Collections.IEnumerable RolePermissions { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, string>.Entry
                    Name = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, string>.Entry(
                        "Name",
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._Name_Stub,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._Name_ComputeIsReadOnly,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._Name_Validate,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._Name_GetImplementationValue,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._Name_SetImplementationValue,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._Name_OnValueChanged);
                private static void _Name_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Role.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, string>.Data> c, global::LightSwitchApplication.Role.DetailsClass d, object sf)
                {
                    c(d, ref d._Name, sf);
                }
                private static bool _Name_ComputeIsReadOnly(global::LightSwitchApplication.Role e)
                {
                    bool result = false;
                    e.Name_IsReadOnly(ref result);
                    return result;
                }
                private static void _Name_Validate(global::LightSwitchApplication.Role e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Name_Validate(r);
                }
                private static string _Name_GetImplementationValue(global::LightSwitchApplication.Role.DetailsClass d)
                {
                    return d.ImplementationEntity.Name;
                }
                private static void _Name_SetImplementationValue(global::LightSwitchApplication.Role.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Name = v;
                }
                private static void _Name_OnValueChanged(global::LightSwitchApplication.Role e)
                {
                    e.Name_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RoleAssignment>.Entry
                    RoleAssignments = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RoleAssignment>.Entry(
                        "RoleAssignments",
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._RoleAssignments_Stub,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._RoleAssignments_GetReferencedEntities,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._RoleAssignments_GetEntityCollection);
                private static void _RoleAssignments_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Role.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RoleAssignment>.Data> c, global::LightSwitchApplication.Role.DetailsClass d, object sf)
                {
                    c(d, ref d._RoleAssignments, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.RoleAssignment> _RoleAssignments_GetReferencedEntities(global::LightSwitchApplication.Role.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.RoleAssignment, global::LightSwitchApplication.RoleAssignment.DetailsClass>(global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RoleAssignments, ref d._RoleAssignments);
                }
                private static global::System.Collections.IEnumerable _RoleAssignments_GetEntityCollection(global::LightSwitchApplication.Role.DetailsClass d)
                {
                    return d.ImplementationEntity.RoleAssignments;
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RolePermission>.Entry
                    RolePermissions = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RolePermission>.Entry(
                        "RolePermissions",
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._RolePermissions_Stub,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._RolePermissions_GetReferencedEntities,
                        global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties._RolePermissions_GetEntityCollection);
                private static void _RolePermissions_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Role.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RolePermission>.Data> c, global::LightSwitchApplication.Role.DetailsClass d, object sf)
                {
                    c(d, ref d._RolePermissions, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.RolePermission> _RolePermissions_GetReferencedEntities(global::LightSwitchApplication.Role.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.RolePermission, global::LightSwitchApplication.RolePermission.DetailsClass>(global::LightSwitchApplication.Role.DetailsClass.PropertySetProperties.RolePermissions, ref d._RolePermissions);
                }
                private static global::System.Collections.IEnumerable _RolePermissions_GetEntityCollection(global::LightSwitchApplication.Role.DetailsClass d)
                {
                    return d.ImplementationEntity.RolePermissions;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, string>.Data _Name;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RoleAssignment>.Data _RoleAssignments;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Role, global::LightSwitchApplication.Role.DetailsClass, global::LightSwitchApplication.RolePermission>.Data _RolePermissions;
            
        }
    
        #endregion
    }
    
    #endregion
}
