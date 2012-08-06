Imports Microsoft.VisualBasic
Imports System

Partial Public Class Payment_OrderWindowsFormsApplication
	''' <summary> 
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (Not components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

#Region "Component Designer generated code"

	''' <summary> 
	''' Required method for Designer support - do not modify 
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SecurityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
        Me.SecurityStrategyComplex1 = New DevExpress.ExpressApp.Security.SecurityStrategyComplex()
        Me.AuthenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
        Me.AuditTrailModule1 = New DevExpress.ExpressApp.AuditTrail.AuditTrailModule()
        Me.module3 = New Payment_Order.[Module].Payment_OrderModule()
        Me.module4 = New Payment_Order.[Module].Win.Payment_OrderWindowsFormsModule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=P" & _
    "ayment_Order"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SecurityStrategyComplex1
        '
        Me.SecurityStrategyComplex1.Authentication = Me.AuthenticationStandard1
        Me.SecurityStrategyComplex1.RoleType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole)
        Me.SecurityStrategyComplex1.UserType = GetType(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser)
        '
        'AuthenticationStandard1
        '
        Me.AuthenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
        '
        'AuditTrailModule1
        '
        Me.AuditTrailModule1.AuditDataItemPersistentType = GetType(DevExpress.Persistent.AuditTrail.AuditDataStoreItem)
        '
        'Payment_OrderWindowsFormsApplication
        '
        Me.ApplicationName = "Payment Order"
        Me.Connection = Me.sqlConnection1
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.SecurityModule1)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.AuditTrailModule1)
        Me.Modules.Add(Me.module4)
        Me.Security = Me.SecurityStrategyComplex1
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

	Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
	Private module3 As Global.Payment_Order.Module.Payment_OrderModule
	Private module4 As Global.Payment_Order.Module.Win.Payment_OrderWindowsFormsModule
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SecurityModule1 As DevExpress.ExpressApp.Security.SecurityModule
    Friend WithEvents SecurityStrategyComplex1 As DevExpress.ExpressApp.Security.SecurityStrategyComplex
    Friend WithEvents AuthenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard
    Friend WithEvents AuditTrailModule1 As DevExpress.ExpressApp.AuditTrail.AuditTrailModule
End Class
