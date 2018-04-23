Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication255
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.treeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1, Me.treeListColumn2})
			Me.treeList1.Location = New System.Drawing.Point(104, 63)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.BeginUnboundLoad()
			Me.treeList1.AppendNode(New Object() { "11", "12"}, -1)
			Me.treeList1.AppendNode(New Object() { "21", "22"}, -1)
			Me.treeList1.AppendNode(New Object() { "1", "1"}, 1)
			Me.treeList1.AppendNode(New Object() { "2", "2"}, 2)
			Me.treeList1.AppendNode(New Object() { "3", "3"}, 2)
			Me.treeList1.AppendNode(New Object() { "31", "32"}, -1)
			Me.treeList1.AppendNode(New Object() { "1", "1"}, 5)
			Me.treeList1.AppendNode(New Object() { "2", "2"}, 6)
			Me.treeList1.AppendNode(New Object() { "3", "3"}, 7)
			Me.treeList1.EndUnboundLoad()
			Me.treeList1.OptionsView.ShowRowFooterSummary = True
			Me.treeList1.Size = New System.Drawing.Size(400, 172)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.treeList1_KeyDown);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "treeListColumn1"
			Me.treeListColumn1.FieldName = "treeListColumn1"
			Me.treeListColumn1.MinWidth = 74
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			' 
			' treeListColumn2
			' 
			Me.treeListColumn2.Caption = "treeListColumn2"
			Me.treeListColumn2.FieldName = "treeListColumn2"
			Me.treeListColumn2.Name = "treeListColumn2"
			Me.treeListColumn2.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
			Me.treeListColumn2.Visible = True
			Me.treeListColumn2.VisibleIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(640, 404)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private treeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
	End Class
End Namespace

