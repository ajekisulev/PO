Imports System
Imports System.Security.Principal
Imports Microsoft.VisualBasic

Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Base.Security
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Imports DevExpress.ExpressApp.Security.Strategy

Public Class Updater
    Inherits DevExpress.ExpressApp.Updating.ModuleUpdater
    Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
        MyBase.New(objectSpace, currentDBVersion)
    End Sub

    Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
        MyBase.UpdateDatabaseAfterUpdateSchema()

        Dim adminRole As SecuritySystemRoleBase = ObjectSpace.FindObject(Of SecuritySystemRole)(New BinaryOperator("Name", "Administrative"))
        If adminRole Is Nothing Then
            adminRole = ObjectSpace.CreateObject(Of SecuritySystemRole)()
            adminRole.Name = "Administrative"
            adminRole.IsAdministrative = True

            Dim userTypePermission As SecuritySystemTypePermissionObject = ObjectSpace.CreateObject(Of SecuritySystemTypePermissionObject)()
            userTypePermission.TargetType = GetType(SecuritySystemUser)

            Dim currentUserObjectPermission As SecuritySystemObjectPermissionsObject = ObjectSpace.CreateObject(Of SecuritySystemObjectPermissionsObject)()
            currentUserObjectPermission.Criteria = "[Oid] = CurrentUserId()"
            currentUserObjectPermission.AllowNavigate = True
            currentUserObjectPermission.AllowRead = True
            userTypePermission.ObjectPermissions.Add(currentUserObjectPermission)
            adminRole.TypePermissions.Add(userTypePermission)

            Dim user1 As SecuritySystemUser = ObjectSpace.FindObject( _
Of SecuritySystemUser)(New BinaryOperator("UserName", "Admin"))
            If user1 Is Nothing Then
                user1 = ObjectSpace.CreateObject(Of SecuritySystemUser)()
                user1.UserName = "Admin"
                ' Set a password if the standard authentication type is used 
                user1.SetPassword("Test")
            End If

            user1.Roles.Add(adminRole)

        End If

    End Sub

End Class
