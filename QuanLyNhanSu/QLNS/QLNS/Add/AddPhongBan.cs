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
    public partial class AddPhongBan : Form
    {

        TblPhongBan data = new TblPhongBan();
        public static int ADD = 0;
        public static int EDIT = 1;
        int mode = -1;
        Show.DanhSachPhongBan dsbp;

        public AddPhongBan()
        {
            InitializeComponent();
        }
        public AddPhongBan(TblPhongBan data, string title, Show.DanhSachPhongBan dsbp)
        {
            InitializeComponent();
            this.Text = title ;
            this.data = data;
            this.dsbp = dsbp;
            init();
        }

        public void init()
        {
            List<TblBoPhan> bophan = new BoPhanController().getAllBoPhan();
            comboBox1.DataSource = bophan;
            if (data != null)
            {
                TblPhongBan temp = new PhongBanController().getOnePhongBan(data.MaPhong);
                mode = EDIT;
                maBPTB.Text = temp.MaPhong;
                tenBPTB.Text = temp.TenPhong;
                ghiChu.Text = temp.GhiChu;
                if (data.NgayTLap != null)
                    dateTimePicker1.Value = (DateTime)temp.NgayTLap;
                comboBox1.SelectedValue = temp.MaBoPhan;
            }
            else
            {
                mode = ADD;
                DateTime date = DateTime.Now;
                dateTimePicker1.Value = date;
                btnSave.Enabled = false;
            }
        }

        private void tenBPTB_TextChanged(object sender, EventArgs e)
        {
            if (maBPTB.Text.ToString() == null || maBPTB.Text.ToString() == "" || tenBPTB.Text.ToString() == null || tenBPTB.Text.ToString() == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void maBPTB_TextChanged(object sender, EventArgs e)
        {
            if (maBPTB.Text.ToString() == null || maBPTB.Text.ToString() == "" || tenBPTB.Text.ToString() == null || tenBPTB.Text.ToString() == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            TblPhongBan data = new TblPhongBan();
            data.MaPhong = maBPTB.Text.ToString().Trim();
            data.TenPhong = tenBPTB.Text.ToString().Trim();
            data.GhiChu = ghiChu.Text.ToString().Trim();
            data.MaBoPhan = comboBox1.SelectedValue.ToString();
            data.NgayTLap = dateTimePicker1.Value;
            if (mode == ADD)
            {
                Result<TblPhongBan> result = new PhongBanController().addPhongBan(data);
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
            else if (mode == EDIT)
            {
                Result<TblPhongBan> result = new PhongBanController().updatePhongBan(data);
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
