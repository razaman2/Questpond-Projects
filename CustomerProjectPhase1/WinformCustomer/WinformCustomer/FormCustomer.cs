using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiddleLayer;
using FactoryCustomer;

namespace WinformCustomer
{
    public partial class FormCustomer : Form
    {
        private CustomerBase cust = null;

        public FormCustomer()
        {
            InitializeComponent();
            cmbCustomerType.Text = "Customer";
            txtBillAmount.Text = Convert.ToString(0);
            txtBillDate.Text = Convert.ToString(DateTime.Today);
        }

        // Runs Validate Function for Customer Type
        private void btnValidate_Click(object sender, EventArgs e)
        {
            cust.Validate();
        }

        // Assigns Type of Customer on change
        private void cmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = Factory.Create(cmbCustomerType.Text);
        }

        // Assign value of textbox to CustomerName property
        private void txtCustomerName_Leave(object sender, EventArgs e)
        {
            cust.CustomerName = txtCustomerName.Text;
        }

        // Assign value of textbox to PhoneNumber property
        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            cust.PhoneNumber = txtPhoneNumber.Text;
        }

        // Assign value of textbox to BillAmount property
        private void txtBillAmount_Leave(object sender, EventArgs e)
        {
            cust.BillAmount = Convert.ToDecimal(txtBillAmount.Text);
        }

        // Assign value of textbox to BillDate property
        private void txtBillDate_Leave(object sender, EventArgs e)
        {
            cust.BillDate = Convert.ToDateTime(txtBillDate.Text);
        }

        // Assign value of textbox to Address property
        private void txtAddress_Leave(object sender, EventArgs e)
        {
            cust.Address = txtAddress.Text;
        }
    }
}
