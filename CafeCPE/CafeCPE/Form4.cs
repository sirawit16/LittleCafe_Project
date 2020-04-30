using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeCPE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet(); // สร้าง ds
        string cn = "Data Source=.; Initial Catalog=Little COFFEE; User ID=adminlittle; Password=123456";
        private void Form4_Load(object sender, EventArgs e)
        {
            { 
                // เมื่อเปิดโปรแกรม Formload
                string sql = "SELECT * FROM sale_detail";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                da.Fill(ds, "saledetail");
                gridSale.DataSource = ds.Tables["saledetail"];
                //cbbDept.DisplayMember = "deptName"; //เอาชื่อไปโชว์
                //cbbDept.ValueMenber = "deptID"; //เอาค่าไปแอบไว้
                //cbbDept.DataSource = ds.Tables["Depart"];

                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow[] drs = ds.Tables["saledetail"].Select
                ("sale_id='" + txtsaleid.Text + "'");
            if (drs.Length == 0)
                MessageBox.Show("ไม่พบข้อมูล");
            else
            {
                drs[0].Delete();
                string sql = "SELECT * FROM sale_detail";
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                da.Update(ds, "saledetail");
                ds.Tables["saledetail"].AcceptChanges();
            }
        }

        private void gridSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // เมื่อเลือกข้อมูลใน grid จะให้ไปแสดงข้อมูลใน txt และ cbb
            if (e.RowIndex == -1) //ไม่เลือกหรือเลือกอย่างอื่นที่ไม่ใช่ข้อมูล
                return; //ให้จบการทำงานของเหตุการณ์นี้ทันที
            else
            {
                gridSale.Rows[e.RowIndex].Selected = true;
                //วิธีดึงจาก DataGridView
                DataGridViewRow dgr = gridSale.Rows[e.RowIndex];
                txtsaleid.Text = dgr.Cells[0].Value.ToString();
                txtmenuid.Text = dgr.Cells[1].Value.ToString();
                txttotalprice.Text = dgr.Cells[2].Value.ToString();
                gridSale.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnUPdate_Click(object sender, EventArgs e)
        {
            //ปุ่มupdate
            ////ไว้ insert/update
            DataRow[] drs = ds.Tables["saledetail"].Select
                ("sale_id='" + txtsaleid.Text + "'");
            if(drs.Length == 0) //ไม่มีข้อมูลให้ทำการ อินเสิช
            {
                DataRow dr = ds.Tables["saledetail"].NewRow();
                dr["sale_id"] = txtsaleid.Text;
                dr["menu_id"] = txtmenuid.Text;
                dr["total_price"] = txttotalprice.Text;
                ds.Tables["saledetail"].Rows.Add(dr);
            }
            else //มีข้อมูล ให้ทำการอัพเดต
            {
                drs[0]["menu_id"] = txtmenuid.Text;
                
            }
            gridSale.DataSource = ds.Tables["saledetail"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM sale_detail";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "saledetail");
        }
    }
}
