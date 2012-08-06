Imports Microsoft.VisualBasic
Imports System
Imports Xpand

Partial Public Class Payment_OrderWindowsFormsModule
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
        '
        'Payment_OrderWindowsFormsModule
        '
        Me.RequiredModuleTypes.Add(GetType(Payment_Order.[Module].Payment_OrderModule))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.AuditTrail.AuditTrailModule))

        '       Me.RequiredModuleTypes.Add(GetType(Xpand.ExpressApp.ImportWizard.Win.ImportWizardWindowsFormsModule))

    End Sub

#End Region
End Class
