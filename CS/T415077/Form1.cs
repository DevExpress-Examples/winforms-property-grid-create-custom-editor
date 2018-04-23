using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid.Rows;
using System;

namespace T415077 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            Data.File file = new Data.File() { Path = "C:\\Home", Path2 = "C:\\Public" };
            this.propertyGridControl1.SelectedObject = file;
        }
        void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            this.openFileDialog1.ShowDialog();
        }
        private void Form1_Shown(object sender, EventArgs e) {
            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.ButtonClick += edit_ButtonClick;
            (this.propertyGridControl1.Rows[0] as CategoryRow).ChildRows["rowPath2"].Properties.RowEdit = edit;
        }
    }
}
