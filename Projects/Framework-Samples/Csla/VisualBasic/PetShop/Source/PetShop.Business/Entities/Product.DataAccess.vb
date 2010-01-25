'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Product.vb.
'
'     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Public Partial Class Product

    #Region "Root Data Access"

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()
        'MyBase.DataPortal_Create()

        ValidationRules.CheckRules()
    End Sub
    
    <Transactional(TransactionalTypes.TransactionScope)> _
    Private Shadows Sub DataPortal_Fetch(ByVal criteria As ProductCriteria)
        Dim commandText As String = String.Format("SELECT [ProductId], [Name], [Descn], [Image], [CategoryId] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Product' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using
    End Sub
    
    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Insert()
        Const commandText As String = "INSERT INTO [dbo].[Product] ([ProductId], [Name], [Descn], [Image], [CategoryId]) VALUES (@p_ProductId, @p_Name, @p_Descn, @p_Image, @p_CategoryId)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "ProductInsert")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ProductId", ProductId)
						command.Parameters.AddWithValue("@p_Name", Name)
						command.Parameters.AddWithValue("@p_Descn", Descn)
						command.Parameters.AddWithValue("@p_Image", Image)
					command.Parameters.AddWithValue("@p_CategoryId", CategoryId)
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            If reader.Read() Then

                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("ProductInsert")
                        Throw
                    End Try
                End Using
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Update()
        Const commandText As String = "UPDATE [dbo].[Product]  SET [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image, [CategoryId] = @p_categoryId WHERE [ProductId] = @p_ProductId"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "ProductUpdate")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ProductId", ProductId)
						command.Parameters.AddWithValue("@p_Name", Name)
						command.Parameters.AddWithValue("@p_Descn", Descn)
						command.Parameters.AddWithValue("@p_Image", Image)
					command.Parameters.AddWithValue("@p_CategoryId", CategoryId)
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                            If reader.RecordsAffected = 0 Then
                                Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("ProductUpdate")
                        Throw
                    End Try
                End Using
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_DeleteSelf()
        DataPortal_Delete(new ProductCriteria(ProductId))
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Sub DataPortal_Delete(ByVal criteria As ProductCriteria)
        Dim commandText As String = String.Format("DELETE FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "ProductDelete")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                            If reader.RecordsAffected = 0 Then
                                Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("ProductDelete")
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    #End Region

    #Region "Child Data Access"

    <RunLocal()> _
    Protected Overrides Sub Child_Create()
        ' TODO: load default values
        ' omit this override if you have no defaults to set
        'MyBase.Child_Create()
    End Sub
    
    Private Sub Child_Fetch(ByVal criteria As ProductCriteria)
        Dim commandText As String = String.Format("SELECT [ProductId], [Name], [Descn], [Image], [CategoryId] FROM [dbo].[Product] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Product' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        MarkAsChild()
    End Sub

    Private Sub Child_Insert()
        Const commandText As String = "INSERT INTO [dbo].[Product] ([ProductId], [Name], [Descn], [Image], [CategoryId]) VALUES (@p_ProductId, @p_Name, @p_Descn, @p_Image, @p_CategoryId)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "ProductInsert")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ProductId", ProductId)
						command.Parameters.AddWithValue("@p_Name", Name)
						command.Parameters.AddWithValue("@p_Descn", Descn)
						command.Parameters.AddWithValue("@p_Image", Image)
					command.Parameters.AddWithValue("@p_CategoryId", CategoryId)
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            If reader.Read() Then

                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("ProductInsert")
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub Child_Update()
        Const commandText As String = "UPDATE [dbo].[Product]  SET [Name] = @p_Name, [Descn] = @p_Descn, [Image] = @p_Image, [CategoryId] = @p_categoryId WHERE [ProductId] = @p_ProductId"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "ProductUpdate")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_ProductId", ProductId)
						command.Parameters.AddWithValue("@p_Name", Name)
						command.Parameters.AddWithValue("@p_Descn", Descn)
						command.Parameters.AddWithValue("@p_Image", Image)
					command.Parameters.AddWithValue("@p_CategoryId", CategoryId)
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                            If reader.RecordsAffected = 0 Then
                                Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("ProductUpdate")
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub Child_DeleteSelf()
        DataPortal_Delete(new ProductCriteria(ProductId))
    End Sub

    #End Region

    Private Sub Map(ByVal reader As SafeDataReader)
        LoadProperty(_productIdProperty, reader.GetString("ProductId"))
        LoadProperty(_nameProperty, reader.GetString("Name"))
        LoadProperty(_descnProperty, reader.GetString("Descn"))
        LoadProperty(_imageProperty, reader.GetString("Image"))

        LoadProperty(_categoryIdProperty, reader.GetString("CategoryId"))

        MarkOld()
    End Sub
End Class