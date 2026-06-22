using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarParkManagementSystem;

namespace park_management
{
    public partial class adminParkSlot : Form
    {
        SqlConnection con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            AttachDbFilename=|DataDirectory|\CarParkDB.mdf;
            Integrated Security=True");

        public adminParkSlot()
        {
            InitializeComponent();
            SetupDropdownItems();
            ClearFields();
        }

        private void adminParkSlot_Load(object sender, EventArgs e)
        {
            LoadSlots();
            ClearFields();
        }

        private void SetupDropdownItems()
        {
            // Floor Level
            cmbBoxFloorLevel.Items.Clear();
            cmbBoxFloorLevel.Items.AddRange(new object[] { "Ground", "Level 1", "Level 2", "Level 3" });
            cmbBoxFloorLevel.DropDownStyle = ComboBoxStyle.DropDownList;

            // Slot Type
            cmbSlotType.Items.Clear();
            cmbSlotType.Items.AddRange(new object[] { "Standard", "EV Charging", "Motorcycle", "Disable (OKU)" });
            cmbSlotType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Status
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied" });
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadSlots()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Parking_Slot", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSlot.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slots: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            lblSlotID.Text = GenerateNextSlotID();

            cmbBoxFloorLevel.SelectedIndex = -1;
            cmbSlotType.SelectedIndex = -1;

            if (cmbStatus.Items.Count > 0)
            {
                cmbStatus.SelectedIndex = cmbStatus.Items.IndexOf("Available");
            }
        }

        // =================================================================
        // LOGIK UTAMA: PENJANAAN FORMAT SLOT ID BAHARU (SL-0001, SL-0002...)
        // =================================================================
        private string GenerateNextSlotID()
        {
            string nextID = "SL-0001"; // Format default mengikut pangkalan data anda
            try
            {
                string query = "SELECT TOP 1 Slot_ID FROM Parking_Slot ORDER BY Slot_ID DESC";
                SqlCommand cmd = new SqlCommand(query, con);

                if (con.State != ConnectionState.Open) con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null && result != DBNull.Value)
                {
                    string lastID = result.ToString().Trim(); // Contoh: "SL-0005"

                    // Memotong string "SL-" dan mengambil bahagian nombor di belakangnya
                    if (lastID.StartsWith("SL-") && int.TryParse(lastID.Substring(3), out int currentNum))
                    {
                        int nextNum = currentNum + 1;
                        nextID = "SL-" + nextNum.ToString("D4"); // Menghasilkan "SL-0006"
                    }
                }
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error generating dynamic ID: " + ex.Message);
            }
            return nextID;
        }

