using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraGrid.Views.Base;

namespace DXDemos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("Payment", typeof(decimal));
            for(int i = 1; i < 10; i++)
                tbl.Rows.Add(i, string.Format("Item {0}", i), i * 15.5);
            gridControl1.DataSource = tbl;
            gridView1.ActiveFilterString = "[Payment] Between (50, 120)";
        }
        #region #1
        private void gridView1_FilterEditorCreated(object sender, FilterControlEventArgs e) {
            e.FilterControl.BeforeShowValueEditor += 
new ShowValueEditorEventHandler(FilterControl_BeforeShowValueEditor);
        }

        void FilterControl_BeforeShowValueEditor(object sender, ShowValueEditorEventArgs e) {
            if(e.CurrentNode.FirstOperand.PropertyName != "Payment") return;
            RepositoryItemTextEdit item = null;
            if(e.FocusedElementIndex == 2)
                item = new RepositoryItemSpinEdit();
            else
                item = new RepositoryItemCalcEdit();
            item.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            item.Mask.EditMask = "c";
            e.CustomRepositoryItem = item;
        }
        #endregion #1
    }
}