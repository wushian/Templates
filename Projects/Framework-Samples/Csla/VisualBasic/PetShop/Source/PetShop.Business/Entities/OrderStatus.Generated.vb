'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatus.vb.
'
'     Template path: EditableRoot.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
Public Partial Class OrderStatus 
    Inherits BusinessBase(Of OrderStatus)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method 
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)
    End Sub

    #End Region
    
    #Region "Validation Rules"
    
    Protected Overrides Sub AddBusinessRules()
    
        If AddBusinessValidationRules() Then Exit Sub
       
        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _statusProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_statusProperty, 2))
    End Sub
    
    #End Region
    
    #Region "Business Methods"


    
    Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As OrderStatus) p.OrderId)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property OrderId() As Integer
        Get 
            Return GetProperty(_orderIdProperty)
        End Get
        Set (ByVal value As Integer)
            SetProperty(_orderIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of Integer) = RegisterProperty(Of Integer)(Function(p As OrderStatus) p.LineNum)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property LineNum() As Integer
        Get 
            Return GetProperty(_lineNumProperty)
        End Get
        Set (ByVal value As Integer)
            SetProperty(_lineNumProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _timestampProperty As PropertyInfo(Of SmartDate) = RegisterProperty(Of SmartDate)(Function(p As OrderStatus) p.Timestamp)
    Public Property Timestamp() As SmartDate
        Get 
            Return GetProperty(_timestampProperty)
        End Get
        Set (ByVal value As SmartDate)
            SetProperty(_timestampProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _statusProperty As PropertyInfo(Of String) = RegisterProperty(Of String)(Function(p As OrderStatus) p.Status)
    Public Property Status() As String
        Get 
            Return GetProperty(_statusProperty)
        End Get
        Set (ByVal value As String)
            SetProperty(_statusProperty, value)
        End Set
    End Property
    
    Private Shared ReadOnly _orderProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As OrderStatus) p.Order, Csla.RelationshipTypes.LazyLoad)
    Public ReadOnly Property Order() As Order
        Get
        
            If Not(FieldManager.FieldExists(_orderProperty))
                If (Me.IsNew) Then
                    LoadProperty(_orderProperty, Order.NewOrder())
                Else
                    LoadProperty(_orderProperty, Order.GetOrder(OrderId))
                End If
            End If
            
            Return GetProperty(_orderProperty) 
        End Get
    End Property
    
    #End Region
    
    #Region "Factory Methods"
    
    Public Shared Function NewOrderStatus() As OrderStatus 
        Return DataPortal.Create(Of OrderStatus)()
    End Function
    
    Public Shared Function GetOrderStatus(ByVal orderId As Integer, ByVal lineNum As Integer) As OrderStatus         
        Return DataPortal.Fetch(Of OrderStatus)(New OrderStatusCriteria(orderId, lineNum))
    End Function

    Public Shared Function GetOrderStatus(ByVal orderId As Integer) As OrderStatus 
        Dim criteria As New OrderStatusCriteria()
        criteria.OrderId = orderId
        
        Return DataPortal.Fetch(Of OrderStatus)(criteria)
    End Function

    Public Shared Sub DeleteOrderStatus(ByVal orderId As Integer, ByVal lineNum As Integer)
        DataPortal.Delete(New OrderStatusCriteria(orderId, lineNum))
    End Sub

    #End Region
    
    #Region "Protected Overriden Method(s)"
    
    ' NOTE: This is needed for Composite Keys. 
    Private ReadOnly _guidID As Guid = Guid.NewGuid()
    Protected Overrides Function GetIdValue() As Object
        Return _guidID
    End Function
    
    #End Region
End Class