        // =================================================================
        // SEBELUM GENERATE/ADD: SEMAK DUPLICATE ID DALAM DATABASE
        // =================================================================
        private bool IsSlotIDDuplicate(string slotID)
        {
            bool exists = false;
            try
            {
                string query = "SELECT COUNT(*) FROM Parking_Slot WHERE Slot_ID = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", slotID);

                if (con.State != ConnectionState.Open) con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

                if (count > 0)
                {
                    exists = true;
                }
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error checking for duplicate ID: " + ex.Message);
            }
            return exists;
        }

        private string GenerateNextSlotNumber(string floorLevel)
        {
            string prefix = "A";
            if (floorLevel == "Ground") prefix = "G";
            else if (floorLevel == "Level 1") prefix = "L1";
            else if (floorLevel == "Level 2") prefix = "L2";
            else if (floorLevel == "Level 3") prefix = "L3";

            int nextNum = 1;

            try
            {
                string query = "SELECT TOP 1 Slot_Number FROM Parking_Slot WHERE Floor_Level = @floor ORDER BY Slot_Number DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@floor", floorLevel);

                if (con.State != ConnectionState.Open) con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null && result != DBNull.Value)
                {
                    string lastSlotNum = result.ToString().Trim();
                    string[] parts = lastSlotNum.Split('-');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int currentCount))
                    {
                        nextNum = currentCount + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error generating Slot Number: " + ex.Message);
            }

            return $"{prefix}-{nextNum:D2}";
        }

        // =================================================================
        // OPERASI CRUD (ADD, UPDATE, DELETE)
        // =================================================================

        // 1. REGISTER / ADD SLOT
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbBoxFloorLevel.SelectedItem == null || cmbSlotType.SelectedItem == null)
            {
                MessageBox.Show("Please select Floor Level and Slot Type before saving!");
                return;
            }

            string currentGeneratedID = lblSlotID.Text;

            // LANGKAH KESELAMATAN: Semak jika ID sudah wujud untuk mengelakkan ralat duplicate
            if (IsSlotIDDuplicate(currentGeneratedID))
            {
                MessageBox.Show($"Error: The Slot ID {currentGeneratedID} already exists in the database! Regenerating a new ID...",
                                "Duplicate ID Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearFields(); // Paksa sistem janji ID baharu semula
                return;
            }

            try
            {
                string selectedFloor = cmbBoxFloorLevel.SelectedItem.ToString();
                string autoSlotNumber = GenerateNextSlotNumber(selectedFloor);

                string query = @"INSERT INTO Parking_Slot (Slot_ID, Slot_Number, Floor_Level, Slot_Type, Status)
                                VALUES (@id, @slotNum, @floor, @type, @status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", currentGeneratedID);
                cmd.Parameters.AddWithValue("@slotNum", autoSlotNumber);
                cmd.Parameters.AddWithValue("@floor", selectedFloor);
                cmd.Parameters.AddWithValue("@type", cmbSlotType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@status", "Available");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show($"Parking Slot {currentGeneratedID} ({autoSlotNumber}) Registered Successfully!");

                LoadSlots();
                ClearFields();
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error registering slot: " + ex.Message);
            }
        }

        // 2. UPDATE SLOT
        private void updateBttn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSlotID.Text) || lblSlotID.Text == "0" || lblSlotID.Text == "-")
            {
                MessageBox.Show("Please select a valid slot from the table below to update.");
                return;
            }

            try
            {
                string query = @"UPDATE Parking_Slot 
                                SET Floor_Level = @floor, Slot_Type = @type, Status = @status
                                WHERE Slot_ID = @id";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@floor", cmbBoxFloorLevel.Text);
                cmd.Parameters.AddWithValue("@type", cmbSlotType.Text);
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@id", lblSlotID.Text);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show($"Parking Slot {lblSlotID.Text} Updated Successfully!");
                    LoadSlots();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) con.Close();
                MessageBox.Show("Error updating slot: " + ex.Message);
            }
        }

        // 3. DELETE SLOT
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblSlotID.Text) || lblSlotID.Text == "0" || lblSlotID.Text == "-")
            {
                MessageBox.Show("Please select a slot from the table below to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete slot {lblSlotID.Text}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Parking_Slot WHERE Slot_ID=@id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", lblSlotID.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Parking Slot Deleted.");
                    LoadSlots();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    if (con.State == ConnectionState.Open) con.Close();
                    MessageBox.Show("Error deleting slot: " + ex.Message);
                }
            }
        }

        // 4. DATAGRIDVIEW CLICK HANDLERS
        private void dgvSlot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleRowSelection(e.RowIndex);
        }

        private void dgvSlot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleRowSelection(e.RowIndex);
        }

        private void HandleRowSelection(int rowIndex)
        {
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvSlot.Rows[rowIndex];

                lblSlotID.Text = row.Cells["Slot_ID"].Value?.ToString() ?? "";
                cmbBoxFloorLevel.Text = row.Cells["Floor_Level"].Value?.ToString() ?? "";
                cmbSlotType.Text = row.Cells["Slot_Type"].Value?.ToString() ?? "";
                cmbStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // =================================================================
        // SIDEBAR NAVIGATION
        // =================================================================
        private void dashboardBttn_Click(object sender, EventArgs e)
        {
            adminDashBooard frm = new adminDashBooard();
            frm.Show();
            this.Hide();
        }

        private void vehicleBttn_Click(object sender, EventArgs e)
        {
            adminDashboard frm = new adminDashboard();
            frm.Show();
            this.Hide();
        }

        private void RateBttn_Click(object sender, EventArgs e)
        {
            AdminRate frm = new AdminRate();
            frm.Show();
            this.Hide();
        }

        private void EntryBttn_Click(object sender, EventArgs e)
        {
            adminEntry frm = new adminEntry();
            frm.Show();
            this.Hide();
        }

        private void TranscBttn_Click(object sender, EventArgs e)
        {
            adminTransaction frm = new adminTransaction();
            frm.Show();
            this.Hide();
        }

        private void linkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        // Unused Event Handlers
        private void panelSlotID_Paint(object sender, PaintEventArgs e) { }
        private void cmbBoxFloorLevel_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbSlotType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void layoutLiveMap_Paint(object sender, PaintEventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtSearch_TextChanged(object sender, EventArgs e) { }
        private void parkSlotbttn_Click(object sender, EventArgs e) { }
        private void lblSlotID_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
    }
}