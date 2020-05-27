Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraGrid.Views.Base

Namespace DXDemos
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim tbl As New DataTable()
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("Payment", GetType(Decimal))
			For i As Integer = 1 To 9
				tbl.Rows.Add(i, String.Format("Item {0}", i), i * 15.5)
			Next i
			gridControl1.DataSource = tbl
			gridView1.ActiveFilterString = "[Payment] Between (50, 120)"
		End Sub
		#Region "#1"
		Private Sub gridView1_FilterEditorCreated(ByVal sender As Object, ByVal e As FilterControlEventArgs) Handles gridView1.FilterEditorCreated
			AddHandler e.FilterControl.BeforeShowValueEditor, AddressOf FilterControl_BeforeShowValueEditor
		End Sub

		Private ReadOnly spinEdit As New RepositoryItemSpinEdit()
		Private ReadOnly calcEdit As New RepositoryItemCalcEdit()
		Private Sub FilterControl_BeforeShowValueEditor(ByVal sender As Object, ByVal e As ShowValueEditorEventArgs)
			If e.CurrentNode.FirstOperand.PropertyName <> "Payment" Then
				Return
			End If
			Dim item As RepositoryItemTextEdit = Nothing
			If e.FocusedElementIndex = 2 Then
				item = spinEdit
			Else
				item = calcEdit
			End If
			item.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			item.Mask.EditMask = "c"
			e.CustomRepositoryItem = item
		End Sub
		#End Region ' #1
	End Class
End Namespace