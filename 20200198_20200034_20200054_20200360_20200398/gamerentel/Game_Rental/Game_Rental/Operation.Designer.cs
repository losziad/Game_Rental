
namespace Game_Rental
{
    partial class Operation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.game_RentalDataSet = new Game_Rental.Game_RentalDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new Game_Rental.Game_RentalDataSetTableAdapters.GameTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.game_RentalDataSet1 = new Game_Rental.Game_RentalDataSet1();
            this.gameRentalDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter1 = new Game_Rental.Game_RentalDataSet1TableAdapters.GameTableAdapter();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofRentersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_RentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_RentalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(566, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn,
            this.vendorDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.numberofRentersDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn,
            this.publishedMonthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(42, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1499, 347);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // game_RentalDataSet
            // 
            this.game_RentalDataSet.DataSetName = "Game_RentalDataSet";
            this.game_RentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.game_RentalDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1301, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1106, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "Renting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // game_RentalDataSet1
            // 
            this.game_RentalDataSet1.DataSetName = "Game_RentalDataSet1";
            this.game_RentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameRentalDataSet1BindingSource
            // 
            this.gameRentalDataSet1BindingSource.DataSource = this.game_RentalDataSet1;
            this.gameRentalDataSet1BindingSource.Position = 0;
            // 
            // gameBindingSource1
            // 
            this.gameBindingSource1.DataMember = "Game";
            this.gameBindingSource1.DataSource = this.game_RentalDataSet1;
            // 
            // gameTableAdapter1
            // 
            this.gameTableAdapter1.ClearBeforeFill = true;
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            this.gIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // vendorDataGridViewTextBoxColumn
            // 
            this.vendorDataGridViewTextBoxColumn.DataPropertyName = "Vendor";
            this.vendorDataGridViewTextBoxColumn.HeaderText = "Vendor";
            this.vendorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.vendorDataGridViewTextBoxColumn.Name = "vendorDataGridViewTextBoxColumn";
            this.vendorDataGridViewTextBoxColumn.Width = 200;
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "Gname";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "Gname";
            this.gnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            this.gnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // numberofRentersDataGridViewTextBoxColumn
            // 
            this.numberofRentersDataGridViewTextBoxColumn.DataPropertyName = "NumberofRenters";
            this.numberofRentersDataGridViewTextBoxColumn.HeaderText = "NumberofRenters";
            this.numberofRentersDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.numberofRentersDataGridViewTextBoxColumn.Name = "numberofRentersDataGridViewTextBoxColumn";
            this.numberofRentersDataGridViewTextBoxColumn.Width = 200;
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "publishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "publishedYear";
            this.publishedYearDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            this.publishedYearDataGridViewTextBoxColumn.Width = 200;
            // 
            // publishedMonthDataGridViewTextBoxColumn
            // 
            this.publishedMonthDataGridViewTextBoxColumn.DataPropertyName = "publishedMonth";
            this.publishedMonthDataGridViewTextBoxColumn.HeaderText = "publishedMonth";
            this.publishedMonthDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.publishedMonthDataGridViewTextBoxColumn.Name = "publishedMonthDataGridViewTextBoxColumn";
            this.publishedMonthDataGridViewTextBoxColumn.Width = 200;
            // 
            // Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 617);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Operation";
            this.Text = "Operation";
            this.Load += new System.EventHandler(this.Operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_RentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game_RentalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameRentalDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Game_RentalDataSet game_RentalDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private Game_RentalDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource gameRentalDataSet1BindingSource;
        private Game_RentalDataSet1 game_RentalDataSet1;
        private System.Windows.Forms.BindingSource gameBindingSource1;
        private Game_RentalDataSet1TableAdapters.GameTableAdapter gameTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofRentersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedMonthDataGridViewTextBoxColumn;
    }
}