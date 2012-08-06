Imports System
Imports System.Collections.Generic
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
<DefaultClassOptions> _
Public Partial Class Taxes
  Inherits DevExpress.Persistent.BaseImpl.BaseObject
  Private TaxId_renamed As String
  Private TaxName_renamed As String
  Private TaxPercent_renamed As Double
  Public Sub New(ByVal session As Session)
    MyBase.New(session)
  End Sub
  Public Property TaxCode() As String
    Get
      Return TaxId_renamed
    End Get
    Set(ByVal value As String)
      SetPropertyValue("Tax Code", TaxId_renamed, value)
    End Set
  End Property
  Public Property TaxName() As String
    Get
      Return TaxName_renamed
    End Get
    Set(ByVal value As String)
      SetPropertyValue("Tax Description", TaxName_renamed, value)
    End Set
  End Property
  Public Property TaxPercent() As Double
    Get
      Return TaxPercent_renamed
    End Get
    Set(ByVal value As Double)
      SetPropertyValue("Tax Percent", TaxPercent_renamed, value)
    End Set
  End Property
End Class
