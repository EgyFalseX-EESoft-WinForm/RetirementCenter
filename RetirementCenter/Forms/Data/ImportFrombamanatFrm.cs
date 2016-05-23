using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraSplashScreen;

namespace RetirementCenter
{
    public partial class ImportFrombamanatFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.dsbamanatTableAdapters.Sheet1TableAdapter adpAccess = new DataSources.dsbamanatTableAdapters.Sheet1TableAdapter();
        DataSources.dsRetirementCenterTableAdapters.for_amanat_bankTableAdapter adpSql = new DataSources.dsRetirementCenterTableAdapters.for_amanat_bankTableAdapter();

        public ImportFrombamanatFrm()
        {
            InitializeComponent();
        }
        private void ActivePriv()
        {
            return;//ActivePrivReady
            bool Selecting = false, Inserting = false, Updateing = false, Deleting = false;
            SQLProvider.GetFormPriv(this.Name, ref Selecting, ref Inserting, ref  Updateing, ref  Deleting);

            if (Inserting || Updateing)
                btnImport.Visible = true;
            else
                btnImport.Visible = false;
        }
        private void ImportFromWebFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRetirementCenter.CdDofaatAmanat' table. You can move, or remove it, as needed.
            this.cdDofaatAmanatTableAdapter.Fill(this.dsRetirementCenter.CdDofaatAmanat);
            ActivePriv();
            //if (!File.Exists(Program.WebDB))
            //{
            //    groupControlInfo.Text = "قاعدة البيانات غير موجودة";
            //    groupControlInfo.Enabled = false;
            //    groupControlOp.Enabled = false;
            //    return;
            //}

            lblCounter.Text = adpAccess.GetCount().ToString();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!dxvp_NotBlank.Validate() || !dxvpIsBigerDate.Validate())
                return;
            if (msgDlg.Show("هل انت متأكد؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                return;
            System.Threading.ThreadPool.QueueUserWorkItem((o) =>
            {
                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImport.Enabled = false;
                }));

                adpAccess.Fill(dsbamanat.Sheet1);
                adpSql.DeleteAll();

                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.Properties.Maximum = dsbamanat.Sheet1.Count;
                    pbc.EditValue = 0;
                }));
                try
                {
                    foreach (DataSources.dsbamanat.Sheet1Row item in dsbamanat.Sheet1.Rows)
                    {
                        DataSources.dsRetirementCenter.for_amanat_bankRow row = (DataSources.dsRetirementCenter.for_amanat_bankRow)dsRetirementCenter.for_amanat_bank.Newfor_amanat_bankRow();

                        row.amount = item.amount;
                        row.pan = item.pan;
                        row.tt = item.amount + 3;

                        dsRetirementCenter.for_amanat_bank.Addfor_amanat_bankRow(row);
                        adpSql.Update(row);
                        dsRetirementCenter.for_amanat_bank.AcceptChanges();

                        pbc.Invoke(new MethodInvoker(() =>
                        {
                            pbc.EditValue = Convert.ToInt32(pbc.EditValue) + 1;
                        }));
                    }
                    Program.ShowMsg("تم الاستيراد " + Environment.NewLine + pbc.EditValue.ToString(), false, this, true);
                    Program.Logger.LogThis("تم الاستيراد ", Text, FXFW.Logger.OpType.success, null, null, this);
                }
                catch (Exception ex)
                {
                    this.ParentForm.Invoke(new MethodInvoker(() =>
                    {
                        Program.ShowMsg(Misc.Misc.ExceptionMessage(ex), true, this, true);
                        Program.Logger.LogThis(null, Text, FXFW.Logger.OpType.fail, ex, null, this);
                    }));
                }
                int allImportedRow = Convert.ToInt32(pbc.EditValue);
                pbc.Invoke(new MethodInvoker(() =>
                {
                    pbc.EditValue = 0;
                }));
                if (msgDlg.Show("تم استيراد " + allImportedRow.ToString() + Environment.NewLine + "هل ترغب في الاستمرار؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                int updatedMem = adpSql.Update1();
                int updatedwar = adpSql.Update2();
                int nullpantypeCount = (int)adpSql.GetNullpantypeCount();
                if (msgDlg.Show("تم تحديث " + updatedMem + " عضو " + Environment.NewLine + "تم تحديث "  + updatedwar + " وريث " + Environment.NewLine + "هل ترغب في الاستمرار؟", msgDlg.msgButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;
                ///////////////
                string msg = string.Empty;
                int update3Result = adpSql.Update3(deGetback.DateTime, Convert.ToInt32(lueDof.EditValue), deSendbankDate.DateTime);
                msg += "تم تحديث " + update3Result + " من جدول tblmemberbank";
                int update4Result = adpSql.Update4(Convert.ToInt32(lueDof.EditValue), deSendbankDate.DateTime);
                msg += Environment.NewLine + "تم تحديث " + update4Result + " لحقل okok ";
                int update5Result = adpSql.Update5();
                msg += Environment.NewLine + "تم تحديث yasref ل " + update5Result + " عضو";
                int insert1Result = adpSql.Insert1(deGetback.DateTime, Convert.ToInt16(Program.UserInfo.UserId));
                msg += Environment.NewLine + "تم اضافة " + insert1Result + " في جدول TBLNoSarfDetels";

                btnImport.Invoke(new MethodInvoker(() =>
                {
                    btnImport.Enabled = true;
                }));

                msgDlg.Show(msg, msgDlg.msgButtons.Close);
            });

        }
        
    }
}