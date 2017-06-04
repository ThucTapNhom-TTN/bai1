using ConsoleApplication1.Entity;
using Controller;
using Controller.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Delete
{
    public partial class DeletePhongBan : Form
    {
        TblPhongBan bophan;
        Show.DanhSachPhongBan dsbp;
        public DeletePhongBan()
        {
            InitializeComponent();
        }
        public DeletePhongBan(string text, TblPhongBan bophan, Show.DanhSachPhongBan dsbp)
        {
            InitializeComponent();
            this.bophan = bophan;
            this.dsbp = dsbp;
            init();
        }
        public void init()
        {
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Result<TblPhongBan> result = new PhongBanController().deletePhongBan(bophan.MaPhong);
            if (result.Success)
            {
                this.Hide();
                dsbp.getData();
                MessageBox.Show(result.Message.ToString());
            }
            else
            {
                MessageBox.Show(result.Message.ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
