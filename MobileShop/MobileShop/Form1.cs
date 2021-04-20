using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;

namespace MobileShop
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

       
        public void enableDisable(Boolean txtbox, Boolean btn1, Boolean btn2)
        {
            txtPass.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            cmbCompany.Items.Clear();
            query = "select distinct cname from newMobile";
            setComboBOX(query, cmbCompany);
            query = "select * from newMobile";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            query = "select * from customerPurchase";
            dataGridView2.DataSource = ds.Tables[0];
            enableDisable(false, false, false);
            query = "select * from newMobile";
            dataGridView3.DataSource = ds.Tables[0];

        }


        public void setComboBOX(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query); //select model from newMobile
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
        }
        int bid;

        Boolean flag;

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from customerPurchase where cname like'%" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from customerPurchase where imei like '%" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }

        }

        private void btnAddNewPhone_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }

        private void btnStock_Click_1(object sender, EventArgs e)
        {

            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
        
    }

        private void btnCustomerRecords_Click_1(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel6.Visible = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            enableDisable(true, true, true);
        }

        private void btnPurchase_Click_1(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cmbGender.Text != "" && txtContactNumber.Text != "" && txtEmailID.Text != "" && txtAddress.Text != "" && cmbCompany.Text != "" && cmbModel.Text != "" && txtIMEI.Text != "")
            {
                String name = txtName.Text;
                String gender = cmbGender.Text;
                String contact = txtContactNumber.Text;
                String email = txtEmailID.Text;
                String address = txtAddress.Text;
                String companny = cmbCompany.Text;
                String model = cmbModel.Text;
                String imei = txtIMEI.Text;
                query = "insert into customerPurchase(cname,gender,contact,email,caddress,company,model,imei) values ('" + name + "','" + gender + "','" + contact + "','" + email + "','" + address + "','" + companny + "','" + model + "','" + imei + "')";
                fn.setData(query);
                txtName.Clear();
                cmbGender.SelectedIndex = -1;
                txtContactNumber.Clear();
                txtEmailID.Clear();
                txtAddress.Clear();
                txtIMEI.Clear();
                cmbCompany.SelectedIndex = -1;
                cmbModel.SelectedIndex = -1;
                lblExpandable.Text = "";
                lblFingerPrintSensor.Text = "";
                lblFrontCamera.Text = "";
                lblInternal.Text = "";
                lblPrice.Text = "";
                lblRam.Text = "";
                lblRearCamera.Text = "";
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModelName.Text != "" && cmbRam.Text != "" && cmbExpandableMemory.Text != "" && cmbInternalStorage.Text != "" && cmbDisplay.Text != "" && CmbRearCamera.Text != "" && CmbFrontCamera.Text != "" && CmbFingerprintSensor.Text != "" && CmbSimType.Text != "" && CmbNetworkType.Text != "" && txtPrice.Text != "")
            {
                String company = txtCompany.Text;
                String model = txtModelName.Text;
                String ram = cmbRam.Text;
                String intel = cmbInternalStorage.Text;
                string expandable = cmbExpandableMemory.Text;
                String display = cmbDisplay.Text;
                String rear = CmbRearCamera.Text;
                string front = CmbFrontCamera.Text;
                string fingerprint = CmbFingerprintSensor.Text;
                String sim = CmbSimType.Text;
                String network = CmbNetworkType.Text;
                string price = txtPrice.Text;
                query = "insert into newMobile (cname,mname,ram,internal,expandable,display,rear,front,finger,sim,network,price) values ('" + company + "','" + model + "','" + ram + "','" + intel + "','" + expandable + "','" + display + "','" + rear + "','" + front + "','" + fingerprint + "','" + sim + "','" + network + "','" + price + "')";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModelName.Clear();
            cmbRam.SelectedIndex = -1;
            cmbInternalStorage.SelectedIndex = -1;
            cmbExpandableMemory.SelectedIndex = -1;
            cmbDisplay.SelectedIndex = -1;
            CmbFingerprintSensor.SelectedIndex = -1;
            CmbFrontCamera.SelectedIndex = -1;
            CmbRearCamera.SelectedIndex = -1;
            CmbSimType.SelectedIndex = -1;
            CmbNetworkType.SelectedIndex = -1;
            txtPrice.Clear();
            txtModelName.Clear();
        }

        private void btnPurchase_Click_2(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cmbGender.Text != "" && txtContactNumber.Text != "" && txtEmailID.Text != "" && txtAddress.Text != "" && cmbCompany.Text != "" && cmbModel.Text != "" && txtIMEI.Text != "")
            {
                String name = txtName.Text;
                String gender = cmbGender.Text;
                String contact = txtContactNumber.Text;
                String email = txtEmailID.Text;
                String address = txtAddress.Text;
                String companny = cmbCompany.Text;
                String model = cmbModel.Text;
                String imei = txtIMEI.Text;
                query = "insert into customerPurchase(cname,gender,contact,email,caddress,company,model,imei) values ('" + name + "','" + gender + "','" + contact + "','" + email + "','" + address + "','" + companny + "','" + model + "','" + imei + "')";
                fn.setData(query);
                txtName.Clear();
                cmbGender.SelectedIndex = -1;
                txtContactNumber.Clear();
                txtEmailID.Clear();
                txtAddress.Clear();
                txtIMEI.Clear();
                cmbCompany.SelectedIndex = -1;
                cmbModel.SelectedIndex = -1;
                lblExpandable.Text = "";
                lblFingerPrintSensor.Text = "";
                lblFrontCamera.Text = "";
                lblInternal.Text = "";
                lblPrice.Text = "";
                lblRam.Text = "";
                lblRearCamera.Text = "";
            }
            }

        private void cmbCompany_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            String cname = cmbCompany.Text;
            query = "select mname from newMobile where cname='" + cname + "'";
            setComboBOX(query, cmbModel);
        }

        private void cmbModel_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            query = "select * from newMobile where mname='" + cmbModel.Text + "'";
            DataSet ds = fn.getData(query);
            lblRam.Text = ds.Tables[0].Rows[0][3].ToString();
            lblInternal.Text = ds.Tables[0].Rows[0][4].ToString();
            lblExpandable.Text = ds.Tables[0].Rows[0][5].ToString();
            lblRearCamera.Text = ds.Tables[0].Rows[0][7].ToString();
            lblFrontCamera.Text = ds.Tables[0].Rows[0][8].ToString();
            lblFingerPrintSensor.Text = ds.Tables[0].Rows[0][9].ToString();
            lblPrice.Text = ds.Tables[0].Rows[0][12].ToString();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select *from newMobile where mid=" + bid + "";
            DataSet ds = fn.getData(query);
            Companylbl.Text = ds.Tables[0].Rows[0][1].ToString();
            ModelNamelbl.Text = ds.Tables[0].Rows[0][2].ToString();
            Ramlbl.Text = ds.Tables[0].Rows[0][3].ToString();
            InternalStoragelbl.Text = ds.Tables[0].Rows[0][4].ToString();
            expandableMemorylbl.Text = ds.Tables[0].Rows[0][5].ToString();
            displaylbl.Text = ds.Tables[0].Rows[0][6].ToString();
            Rearlbl.Text = ds.Tables[0].Rows[0][7].ToString();
            Frontlbl.Text = ds.Tables[0].Rows[0][8].ToString();
            Fingerprintlbl.Text = ds.Tables[0].Rows[0][9].ToString();
            Simlbl.Text = ds.Tables[0].Rows[0][10].ToString();
            networklbl.Text = ds.Tables[0].Rows[0][11].ToString();
            pricelbl.Text = ds.Tables[0].Rows[0][12].ToString();
        }

        private void btnSearch_Click_2(object sender, EventArgs e)
        {
            if (flag == false)
            {
                query = "select * from customerPurchase where cname like'%" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from customerPurchase where imei like '%" + txtSearch.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
        }

        private void cmbSearch_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (cmbSearch.SelectedIndex == 0)
            {
                flag = false;
                lblTOSET.Text = "Enter Customer Name";
            }
            else if (cmbSearch.SelectedIndex == 1)
            {
                flag = true;
                lblTOSET.Text = "Enter IMEI";
            }
        }

        private void txtComporModel_TextChanged_1(object sender, EventArgs e)
        {
            query = "select * from newMobile  where cname like'" + txtComporModel.Text + "%' or mname like '" + txtComporModel.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void btnVerify_Click_1(object sender, EventArgs e)
        {
            if (txtPass.Text == "rabiacevikk")
            {
                panel6.Visible = true;
                enableDisable(false, false, false);
                txtPass.Clear();
            }
            else
            {
                txtPass.Clear();
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            enableDisable(false, false, false);

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "delete from newMobile where mid=" + bid + "";
            if (MessageBox.Show("Deleting Record of " + bid + "", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("You Cancelled the Operation.", "Back<-", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    } 
}
