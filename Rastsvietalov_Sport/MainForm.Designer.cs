namespace Rastsvietalov_Sport
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.sportsmansAdapterTableAdapter1 = new Rastsvietalov_Sport.DB_Sport_MainDataSetTableAdapters.SportsmansAdapterTableAdapter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dB_Sport_MainDataSet = new Rastsvietalov_Sport.DB_Sport_MainDataSet();
			this.sportsmansAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.victoryCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.biographyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeOfSportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_Sport_MainDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sportsmansAdapterBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(40, 79);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1006, 366);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.menuStrip1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(998, 340);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(3, 3);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(992, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(862, 340);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(862, 340);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// sportsmansAdapterTableAdapter1
			// 
			this.sportsmansAdapterTableAdapter1.ClearBeforeFill = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.victoryCountDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.countryIdDataGridViewTextBoxColumn,
            this.biographyDataGridViewTextBoxColumn,
            this.typeOfSportDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.sportsmansAdapterBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(980, 279);
			this.dataGridView1.TabIndex = 1;
			// 
			// dB_Sport_MainDataSet
			// 
			this.dB_Sport_MainDataSet.DataSetName = "DB_Sport_MainDataSet";
			this.dB_Sport_MainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sportsmansAdapterBindingSource
			// 
			this.sportsmansAdapterBindingSource.DataMember = "SportsmansAdapter";
			this.sportsmansAdapterBindingSource.DataSource = this.dB_Sport_MainDataSet;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// dateOfBirthDataGridViewTextBoxColumn
			// 
			this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
			this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
			this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
			// 
			// victoryCountDataGridViewTextBoxColumn
			// 
			this.victoryCountDataGridViewTextBoxColumn.DataPropertyName = "VictoryCount";
			this.victoryCountDataGridViewTextBoxColumn.HeaderText = "Число побед";
			this.victoryCountDataGridViewTextBoxColumn.Name = "victoryCountDataGridViewTextBoxColumn";
			// 
			// nationalityDataGridViewTextBoxColumn
			// 
			this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
			this.nationalityDataGridViewTextBoxColumn.HeaderText = "Национальность";
			this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
			// 
			// countryIdDataGridViewTextBoxColumn
			// 
			this.countryIdDataGridViewTextBoxColumn.DataPropertyName = "CountryId";
			this.countryIdDataGridViewTextBoxColumn.HeaderText = "CountryId";
			this.countryIdDataGridViewTextBoxColumn.Name = "countryIdDataGridViewTextBoxColumn";
			// 
			// biographyDataGridViewTextBoxColumn
			// 
			this.biographyDataGridViewTextBoxColumn.DataPropertyName = "Biography";
			this.biographyDataGridViewTextBoxColumn.HeaderText = "Биография";
			this.biographyDataGridViewTextBoxColumn.Name = "biographyDataGridViewTextBoxColumn";
			// 
			// typeOfSportDataGridViewTextBoxColumn
			// 
			this.typeOfSportDataGridViewTextBoxColumn.DataPropertyName = "TypeOfSport";
			this.typeOfSportDataGridViewTextBoxColumn.HeaderText = "Вид спорта";
			this.typeOfSportDataGridViewTextBoxColumn.Name = "typeOfSportDataGridViewTextBoxColumn";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1673, 620);
			this.Controls.Add(this.tabControl1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dB_Sport_MainDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sportsmansAdapterBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private DB_Sport_MainDataSetTableAdapters.SportsmansAdapterTableAdapter sportsmansAdapterTableAdapter1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource sportsmansAdapterBindingSource;
		private DB_Sport_MainDataSet dB_Sport_MainDataSet;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn victoryCountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn biographyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeOfSportDataGridViewTextBoxColumn;
	}
}