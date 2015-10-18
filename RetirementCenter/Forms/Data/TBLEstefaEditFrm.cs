using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLEstefaEditFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        DataSources.dsRetirementCenterTableAdapters.TBLEstefaTableAdapter adp = new DataSources.dsRetirementCenterTableAdapters.TBLEstefaTableAdapter();
        DataSources.dsRetirementCenter.TBLEstefaDataTable tbl = new DataSources.dsRetirementCenter.TBLEstefaDataTable();

        public TBLEstefaEditFrm(int id, DateTime date)
        {
            InitializeComponent();
            LSMSEmp.QueryableSource = from q in dsLinq.vTBLMashats select q;

            tbl = adp.GetDataByID(id, date);
            lueMMashatId.DataBindings.Add(new Binding("EditValue", tbl[0], "MMashatId"));
            tbestefamem.DataBindings.Add(new Binding("EditValue", tbl[0], "estefamem"));
            deestefadate.DataBindings.Add(new Binding("EditValue", tbl[0], "estefadate"));
            cefinished.DataBindings.Add(new Binding("EditValue", tbl[0], "finished"));
        }
        public TBLEstefaEditFrm()
        {
            InitializeComponent();
            LSMSEmp.QueryableSource = from q in dsLinq.vTBLMashats select q;

            DataSources.dsRetirementCenter.TBLEstefaRow row = tbl.NewTBLEstefaRow();
            row.userin = Program.UserInfo.UserId;
            row.datein = row.estefadate = SQLProvider.ServerDateTime();
            row.MMashatId = -1; row.finished = false;
            row.estefamem = string.Empty;
            tbl.AddTBLEstefaRow(row);

            lueMMashatId.DataBindings.Add(new Binding("EditValue", tbl[0], "MMashatId"));
            tbestefamem.DataBindings.Add(new Binding("EditValue", tbl[0], "estefamem"));
            deestefadate.DataBindings.Add(new Binding("EditValue", tbl[0], "estefadate"));
            cefinished.DataBindings.Add(new Binding("EditValue", tbl[0], "finished"));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbestefamem.EditValue == null || tbestefamem.EditValue.ToString() == string.Empty)
                return;
            try
            {
                tbl[0].EndEdit();
                adp.Update(tbl);
                //adp.UpdateAdminRemark(tbestefamem.EditValue.ToString(), cefinished.Checked, _remarkid);
                Program.ShowMsg("تم الحفظ", false, this, true);
                Program.Logger.LogThis("تم الحفظ", Text, FXFW.Logger.OpType.success, null, null, this);
                Close();
            }
            catch (Exception ex)
            {
                Program.ShowMsg(ex.Message, true, this, true);
                Program.Logger.LogThis(ex.Message, Text, FXFW.Logger.OpType.fail, ex, null, this);
            }
        }
    }
}