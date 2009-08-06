'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.7.X CodeSmith Templates.
'	   Changes to this template will not be lost.
'
'     Template: EditableRoot.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Public Partial Class OrderStatus

	#Region "Validation Rules"
	
	''' <summary>
    ''' All custom rules need to be placed in this method.
    ''' </summary>
    ''' <Returns>Return true to override the generated rules If false generated rules will be run.</Returns>
	Protected Function AddBusinessValidationRules() As Boolean
		' TODO: add validation rules
		'ValidationRules.AddRule(RuleMethod, "")

	    Return False
	End Function
	
	#End Region
	
	#Region "Authorization Rules"
	
	Protected Overrides Sub AddAuthorizationRules()
		'Dim canWrite As String() = { "AdminUser", "RegularUser" }
        'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
        'Dim admin As String() = { "AdminUser" }

        'AuthorizationRules.AllowCreate(GetType(OrderStatus), admin)
        'AuthorizationRules.AllowDelete(GetType(OrderStatus), admin)
        'AuthorizationRules.AllowEdit(GetType(OrderStatus), canWrite)
        'AuthorizationRules.AllowGet(GetType(OrderStatus), canRead)

        'OrderId
        'AuthorizationRules.AllowWrite(_orderIdProperty, canWrite)
        'AuthorizationRules.AllowRead(_orderIdProperty, canRead)
        
        'LineNum
        'AuthorizationRules.AllowWrite(_lineNumProperty, canWrite)
        'AuthorizationRules.AllowRead(_lineNumProperty, canRead)
        
        'Timestamp
        'AuthorizationRules.AllowWrite(_timestampProperty, canWrite)
        'AuthorizationRules.AllowRead(_timestampProperty, canRead)
        
        'Status
        'AuthorizationRules.AllowWrite(_statusProperty, canWrite)
        'AuthorizationRules.AllowRead(_statusProperty, canRead)
        
	End Sub
	
	Private Shared Sub AddObjectAuthorizationRules()
		' TODO: add authorization rules
		'AuthorizationRules.AllowEdit(typeof(OrderStatus), "Role")
	End Sub
	
	#End Region
    
End Class