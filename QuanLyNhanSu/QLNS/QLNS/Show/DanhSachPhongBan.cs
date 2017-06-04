using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNS.Common;
using ConsoleApplication1.Entity;
using Controller;

namespace QLNS.Show
{
    public partial class DanhSachPhongBan : UserControl
    {
        public DanhSachPhongBan()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            init();
        }
        public void init()
        {
            getData();
            DataGridViewImageButtonSaveColumn columnSave = new DataGridViewImageButtonSaveColumn();
            dataGridView1.Columns.Add(columnSave);
            DataGridViewImageButtonDeleteColumn columnDelete = new DataGridViewImageButtonDeleteColumn();
            dataGridView1.Columns.Add(columnDelete);
            DataGridViewButtonColumn c = (DataGridViewButtonColumn)dataGridView1.Columns[4];
            c.DefaultCellStyle.ForeColor = Color.Navy;
            c.DefaultCellStyle.BackColor = Color.Green;
            DataGridViewButtonColumn c2 = (DataGridViewButtonColumn)dataGridView1.Columns[5];
            c2.DefaultCellStyle.ForeColor = Color.Navy;
            c2.DefaultCellStyle.BackColor = Color.Red;
            dataGridView1.Columns[4].HeaderText = "Sửa";
            dataGridView1.Columns[5].HeaderText = "Xóa";

        }
        public void getData()
        {
            List<TblPhongBan> data = new PhongBanController().getAllPhongBan();
            dataGridView1.DataSource = data;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[4] is DataGridViewImageButtonSaveColumn && e.RowIndex >= 0 && senderGrid.Columns[5] is DataGridViewImageButtonDeleteColumn)
            {
                switch (e.ColumnIndex)
                {
                    case 4:
                        TblPhongBan data = new TblPhongBan();
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        data.MaPhong = row.Cells[0].Value.ToString();
                        data.TenPhong = row.Cells[1].Value.ToString();
                        data.GhiChu = row.Cells[2].Value.ToString();
                        Add.AddPhongBan uc = new Add.AddPhongBan(data, "Cập nhật phòng ban", this);
                        uc.ShowDialog();
                        break;
                    case 5:
                        TblPhongBan data2 = new TblPhongBan();
                        DataGridViewRow row2 = dataGridView1.Rows[e.RowIndex];
                        data2.MaPhong = row2.Cells[0].Value.ToString();
                        data2.TenPhong = row2.Cells[1].Value.ToString();
                        data2.GhiChu = row2.Cells[2].Value.ToString();
                        Delete.DeletePhongBan uc2 = new Delete.DeletePhongBan("Bộ phận này", data2, this);
                        uc2.ShowDialog();
                        break;
                }
            }
        }
    }
}
