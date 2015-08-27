namespace HouseSellingDesktopApplication
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.House = new System.Windows.Forms.TabPage();
            this.enddateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReadyForSaleButton = new System.Windows.Forms.Button();
            this.addHouse_Button = new System.Windows.Forms.Button();
            this.houseListDataGridView = new System.Windows.Forms.DataGridView();
            this.housePriceTextBox = new System.Windows.Forms.TextBox();
            this.houseNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Employee = new System.Windows.Forms.TabPage();
            this.employeeListDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.House.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseListDataGridView)).BeginInit();
            this.Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label1.Location = new System.Drawing.Point(2, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 36);
            label1.TabIndex = 8;
            label1.Text = "Add House";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label3.Location = new System.Drawing.Point(6, 3);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(161, 36);
            label3.TabIndex = 9;
            label3.Text = "Employees";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.House);
            this.tabControl1.Controls.Add(this.Employee);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // House
            // 
            this.House.AccessibleName = "House";
            this.House.Controls.Add(this.enddateDateTimePicker);
            this.House.Controls.Add(this.statusComboBox);
            this.House.Controls.Add(this.label5);
            this.House.Controls.Add(this.label6);
            this.House.Controls.Add(this.ReadyForSaleButton);
            this.House.Controls.Add(this.addHouse_Button);
            this.House.Controls.Add(this.houseListDataGridView);
            this.House.Controls.Add(this.housePriceTextBox);
            this.House.Controls.Add(this.houseNameTextBox);
            this.House.Controls.Add(this.label4);
            this.House.Controls.Add(this.label2);
            this.House.Controls.Add(label1);
            this.House.Location = new System.Drawing.Point(4, 22);
            this.House.Name = "House";
            this.House.Padding = new System.Windows.Forms.Padding(3);
            this.House.Size = new System.Drawing.Size(758, 472);
            this.House.TabIndex = 0;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            // 
            // enddateDateTimePicker
            // 
            this.enddateDateTimePicker.Location = new System.Drawing.Point(61, 207);
            this.enddateDateTimePicker.Name = "enddateDateTimePicker";
            this.enddateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.enddateDateTimePicker.TabIndex = 20;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Building",
            "Built",
            "ReadyForSale"});
            this.statusComboBox.Location = new System.Drawing.Point(61, 160);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Status";
            // 
            // ReadyForSaleButton
            // 
            this.ReadyForSaleButton.Location = new System.Drawing.Point(93, 289);
            this.ReadyForSaleButton.Name = "ReadyForSaleButton";
            this.ReadyForSaleButton.Size = new System.Drawing.Size(98, 23);
            this.ReadyForSaleButton.TabIndex = 15;
            this.ReadyForSaleButton.Text = "Ready For Sale";
            this.ReadyForSaleButton.UseVisualStyleBackColor = true;
            this.ReadyForSaleButton.Click += new System.EventHandler(this.ReadyForSaleButton_Click);
            // 
            // addHouse_Button
            // 
            this.addHouse_Button.Location = new System.Drawing.Point(215, 289);
            this.addHouse_Button.Name = "addHouse_Button";
            this.addHouse_Button.Size = new System.Drawing.Size(75, 23);
            this.addHouse_Button.TabIndex = 14;
            this.addHouse_Button.Text = "Add";
            this.addHouse_Button.UseVisualStyleBackColor = true;
            this.addHouse_Button.Click += new System.EventHandler(this.addHouse_Button_Click);
            // 
            // houseListDataGridView
            // 
            this.houseListDataGridView.AutoGenerateColumns = false;
            this.houseListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.houseListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn});
            this.houseListDataGridView.DataSource = this.houseBindingSource;
            this.houseListDataGridView.Location = new System.Drawing.Point(319, 71);
            this.houseListDataGridView.Name = "houseListDataGridView";
            this.houseListDataGridView.Size = new System.Drawing.Size(432, 338);
            this.houseListDataGridView.TabIndex = 13;
            this.houseListDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.houseListDataGridView_CellClick);
            // 
            // housePriceTextBox
            // 
            this.housePriceTextBox.Location = new System.Drawing.Point(61, 118);
            this.housePriceTextBox.Name = "housePriceTextBox";
            this.housePriceTextBox.Size = new System.Drawing.Size(246, 20);
            this.housePriceTextBox.TabIndex = 12;
            // 
            // houseNameTextBox
            // 
            this.houseNameTextBox.Location = new System.Drawing.Point(61, 71);
            this.houseNameTextBox.Name = "houseNameTextBox";
            this.houseNameTextBox.Size = new System.Drawing.Size(246, 20);
            this.houseNameTextBox.TabIndex = 10;
            this.houseNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.houseNameTextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // Employee
            // 
            this.Employee.AccessibleName = "Employee";
            this.Employee.Controls.Add(label3);
            this.Employee.Controls.Add(this.employeeListDataGridView);
            this.Employee.Location = new System.Drawing.Point(4, 22);
            this.Employee.Name = "Employee";
            this.Employee.Padding = new System.Windows.Forms.Padding(3);
            this.Employee.Size = new System.Drawing.Size(758, 472);
            this.Employee.TabIndex = 1;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            // 
            // employeeListDataGridView
            // 
            this.employeeListDataGridView.AllowUserToOrderColumns = true;
            this.employeeListDataGridView.AutoGenerateColumns = false;
            this.employeeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.fullNameDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn});
            this.employeeListDataGridView.DataSource = this.employeeBindingSource;
            this.employeeListDataGridView.Location = new System.Drawing.Point(12, 47);
            this.employeeListDataGridView.Name = "employeeListDataGridView";
            this.employeeListDataGridView.Size = new System.Drawing.Size(343, 415);
            this.employeeListDataGridView.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.AllowNew = true;
            this.houseBindingSource.DataSource = typeof(HouseSellingDesktopApplication.House);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(HouseSellingDesktopApplication.Employee);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Selling House";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.House.ResumeLayout(false);
            this.House.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseListDataGridView)).EndInit();
            this.Employee.ResumeLayout(false);
            this.Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Employee;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TabPage House;
        private System.Windows.Forms.DataGridView houseListDataGridView;
        private System.Windows.Forms.TextBox housePriceTextBox;
        private System.Windows.Forms.TextBox houseNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView employeeListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ReadyForSaleButton;
        private System.Windows.Forms.Button addHouse_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker enddateDateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;

    }
}