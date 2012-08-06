Imports System
Imports System.Collections.Generic
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
<DefaultClassOptions> _
Public Partial Class Status
  Inherits DevExpress.Persistent.BaseImpl.BaseObject
    Private _currency As Payment_Order.Module.Currency
  Private _statusName As System.String
  Private _statusCode As System.String
  Public Sub New(ByVal session As Session)
    MyBase.New(session)
  End Sub
  Public Property StatusCode() As System.String
    Get
      Return _statusCode
    End Get
    Set
      SetPropertyValue("StatusCode", _statusCode, Value)
    End Set
  End Property
  Public Property StatusName() As System.String
    Get
      Return _statusName
    End Get
    Set
      SetPropertyValue("StatusName", _statusName, value)
    End Set
  End Property
    Public Property Currency() As Payment_Order.Module.Currency
        Get
            Return _currency
        End Get
        Set(value As Payment_Order.Module.Currency)
            If _currency Is Value Then
                Return
            End If
            Dim prevCurrency As Payment_Order.Module.Currency = _currency
            _currency = Value
            If IsLoading Then
                Return
            End If
            If prevCurrency IsNot Nothing AndAlso prevCurrency.Status Is Me Then
                prevCurrency.Status = Nothing
            End If
            If _currency IsNot Nothing Then
                _currency.Status = Me
            End If
            OnChanged("Currency")
        End Set
    End Property
End Class
