namespace CafeCPE
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.gridSale = new System.Windows.Forms.DataGridView();
            this.btnUPdate = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtsaleid = new System.Windows.Forms.TextBox();
            this.txtmenuid = new System.Windows.Forms.TextBox();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.saleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSale
            // 
            this.gridSale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSale.Location = new System.Drawing.Point(31, 12);
            this.gridSale.Name = "gridSale";
            this.gridSale.Size = new System.Drawing.Size(394, 99);
            this.gridSale.TabIndex = 0;
            this.gridSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSale_CellContentClick);
            // 
            // btnUPdate
            // 
            this.btnUPdate.Location = new System.Drawing.Point(31, 216);
            this.btnUPdate.Name = "btnUPdate";
            this.btnUPdate.Size = new System.Drawing.Size(106, 49);
            this.btnUPdate.TabIndex = 1;
            this.btnUPdate.Text = "Update";
            this.btnUPdate.UseVisualStyleBackColor = true;
            this.btnUPdate.Click += new System.EventHandler(this.btnUPdate_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(176, 216);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(106, 49);
            this.btnDELETE.TabIndex = 2;
            this.btnDELETE.Text = "Delete";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(319, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 49);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SaveToDB";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtsaleid
            // 
            this.txtsaleid.Location = new System.Drawing.Point(108, 125);
            this.txtsaleid.Name = "txtsaleid";
            this.txtsaleid.Size = new System.Drawing.Size(100, 20);
            this.txtsaleid.TabIndex = 4;
            // 
            // txtmenuid
            // 
            this.txtmenuid.Location = new System.Drawing.Point(108, 154);
            this.txtmenuid.Name = "txtmenuid";
            this.txtmenuid.Size = new System.Drawing.Size(100, 20);
            this.txtmenuid.TabIndex = 5;
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(108, 181);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(100, 20);
            this.txttotalprice.TabIndex = 6;
            // 
            // saleID
            // 
            this.saleID.AutoSize = true;
            this.saleID.Location = new System.Drawing.Point(34, 128);
            this.saleID.Name = "saleID";
            this.saleID.Size = new System.Drawing.Size(39, 13);
            this.saleID.TabIndex = 7;
            this.saleID.Text = "SaleID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MenuID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Price";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saleID);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.txtmenuid);
            this.Controls.Add(this.txtsaleid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPdate);
            this.Controls.Add(this.gridSale);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUPdate;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtsaleid;
        private System.Windows.Forms.TextBox txtmenuid;
        private System.Windows.Forms.TextBox txttotalprice;
        private System.Windows.Forms.Label saleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridSale;
    }
}