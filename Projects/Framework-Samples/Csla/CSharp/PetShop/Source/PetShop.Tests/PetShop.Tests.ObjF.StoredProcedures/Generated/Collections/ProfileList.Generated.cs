﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.1413, CSLA Framework: v3.8.2.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProfileList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures
{
    [Serializable]
    [Csla.Server.ObjectFactory(FactoryNames.ProfileListFactoryName)]
    public partial class ProfileList : BusinessListBase< ProfileList, Profile >
    {    
        #region Contructor(s)
        
        private ProfileList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Factory Methods 
        
        public static ProfileList NewList()
        {
            return DataPortal.Create< ProfileList >();
        }

        public static ProfileList GetByUniqueID(System.Int32 uniqueID)
        {
            return DataPortal.Fetch< ProfileList >(
                new ProfileCriteria{UniqueID = uniqueID});
        }

        public static ProfileList GetByUsernameApplicationName(System.String username, System.String applicationName)
        {
            return DataPortal.Fetch< ProfileList >(
                new ProfileCriteria{Username = username, ApplicationName = applicationName});
        }

        public static ProfileList GetAll()
        {
            return DataPortal.Fetch< ProfileList >(new ProfileCriteria());
        }

        #endregion

        #region Properties
        
        protected override object AddNewCore()
        {
            Profile item = PetShop.Tests.ObjF.StoredProcedures.Profile.NewProfile();
            Add(item);
            return item;
        }
        
        #endregion

        #region Property overrides

        /// <summary>
        /// Returns true if any children are dirty
        /// </summary>
        public new bool IsDirty
        {
            get
            {
                foreach(Profile item in this.Items)
                {
                    if(item.IsDirty) return true;
                }
                
                return false;
            }
        }

        #endregion


        #region Exists Command

        public static bool Exists(ProfileCriteria criteria)
        {
            return PetShop.Tests.ObjF.StoredProcedures.Profile.Exists(criteria);
        }

        #endregion
    }
}