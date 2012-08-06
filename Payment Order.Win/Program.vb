Imports System
Imports System.Configuration
Imports System.Windows.Forms

Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Win
Imports DevExpress.LookAndFeel

Imports Payment_Order.Win
Imports Payment_Order.Module.Classes

Imports System.Security.Principal
Imports DevExpress.Persistent.AuditTrail

Public Class Program

    <STAThread()> _
    Public Shared Sub Main(ByVal arguments() As String)
#If EASYTEST Then
              DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register()
#End If

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        UserLookAndFeel.Default.SetSkinStyle("Metropolis")
        EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached
        Dim _application As Payment_OrderWindowsFormsApplication = New Payment_OrderWindowsFormsApplication()
#If EASYTEST Then
        If (Not ConfigurationManager.ConnectionStrings.Item("EasyTestConnectionString") Is Nothing) Then
            _application.ConnectionString = ConfigurationManager.ConnectionStrings.Item("EasyTestConnectionString").ConnectionString
        End If
#End If
        If (Not ConfigurationManager.ConnectionStrings.Item("ConnectionString") Is Nothing) Then
            _application.ConnectionString = ConfigurationManager.ConnectionStrings.Item("ConnectionString").ConnectionString
        End If
        '     If ConfigurationManager.ConnectionStrings("ConnectionString") IsNot Nothing Then
        '         _application.ConnectionString = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
        '     End If
        '    DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.Register()
        '    _application.ConnectionString = DevExpress.ExpressApp.Xpo.InMemoryDataStoreProvider.ConnectionString

        If System.Diagnostics.Debugger.IsAttached Then
            _application.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways
        End If
        Try
            AuditTrailService.Instance.ObjectAuditingMode = ObjectAuditingMode.Full
            'Subscribe to QueryCurrentUserName event of the AuditTrailService's instance 
            AddHandler AuditTrailService.Instance.QueryCurrentUserName, _
            AddressOf Instance_QueryCurrentUserName
            Dim timeStampStrategy As IAuditTimestampStrategy = New MSSqlServerTimestampStrategy()
            AuditTrailService.Instance.TimestampStrategy = timeStampStrategy
            _application.Setup()
            _application.Start()
        Catch e As Exception
            _application.HandleException(e)
        End Try

    End Sub
    Shared Sub Instance_QueryCurrentUserName(ByVal sender As Object, ByVal e As QueryCurrentUserNameEventArgs)
        e.CurrentUserName = SecuritySystem.CurrentUserName & " (" & WindowsIdentity.GetCurrent().Name & ")"
    End Sub
End Class
