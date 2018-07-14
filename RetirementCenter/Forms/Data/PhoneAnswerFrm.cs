using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class PhoneAnswerFrm : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext() { ObjectTrackingEnabled = false };
        public PhoneAnswerFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            LSMSDATA.QueryableSource = dsLinq.Users;
            // TODO: This line of code loads data into the 'dsRetirementCenter.phone_answer' table. You can move, or remove it, as needed.
            this.phone_answerTableAdapter.Fill(this.dsRetirementCenter.phone_answer);
        }
        private void RefreshData()
        {
            LoadData();
        }
        private void DofatSarfActivityFrm_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PhoneAnswerAddFrm frm = new PhoneAnswerAddFrm();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshData();
                //btnAdd_Click(btnAdd, EventArgs.Empty);
            }
        }
    

    }
}