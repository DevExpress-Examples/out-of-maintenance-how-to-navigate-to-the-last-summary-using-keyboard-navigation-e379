Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.ViewInfo

Namespace WindowsApplication255
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			treeList1.ExpandAll()
		End Sub

		Private Sub treeList1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles treeList1.KeyDown
			Dim ri As RowInfo = TryCast(treeList1.ViewInfo.RowsInfo.Rows(treeList1.ViewInfo.RowsInfo.Rows.Count - 1), RowInfo)
			Dim last As TreeListNode = ri.Node
			If treeList1.FocusedNode Is last AndAlso last.NextVisibleNode Is Nothing Then
				treeList1.TopVisibleNodeIndex = treeList1.GetVisibleIndexByNode(ri.Node)
			End If
		End Sub
	End Class
End Namespace