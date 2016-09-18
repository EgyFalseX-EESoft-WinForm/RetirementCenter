using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RetirementCenter.Forms.Data
{
    public partial class TBLNoSarfWarsaInfo : DevExpress.XtraEditors.XtraForm
    {
        DataSources.Linq.dsTeachersUnionViewsDataContext dsLinq = new DataSources.Linq.dsTeachersUnionViewsDataContext();
        public TBLNoSarfWarsaInfo(int PersonId)
        {
            InitializeComponent();
            LSMSUsers.QueryableSource = from q in dsLinq.Users select q;
            // TODO: This line of code loads data into the 'dsRetirementCenter.TBLNoSarfWarsa' table. You can move, or remove it, as needed.
            this.tBLNoSarfWarsaTableAdapter.FillByPersonId(this.dsRetirementCenter.TBLNoSarfWarsa, PersonId);
        }

        private void TBLNoSarfWarsaInfo_Load(object sender, EventArgs e)
        {
           

        }
    }
}