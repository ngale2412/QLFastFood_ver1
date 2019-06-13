namespace QuanLyFastFood
{
    partial class frmDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tenCNLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtenCN = new System.Windows.Forms.ComboBox();
            this.DS_PhanManh = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyFastFoodDataSet = new QuanLyFastFood.QuanLyFastFoodDataSet();
            this.v_DS_PhanManhTableAdapter = new QuanLyFastFood.QuanLyFastFoodDataSetTableAdapters.V_DS_PhanManhTableAdapter();
            this.tableAdapterManager = new QuanLyFastFood.QuanLyFastFoodDataSetTableAdapters.TableAdapterManager();
            tenCNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PhanManh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyFastFoodDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tenCNLabel
            // 
            tenCNLabel.AutoSize = true;
            tenCNLabel.Location = new System.Drawing.Point(97, 45);
            tenCNLabel.Name = "tenCNLabel";
            tenCNLabel.Size = new System.Drawing.Size(55, 13);
            tenCNLabel.TabIndex = 0;
            tenCNLabel.Text = "Chi nhánh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDangNhap);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(tenCNLabel);
            this.groupBox1.Controls.Add(this.cbtenCN);
            this.groupBox1.Location = new System.Drawing.Point(47, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(307, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 28);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(194, 168);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(90, 28);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(167, 127);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(230, 20);
            this.txtPass.TabIndex = 5;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(167, 85);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // cbtenCN
            // 
            this.cbtenCN.DataSource = this.DS_PhanManh;
            this.cbtenCN.DisplayMember = "TenCN";
            this.cbtenCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtenCN.FormattingEnabled = true;
            this.cbtenCN.Location = new System.Drawing.Point(167, 42);
            this.cbtenCN.Name = "cbtenCN";
            this.cbtenCN.Size = new System.Drawing.Size(230, 21);
            this.cbtenCN.TabIndex = 1;
            this.cbtenCN.ValueMember = "TenServer";
            this.cbtenCN.SelectedIndexChanged += new System.EventHandler(this.tenCN_Selected);
            // 
            // DS_PhanManh
            // 
            this.DS_PhanManh.DataMember = "V_DS_PhanManh";
            this.DS_PhanManh.DataSource = this.quanLyFastFoodDataSet;
            // 
            // quanLyFastFoodDataSet
            // 
            this.quanLyFastFoodDataSet.DataSetName = "QuanLyFastFoodDataSet";
            this.quanLyFastFoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PhanManhTableAdapter
            // 
            this.v_DS_PhanManhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QuanLyFastFood.QuanLyFastFoodDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_PhanManh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyFastFoodDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private QuanLyFastFoodDataSet quanLyFastFoodDataSet;
        private System.Windows.Forms.BindingSource DS_PhanManh;
        private QuanLyFastFoodDataSetTableAdapters.V_DS_PhanManhTableAdapter v_DS_PhanManhTableAdapter;
        private QuanLyFastFoodDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbtenCN;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}