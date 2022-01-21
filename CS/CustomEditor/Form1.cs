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
using DevExpress.XtraEditors.Mask;

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
            e.FilterEditor.CustomValueEditor += FilterEditor_CustomValueEditor;
        }

        readonly RepositoryItemSpinEdit spinEdit = new RepositoryItemSpinEdit();
        readonly RepositoryItemCalcEdit calcEdit = new RepositoryItemCalcEdit();

        private void FilterEditor_CustomValueEditor(object sender, CustomValueEditorArgs e) {
            if (e.Node.FirstOperand.PropertyName != "Payment") return;
            RepositoryItemTextEdit item = null;
            if (e.ElementIndex == 2)
                item = spinEdit;
            else
                item = calcEdit;
            var settings = item.MaskSettings.Configure<MaskSettings.Numeric>();
            settings.MaskExpression = "c";
            e.RepositoryItem = item;
        }
        #endregion #1
    }
}