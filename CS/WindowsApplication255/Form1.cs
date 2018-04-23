using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.ViewInfo;

namespace WindowsApplication255
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeList1.ExpandAll();
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            RowInfo ri = treeList1.ViewInfo.RowsInfo.Rows[treeList1.ViewInfo.RowsInfo.Rows.Count - 1] as RowInfo;
            TreeListNode last = ri.Node; 
            if (treeList1.FocusedNode == last && last.NextVisibleNode == null)
                treeList1.TopVisibleNodeIndex = treeList1.GetVisibleIndexByNode(ri.Node);
        }
    }
}