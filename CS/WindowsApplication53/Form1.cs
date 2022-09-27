using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication53 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
            pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
        }
        private void PopulateTable() {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today, 7, 3 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 4, 1 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 12, 6 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 14, 7 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 11, 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 10, 3 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 4, 5 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2, 8 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 3, 9 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1, 5 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 8, 3 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 });
        }

        private void pivotGridControl1_CustomAppearance(object sender, DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs e) {
            int groupIndex = GetGroupIndex((PivotGridControl)sender, e);
            if (groupIndex % 2 == 0)
                e.Appearance.BackColor = Color.GreenYellow;
        }

        private int GetGroupIndex(PivotGridControl pivot, PivotCustomAppearanceEventArgs e) {
            PivotGridField[] columnFields = pivot.GetFieldsByArea(PivotArea.ColumnArea).ToArray();
            int groupIndex = -1;
            object[] previous = new object[ columnFields.Length ];
            object[] current = new object[columnFields.Length]; 
            GetValuesByIndex(pivot, columnFields, previous, 0);
            for (int i = 1; i <= e.ColumnIndex ; i++) {
                GetValuesByIndex(pivot, columnFields, current, i);
                if (! ValuesEquals( previous,current)) {
                    groupIndex++;
                    current.CopyTo(previous, 0);
                }
            }
            List<object> o = new List<object>();
            return groupIndex;
        }

        private bool ValuesEquals(object[] previous, object[] current) {
            for (int i = 0; i < previous.Length ; i++) {
                if (!Equals(previous[i], current[i]))
                    return false;
            }
            return true;
        }

        private void GetValuesByIndex(PivotGridControl pivot, PivotGridField[] fields, object[] current, int index) {
            for (int i = 0; i < fields.Length ; i++) {
                current[i] = pivot.GetFieldValue(fields[i], index);
            }
        }
    }
}
