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

namespace QLNS.Add
{
    public partial class AddBoPhan : Form
    {
        TblBoPhan data = new TblBoPhan();
        public static int ADD = 0;
        public static int EDIT = 1;
        int mode = -1;
        Show.DanhSachBoPhan dsbp;
        public AddBoPhan()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }
        public AddBoPhan(TblBoPhan data,string title, Show.DanhSachBoPhan dsbp)
        {
            InitializeComponent();
            btnSave.Enabled = false;
            this.Text = title;
            this.data = data;
            this.dsbp = dsbp;
            init();
        }
        public void init()
        {
            if(data !=null)
            {
                mode = EDIT;
                maBPTB.Text = data.MaBophan;
                tenBPTB.Text = data.TenBoPhan;
                ghiChu.Text = data.GhiChu;
                maBPTB.Enabled = false;
            }
            else
            {
                mode = ADD;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TblBoPhan data = new TblBoPhan();
            
            data.MaBophan = maBPTB.Text.ToString().Trim();
            data.TenBoPhan = tenBPTB.Text.ToString().Trim();
            data.GhiChu = ghiChu.Text.ToString().Trim();
            if (mode == ADD)
            {
                Result<TblBoPhan> result = new BoPhanController().addBoPhan(data);
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
            else if(mode == EDIT)
            {
                Result<TblBoPhan> result = new BoPhanController().updateBoPhan(data);
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



        }

        private void maBPTB_TextChanged(object sender, EventArgs e)
        {
            if(maBPTB.Text.ToString() == null|| maBPTB.Text.ToString() =="" || tenBPTB.Text.ToString() == null || tenBPTB.Text.ToString() == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void tenBPTB_TextChanged(object sender, EventArgs e)
        {
            if (tenBPTB.Text.ToString() == null || tenBPTB.Text.ToString() == ""|| maBPTB.Text.ToString() == null || maBPTB.Text.ToString() == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }
    }
}
