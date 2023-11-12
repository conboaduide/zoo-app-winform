using BusinessObject.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooForm
{
    public partial class frmUserManagement : Form
    {
        private IUserRepository _userRepository = new UserRepository();

        private bool isCreating = false;

        private bool createOrUpdate;

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadUserData();
            LoadRoleData();
            EnableText(false);
        }

        private void LoadUserData()
        {
            BindingSource source = new BindingSource();
            source.DataSource = _userRepository.GetUsers();

            txtId.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtCreatedDate.DataBindings.Clear();
            radioTrue.DataBindings.Clear();
            cboRole.DataBindings.Clear();

            txtId.DataBindings.Add("Text", source, "Id");
            txtUsername.DataBindings.Add("Text", source, "Username");
            txtEmail.DataBindings.Add("Text", source, "Email");
            txtCreatedDate.DataBindings.Add("Text", source, "CreatedDate");
            radioTrue.DataBindings.Add("Checked", source, "Status", true, DataSourceUpdateMode.OnPropertyChanged);
            cboRole.DataBindings.Add("Text", source, "Role");

            dgv.DataSource = null;
            dgv.DataSource = source;
        }

        private void LoadRoleData()
        {
            List<Role> roles = new List<Role>();
            roles.Add(new Role(1, "Admin"));
            roles.Add(new Role(2, "Staff"));
            roles.Add(new Role(3, "Zoo Trainer"));
            roles.Add(new Role(4, "Customer"));
            cboRole.DataSource = roles;
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "Id";
        }

        private void EnableText(bool status)
        {
            txtId.Enabled = status;
            txtUsername.Enabled = status;
            txtEmail.Enabled = status;
            txtCreatedDate.Enabled = status;
            cboRole.Enabled = status;
            radioTrue.Enabled = status;
            radioFalse.Enabled = status;
        }

        private void ClearFields()
        {
            // Clear the text in all input fields
            txtId.Clear();
            txtUsername.Clear();
            txtEmail.Clear();
            txtCreatedDate.Clear();
            radioTrue.Checked = false;
            cboRole.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!isCreating)
            {
                // Switch to Create mode
                createOrUpdate = true;
                isCreating = true;
                ClearFields();
                EnableText(true);
                btnCreate.Text = "Cancel";
            }
            else
            {
                // Switch back to normal mode
                isCreating = false;
                EnableText(false);
                btnCreate.Text = "Create";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!isCreating)
            {
                // Switch to Update mode
                createOrUpdate = false;
                isCreating = true;
                EnableText(true);
                btnUpdate.Text = "Cancel";
            }
            else
            {
                // Switch back to normal mode
                isCreating = false;
                EnableText(false);
                btnUpdate.Text = "Update";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate the input fields before saving
            if (ValidateInput())
            {
                User user = new User
                {
                    // Assign values from the form controls to the user object
                    Id = Convert.ToInt32(txtId.Text),
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Role = int.Parse(cboRole.SelectedValue.ToString()),
                };

                if (createOrUpdate)
                {
                    user.CreatedDate = DateTime.Now;
                }

                if (radioTrue.Checked)
                {
                    user.Status = true;
                }
                else
                {
                    user.Status = false;
                }
 
                // Determine whether to create or update based on the existence of the user ID
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    _userRepository.CreateUser(user);
                }
                else
                {
                    _userRepository.UpdateUser(user);
                }

                // Reload the data after saving
                LoadUserData();
                EnableText(false);

                if (createOrUpdate)
                {
                    btnCreate.Text = "Create";
                } else
                {
                    btnUpdate.Text = "Update";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                // Confirm the deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the user
                    _userRepository.DeleteUser(Convert.ToInt32(txtId.Text));

                    // Reload the data after deleting
                    LoadUserData();
                    EnableText(false);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void radioTrue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTrue.Checked)
            {
                radioFalse.Checked = false;
            }
            else
            {
                radioFalse.Checked = true;
            }
        }

        private void radioFalse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFalse.Checked)
            {
                radioTrue.Checked = false;
            }
            else
            {
                radioTrue.Checked = true;
            }
        }

        private bool ValidateInput()
        {
            // Implement validation logic for user input
            // Return true if input is valid, false otherwise
            return true; // Placeholder, replace with your validation logic
        }
    }

    class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Role(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
