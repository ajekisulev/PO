Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports System.Data.SqlClient

Namespace Controls
    Partial Public Class PaymentOrder
        Inherits DevExpress.XtraEditors.XtraForm
        Public Sub New()
            InitializeComponent()
        End Sub
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
        Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl

        Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
            XtraMessageBox.Show("here i am")
        End Sub
        Private Sub InitializeComponent()
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GroupControl1
            '
            Me.GroupControl1.Controls.Add(Me.TextEdit1)
            Me.GroupControl1.Location = New System.Drawing.Point(35, 12)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(369, 110)
            Me.GroupControl1.TabIndex = 0
            Me.GroupControl1.Text = "GroupControl1"
            '
            'TextEdit1
            '
            Me.TextEdit1.Location = New System.Drawing.Point(20, 39)
            Me.TextEdit1.Name = "TextEdit1"
            Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
            Me.TextEdit1.TabIndex = 0
            '
            'TextEdit2
            '
            Me.TextEdit2.Location = New System.Drawing.Point(485, 49)
            Me.TextEdit2.Name = "TextEdit2"
            Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
            Me.TextEdit2.TabIndex = 1
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Location = New System.Drawing.Point(114, 178)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(162, 23)
            Me.SimpleButton1.TabIndex = 2
            Me.SimpleButton1.Text = "SimpleButton1"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Location = New System.Drawing.Point(342, 186)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(125, 23)
            Me.SimpleButton2.TabIndex = 3
            Me.SimpleButton2.Text = "SimpleButton2"
            '
            'PaymentOrder
            '
            Me.ClientSize = New System.Drawing.Size(624, 349)
            Me.Controls.Add(Me.SimpleButton2)
            Me.Controls.Add(Me.SimpleButton1)
            Me.Controls.Add(Me.TextEdit2)
            Me.Controls.Add(Me.GroupControl1)
            Me.Name = "PaymentOrder"
            Me.Text = "Payment Order"
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
            '    Dim command As SqlCommand = New SqlCommand("select getdate()", CType(, SqlConnection))
            '    cachedTimestamp = CDate(command.ExecuteScalar())
        End Sub
    End Class

End Namespace