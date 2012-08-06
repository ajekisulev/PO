Imports System
Imports System.Data.SqlClient
Imports DevExpress.Xpo
Imports DevExpress.Persistent.AuditTrail
Namespace Classes
    Public Class MSSqlServerTimestampStrategy
        Implements IAuditTimestampStrategy
        Private cachedTimestamp As DateTime

#Region "IAuditTimestampStrategy Members"
        Public Function GetTimestamp(ByVal auditDataItem As AuditDataItem) As DateTime _
              Implements IAuditTimestampStrategy.GetTimestamp
            Return cachedTimestamp
        End Function
        Public Sub OnBeginSaveTransaction(ByVal session As Session) _
              Implements IAuditTimestampStrategy.OnBeginSaveTransaction
            Dim command As SqlCommand = New SqlCommand("select getdate()", _
               CType(session.Connection, SqlConnection))
            cachedTimestamp = CDate(command.ExecuteScalar())
        End Sub
#End Region

    End Class
End Namespace