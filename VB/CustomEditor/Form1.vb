Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraGrid.Views.Base

Namespace DXDemos

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim tbl As DataTable = New DataTable()
            tbl.Columns.Add("ID", GetType(Integer))
            tbl.Columns.Add("Name", GetType(String))
            tbl.Columns.Add("Payment", GetType(Decimal))
            For i As Integer = 1 To 10 - 1
                tbl.Rows.Add(i, String.Format("Item {0}", i), i * 15.5)
            Next

            gridControl1.DataSource = tbl
            gridView1.ActiveFilterString = "[Payment] Between (50, 120)"
        End Sub

#Region "#1"
        Private Sub gridView1_FilterEditorCreated(ByVal sender As Object, ByVal e As FilterControlEventArgs)
            AddHandler e.FilterControl.BeforeShowValueEditor, New ShowValueEditorEventHandler(AddressOf FilterControl_BeforeShowValueEditor)
        End Sub

        Private Sub FilterControl_BeforeShowValueEditor(ByVal sender As Object, ByVal e As ShowValueEditorEventArgs)
            If Not Equals(e.CurrentNode.FirstOperand.PropertyName, "Payment") Then Return
            Dim item As RepositoryItemTextEdit = Nothing
            If e.FocusedElementIndex = 2 Then
                item = New RepositoryItemSpinEdit()
            Else
                item = New RepositoryItemCalcEdit()
            End If

            item.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            item.Mask.EditMask = "c"
            e.CustomRepositoryItem = item
        End Sub
#End Region  ' #1
    End Class
End Namespace
