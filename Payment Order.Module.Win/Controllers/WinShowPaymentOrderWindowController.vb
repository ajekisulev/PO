Imports DevExpress.XtraEditors
Imports Payment_Order.Module.Controllers
Imports DevExpress.ExpressApp.Win

Namespace Controllers
    Public Class WinShowPaymentOrderWindowController
        Inherits ShowPaymentOrderController
        Protected Overrides Sub ShowCustomForm()
            Dim form As XtraForm = TryCast(DevExpress.Persistent.Base.ReflectionHelper.CreateObject("Payment_Order.Win.Controls.PaymentOrder"), XtraForm)
            'Initializing a form when it is invoked from a controller.
            form.MdiParent = WinWindow.LastActiveExplorer
            form.Show()
        End Sub
    End Class
End Namespace