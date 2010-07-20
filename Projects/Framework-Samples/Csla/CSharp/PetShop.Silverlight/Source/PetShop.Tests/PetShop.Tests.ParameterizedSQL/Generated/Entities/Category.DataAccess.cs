﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Category.cs'.
//
//     Template: EditableRoot.DataAccess.ParameterizedSQL.cst
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

namespace PetShop.Tests.ParameterizedSQL
{
    public partial class Category
    {
        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;

            BusinessRules.CheckRules();

            OnCreated();
        }

        protected void DataPortal_Fetch(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("SELECT [CategoryId], [Name], [Descn], [TheVersion] FROM [dbo].[Category] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'Category' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Category] ([CategoryId], [Name], [Descn]) VALUES (@p_CategoryId, @p_Name, @p_Descn); SELECT [TheVersion] FROM [dbo].[Category] WHERE CategoryId = @p_CategoryId";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
					command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                        {
                            using (BypassPropertyChecks)
                            {
                                TheVersion = ADOHelper.GetBytes(reader, "TheVersion");                        
                            }
                        }
                    }

                    LoadProperty(_originalCategoryIdProperty, this.CategoryId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            if(OriginalCategoryId != CategoryId)
            {
                // Insert new child.
				Category item = new Category {CategoryId = CategoryId, Name = Name, Description = Description};
                
                item = item.Save();

                // Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
                foreach(Product itemToUpdate in Products)
                {
				itemToUpdate.CategoryId = CategoryId;
                }

                // Create a new connection.
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    FieldManager.UpdateChildren(this, connection);
                }

                // Delete the old.
				var criteria = new CategoryCriteria {CategoryId = OriginalCategoryId};
				
                DataPortal_Delete(criteria);

                // Mark the original as the new one.
                OriginalCategoryId = CategoryId;

                OnUpdated();

                return;
            }

            const string commandText = "UPDATE [dbo].[Category]  SET [CategoryId] = @p_CategoryId, [Name] = @p_Name, [Descn] = @p_Descn WHERE [CategoryId] = @p_OriginalCategoryId AND [TheVersion] = @p_TheVersion; SELECT [TheVersion] FROM [dbo].[Category] WHERE CategoryId = @p_CategoryId";
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_OriginalCategoryId", this.OriginalCategoryId);
					command.Parameters.AddWithValue("@p_CategoryId", this.CategoryId);
					command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
					command.Parameters.AddWithValue("@p_Descn", ADOHelper.NullCheck(this.Description));
                    command.Parameters.AddWithValue("@p_TheVersion", SqlDbType.Timestamp);
                    command.Parameters["@p_TheVersion"].Value = this.TheVersion;
                    command.Parameters["@p_TheVersion"].Direction = ParameterDirection.InputOutput;

                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        //RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        if(reader.RecordsAffected == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                        if(reader.Read())
                        {
                            using (BypassPropertyChecks)
                            {
                                TheVersion = ADOHelper.GetBytes(reader, "TheVersion");
                            }
                        }
                    }

                    LoadProperty(_originalCategoryIdProperty, this.CategoryId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new CategoryCriteria (CategoryId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(CategoryCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = string.Format("DELETE FROM [dbo].[Category] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                TheVersion = ADOHelper.GetBytes(reader, "TheVersion");
                LoadProperty(_categoryIdProperty, reader["CategoryId"]);
                LoadProperty(_originalCategoryIdProperty, reader["CategoryId"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_descriptionProperty, reader["Descn"]);
            }

            OnMapped();

            MarkOld();
        }
    }
}
