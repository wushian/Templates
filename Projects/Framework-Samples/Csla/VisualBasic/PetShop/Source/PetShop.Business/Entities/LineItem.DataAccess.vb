'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
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

Public Partial Class LineItem

    #Region "Root Data Access"

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()
        'MyBase.DataPortal_Create()

        ValidationRules.CheckRules()
    End Sub
    
    <Transactional(TransactionalTypes.TransactionScope)> _
    Private Shadows Sub DataPortal_Fetch(ByVal criteria As LineItemCriteria)
        Dim commandText As String = String.Format("SELECT [OrderId], [LineNum], [ItemId], [Quantity], [UnitPrice] FROM [dbo].[LineItem] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'LineItem' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using
    End Sub
    
    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Insert()
        Const commandText As String = "INSERT INTO [dbo].[LineItem] ([OrderId], [LineNum], [ItemId], [Quantity], [UnitPrice]) VALUES (@p_OrderId, @p_LineNum, @p_ItemId, @p_Quantity, @p_UnitPrice)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "LineItemInsert")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", OrderId)
						command.Parameters.AddWithValue("@p_LineNum", LineNum)
						command.Parameters.AddWithValue("@p_ItemId", ItemId)
						command.Parameters.AddWithValue("@p_Quantity", Quantity)
						command.Parameters.AddWithValue("@p_UnitPrice", UnitPrice)
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            If reader.Read() Then

                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("LineItemInsert")
                        Throw
                    End Try
                End Using
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Update()
        Const commandText As String = "UPDATE [dbo].[LineItem]  SET [ItemId] = @p_ItemId, [Quantity] = @p_Quantity, [UnitPrice] = @p_UnitPrice WHERE [OrderId] = @p_OrderId AND [LineNum] = @p_LineNum"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "LineItemUpdate")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", OrderId)
						command.Parameters.AddWithValue("@p_LineNum", LineNum)
						command.Parameters.AddWithValue("@p_ItemId", ItemId)
						command.Parameters.AddWithValue("@p_Quantity", Quantity)
						command.Parameters.AddWithValue("@p_UnitPrice", UnitPrice)
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
                        transaction.Rollback("LineItemUpdate")
                        Throw
                    End Try
                End Using
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_DeleteSelf()
        DataPortal_Delete(new LineItemCriteria(OrderId, LineNum))
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Sub DataPortal_Delete(ByVal criteria As LineItemCriteria)
        Dim commandText As String = String.Format("DELETE FROM [dbo].[LineItem] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "LineItemDelete")
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
                        transaction.Rollback("LineItemDelete")
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
    
    Private Sub Child_Fetch(ByVal criteria As LineItemCriteria)
        Dim commandText As String = String.Format("SELECT [OrderId], [LineNum], [ItemId], [Quantity], [UnitPrice] FROM [dbo].[LineItem] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'LineItem' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        MarkAsChild()
    End Sub

    Private Sub Child_Insert()
        Const commandText As String = "INSERT INTO [dbo].[LineItem] ([OrderId], [LineNum], [ItemId], [Quantity], [UnitPrice]) VALUES (@p_OrderId, @p_LineNum, @p_ItemId, @p_Quantity, @p_UnitPrice)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "LineItemInsert")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", OrderId)
						command.Parameters.AddWithValue("@p_LineNum", LineNum)
						command.Parameters.AddWithValue("@p_ItemId", ItemId)
						command.Parameters.AddWithValue("@p_Quantity", Quantity)
						command.Parameters.AddWithValue("@p_UnitPrice", UnitPrice)
                    command.Transaction = transaction

                    Try
                        Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                            If reader.Read() Then

                            End If
                        End Using

                        transaction.Commit()
                    Catch generatedExceptionName As Exception
                        transaction.Rollback("LineItemInsert")
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub Child_Update()
        Const commandText As String = "UPDATE [dbo].[LineItem]  SET [ItemId] = @p_ItemId, [Quantity] = @p_Quantity, [UnitPrice] = @p_UnitPrice WHERE [OrderId] = @p_OrderId AND [LineNum] = @p_LineNum"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using transaction As SqlTransaction = connection.BeginTransaction(IsolationLevel.ReadCommitted, "LineItemUpdate")
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", OrderId)
						command.Parameters.AddWithValue("@p_LineNum", LineNum)
						command.Parameters.AddWithValue("@p_ItemId", ItemId)
						command.Parameters.AddWithValue("@p_Quantity", Quantity)
						command.Parameters.AddWithValue("@p_UnitPrice", UnitPrice)
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
                        transaction.Rollback("LineItemUpdate")
                        Throw
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub Child_DeleteSelf()
        DataPortal_Delete(new LineItemCriteria(OrderId, LineNum))
    End Sub

    #End Region

    Private Sub Map(ByVal reader As SafeDataReader)
        LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"))
        LoadProperty(_lineNumProperty, reader.GetInt32("LineNum"))
        LoadProperty(_itemIdProperty, reader.GetString("ItemId"))
        LoadProperty(_quantityProperty, reader.GetInt32("Quantity"))
        LoadProperty(_unitPriceProperty, reader.GetDecimal("UnitPrice"))

        LoadProperty(_orderIdProperty, reader.GetInt32("OrderId"))

        MarkOld()
    End Sub
End Class