using Microsoft.Data.SqlClient;

namespace covid19
{
    public partial class frmPatients : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=covid19Patients;Integrated Security=True;Encrypt=False;";

        public frmPatients()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Using tblpatient and exact column names from your database
                    string query = "INSERT INTO tblpatient (Name, IdNo, DOB, Gender, Country, isActive) VALUES (@Name, @IdNo, @DOB, @Gender, @Country, @isActive)";
                    
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@IdNo", txtIdNo.Text);
                        cmd.Parameters.AddWithValue("@DOB", dtpDob.Value);
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                        cmd.Parameters.AddWithValue("@isActive", chkIsActive.Checked);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data posted successfully to tblpatient!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while posting data: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtIdNo.Clear();
            txtCountry.Clear();
            cmbGender.SelectedIndex = -1;
            dtpDob.Value = DateTime.Now;
            chkIsActive.Checked = true;
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdNo.Text))
            {
                MessageBox.Show("Please enter an IdNo to delete.");
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete patient with IdNo: {txtIdNo.Text}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM tblpatient WHERE IdNo = @IdNo";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdNo", txtIdNo.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Patient deleted successfully from tblpatient.");
                                btnNew_Click(sender, e); // Clear fields
                            }
                            else
                            {
                                MessageBox.Show("No patient found with that IdNo.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting: " + ex.Message);
                }
            }
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            // Initial load logic if any
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
