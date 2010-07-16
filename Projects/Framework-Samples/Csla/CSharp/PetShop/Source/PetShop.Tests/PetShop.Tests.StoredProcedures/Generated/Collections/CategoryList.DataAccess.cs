﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1817, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'CategoryList.cs'.
//
//     Template: EditableRootList.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    public partial class CategoryList
    {
        [RunLocal]
        protected override void DataPortal_Create()
        {
        }

        private void DataPortal_Fetch(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            // Fetch Child objects.
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Category_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_NameHasValue", criteria.NameHasValue);
					command.Parameters.AddWithValue("@p_DescnHasValue", criteria.DescriptionHasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            do
                            {
                                this.Add(new Category(reader));
                            } while(reader.Read());
                        }
                    }
                }
            }

            RaiseListChangedEvents = true;

            OnFetched();
        }

        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            RaiseListChangedEvents = false;

            for (int index = 0; index < DeletedList.Count; index++)
            {
                DeletedList[index] = DeletedList[index].Save();
            }
           
            DeletedList.Clear();

            for (int index = 0; index < Items.Count; index++)
            {
                Items[index] = Items[index].Save();
            }

            RaiseListChangedEvents = true;

            OnUpdated();
        }
    }
}
