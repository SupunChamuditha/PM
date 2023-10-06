
namespace PharmacySystem
{
    partial class FormUsers
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMedicines = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxUserUserType = new System.Windows.Forms.ComboBox();
            this.txtUserUserName = new System.Windows.Forms.TextBox();
            this.lblUserUserName = new System.Windows.Forms.Label();
            this.lblStockMedicineType = new System.Windows.Forms.Label();
            this.lblUserUserDetails = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblUserUserID = new System.Windows.Forms.Label();
            this.comboBoxUserUserID = new System.Windows.Forms.ComboBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.comboBoxUserGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedicines
            // 
            this.lblMedicines.AutoSize = true;
            this.lblMedicines.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicines.Location = new System.Drawing.Point(455, 9);
            this.lblMedicines.Name = "lblMedicines";
            this.lblMedicines.Size = new System.Drawing.Size(104, 40);
            this.lblMedicines.TabIndex = 1;
            this.lblMedicines.Text = "USERS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.comboBoxUserGender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtUserEmail);
            this.panel1.Controls.Add(this.comboBoxUserUserID);
            this.panel1.Controls.Add(this.comboBoxUserUserType);
            this.panel1.Controls.Add(this.txtUserUserName);
            this.panel1.Controls.Add(this.lblUserUserName);
            this.panel1.Controls.Add(this.lblStockMedicineType);
            this.panel1.Controls.Add(this.lblUserUserID);
            this.panel1.Controls.Add(this.lblUserEmail);
            this.panel1.Controls.Add(this.lblUserUserDetails);
            this.panel1.Controls.Add(this.lblMedicines);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 732);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 337);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(452, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 36);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(836, 263);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 36);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(640, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxUserUserType
            // 
            this.comboBoxUserUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserUserType.FormattingEnabled = true;
            this.comboBoxUserUserType.Location = new System.Drawing.Point(470, 157);
            this.comboBoxUserUserType.Name = "comboBoxUserUserType";
            this.comboBoxUserUserType.Size = new System.Drawing.Size(157, 26);
            this.comboBoxUserUserType.TabIndex = 15;
            // 
            // txtUserUserName
            // 
            this.txtUserUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserUserName.Location = new System.Drawing.Point(125, 198);
            this.txtUserUserName.Name = "txtUserUserName";
            this.txtUserUserName.Size = new System.Drawing.Size(243, 24);
            this.txtUserUserName.TabIndex = 14;
            // 
            // lblUserUserName
            // 
            this.lblUserUserName.AutoSize = true;
            this.lblUserUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserUserName.Location = new System.Drawing.Point(22, 198);
            this.lblUserUserName.Name = "lblUserUserName";
            this.lblUserUserName.Size = new System.Drawing.Size(94, 21);
            this.lblUserUserName.TabIndex = 13;
            this.lblUserUserName.Text = "User Name";
            // 
            // lblStockMedicineType
            // 
            this.lblStockMedicineType.AutoSize = true;
            this.lblStockMedicineType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMedicineType.Location = new System.Drawing.Point(380, 159);
            this.lblStockMedicineType.Name = "lblStockMedicineType";
            this.lblStockMedicineType.Size = new System.Drawing.Size(84, 21);
            this.lblStockMedicineType.TabIndex = 12;
            this.lblStockMedicineType.Text = "User Type";
            // 
            // lblUserUserDetails
            // 
            this.lblUserUserDetails.AutoSize = true;
            this.lblUserUserDetails.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserUserDetails.Location = new System.Drawing.Point(20, 80);
            this.lblUserUserDetails.Name = "lblUserUserDetails";
            this.lblUserUserDetails.Size = new System.Drawing.Size(151, 32);
            this.lblUserUserDetails.TabIndex = 4;
            this.lblUserUserDetails.Text = "User Details";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserEmail.Location = new System.Drawing.Point(647, 157);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(59, 21);
            this.lblUserEmail.TabIndex = 8;
            this.lblUserEmail.Text = "E-Mail";
            // 
            // lblUserUserID
            // 
            this.lblUserUserID.AutoSize = true;
            this.lblUserUserID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserUserID.Location = new System.Drawing.Point(22, 158);
            this.lblUserUserID.Name = "lblUserUserID";
            this.lblUserUserID.Size = new System.Drawing.Size(65, 21);
            this.lblUserUserID.TabIndex = 9;
            this.lblUserUserID.Text = "User ID";
            // 
            // comboBoxUserUserID
            // 
            this.comboBoxUserUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserUserID.FormattingEnabled = true;
            this.comboBoxUserUserID.Location = new System.Drawing.Point(125, 158);
            this.comboBoxUserUserID.Name = "comboBoxUserUserID";
            this.comboBoxUserUserID.Size = new System.Drawing.Size(243, 26);
            this.comboBoxUserUserID.TabIndex = 18;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserEmail.Location = new System.Drawing.Point(717, 157);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(257, 24);
            this.txtUserEmail.TabIndex = 19;
            // 
            // comboBoxUserGender
            // 
            this.comboBoxUserGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUserGender.FormattingEnabled = true;
            this.comboBoxUserGender.Location = new System.Drawing.Point(470, 200);
            this.comboBoxUserGender.Name = "comboBoxUserGender";
            this.comboBoxUserGender.Size = new System.Drawing.Size(157, 26);
            this.comboBoxUserGender.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Gender";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(125, 240);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 78);
            this.textBox1.TabIndex = 27;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(22, 237);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 21);
            this.lblAddress.TabIndex = 26;
            this.lblAddress.Text = "Address";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(717, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 24);
            this.textBox2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(647, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mobile";
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsers";
            this.Text = "FormStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMedicines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserUserDetails;
        private System.Windows.Forms.Label lblUserUserName;
        private System.Windows.Forms.Label lblStockMedicineType;
        private System.Windows.Forms.TextBox txtUserUserName;
        private System.Windows.Forms.ComboBox comboBoxUserUserType;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox comboBoxUserGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.ComboBox comboBoxUserUserID;
        private System.Windows.Forms.Label lblUserUserID;
        private System.Windows.Forms.Label lblUserEmail;
    }
}