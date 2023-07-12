using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public Form checkExist(Type ftype)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void barBtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormLogin));
            if (form != null)
                form.Activate();
            else
            {
                
                FormLogin childForm = new FormLogin();
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void butt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
