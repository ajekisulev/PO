Imports System
Imports System.Collections.Generic
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
<DefaultClassOptions> _
Public Partial Class Currency
  Inherits DevExpress.Persistent.BaseImpl.BaseObject
    Private _status As Payment_Order.Module.Status
  Private _currencySubunit As System.String
  Private _currencyName As System.String
  Private _currencyCode As System.String
  Public Sub New(ByVal session As Session)
    MyBase.New(session)
  End Sub
  <DevExpress.Xpo.SizeAttribute(3)> _
  Public Property CurrencyCode() As System.String
    Get
      Return _currencyCode
    End Get
    Set
      SetPropertyValue("CurrencyCode", _currencyCode, value)
    End Set
  End Property
  Public Property CurrencyName() As System.String
    Get
      Return _currencyName
    End Get
    Set
      SetPropertyValue("CurrencyName", _currencyName, value)
    End Set
  End Property
  Public Property CurrencySubunit() As System.String
    Get
      Return _currencySubunit
    End Get
    Set
      SetPropertyValue("CurrencySubunit", _currencySubunit, value)
    End Set
  End Property
    Public Property Status() As Payment_Order.Module.Status
        Get
            Return _status
        End Get
        Set(value As Payment_Order.Module.Status)
            If _status Is Value Then
                Return
            End If
            Dim prevStatus As Payment_Order.Module.Status = _status
            _status = Value
            If IsLoading Then
                Return
            End If
            If prevStatus IsNot Nothing AndAlso prevStatus.Currency Is Me Then
                prevStatus.Currency = Nothing
            End If
            If _status IsNot Nothing Then
                _status.Currency = Me
            End If
            OnChanged("Status")
        End Set
    End Property
End Class
