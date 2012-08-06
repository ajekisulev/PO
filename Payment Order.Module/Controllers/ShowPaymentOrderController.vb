Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.SystemModule

Namespace Controllers
    Public MustInherit Class ShowPaymentOrderController
        Inherits WindowController
        Private navigationController As ShowNavigationItemController
        Public Sub New()
            TargetWindowType = WindowType.Main
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            navigationController = Frame.GetController(Of ShowNavigationItemController)()
            If navigationController IsNot Nothing Then
                AddHandler navigationController.CustomShowNavigationItem, AddressOf navigationController_CustomShowNavigationItem
            End If
        End Sub
        Protected Overrides Sub OnDeactivated()
            If navigationController IsNot Nothing Then
                RemoveHandler navigationController.CustomShowNavigationItem, AddressOf navigationController_CustomShowNavigationItem
            End If
            MyBase.OnDeactivated()
        End Sub
        Private Sub navigationController_CustomShowNavigationItem(ByVal sender As Object, ByVal e As CustomShowNavigationItemEventArgs)
            If e.ActionArguments.SelectedChoiceActionItem.Id = "PaymentOrderForm" Then
                ShowCustomForm()
                e.Handled = True
            End If
        End Sub
        Protected MustOverride Sub ShowCustomForm()
    End Class
End Namespace