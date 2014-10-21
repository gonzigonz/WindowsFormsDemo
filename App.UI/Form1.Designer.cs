using System;

namespace App.UI
{
    partial class Form1
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.toolStripCategoresLabel = new System.Windows.Forms.ToolStripLabel();
         this.toolStripCategoriesComboBox = new System.Windows.Forms.ToolStripComboBox();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripSourceLabel = new System.Windows.Forms.ToolStripLabel();
         this.toolStripSourceComboBox = new System.Windows.Forms.ToolStripComboBox();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripAddButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripDeleteButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripBackButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripNextButton = new System.Windows.Forms.ToolStripButton();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.SaveButton = new System.Windows.Forms.ToolStripButton();
         this.tabControl1 = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.PriceTextBox = new System.Windows.Forms.TextBox();
         this.NameTextBox = new System.Windows.Forms.TextBox();
         this.ProductsListBox = new System.Windows.Forms.ListBox();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
         this.toolStrip1.SuspendLayout();
         this.tabControl1.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.tabPage2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
         this.SuspendLayout();
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCategoresLabel,
            this.toolStripCategoriesComboBox,
            this.toolStripSeparator1,
            this.toolStripSourceLabel,
            this.toolStripSourceComboBox,
            this.toolStripSeparator2,
            this.toolStripAddButton,
            this.toolStripDeleteButton,
            this.toolStripSeparator3,
            this.toolStripBackButton,
            this.toolStripNextButton,
            this.toolStripSeparator4,
            this.SaveButton});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
         this.toolStrip1.Size = new System.Drawing.Size(736, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // toolStripCategoresLabel
         // 
         this.toolStripCategoresLabel.Name = "toolStripCategoresLabel";
         this.toolStripCategoresLabel.Size = new System.Drawing.Size(58, 22);
         this.toolStripCategoresLabel.Text = "Category:";
         // 
         // toolStripCategoriesComboBox
         // 
         this.toolStripCategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.toolStripCategoriesComboBox.Name = "toolStripCategoriesComboBox";
         this.toolStripCategoriesComboBox.Size = new System.Drawing.Size(77, 25);
         this.toolStripCategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripCategoriesComboBox_SelectedIndexChanged);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
         // 
         // toolStripSourceLabel
         // 
         this.toolStripSourceLabel.Name = "toolStripSourceLabel";
         this.toolStripSourceLabel.Size = new System.Drawing.Size(46, 22);
         this.toolStripSourceLabel.Text = "Source:";
         // 
         // toolStripSourceComboBox
         // 
         this.toolStripSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.toolStripSourceComboBox.Items.AddRange(new object[] {
            "Object",
            "DataSet",
            "LINQ to SQL"});
         this.toolStripSourceComboBox.Name = "toolStripSourceComboBox";
         this.toolStripSourceComboBox.Size = new System.Drawing.Size(77, 25);
         this.toolStripSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripSourceComboBox_SelectedIndexChanged);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
         // 
         // toolStripAddButton
         // 
         this.toolStripAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripAddButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAddButton.Image")));
         this.toolStripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripAddButton.Name = "toolStripAddButton";
         this.toolStripAddButton.Size = new System.Drawing.Size(33, 22);
         this.toolStripAddButton.Text = "Add";
         this.toolStripAddButton.Click += new System.EventHandler(this.toolStripAddButton_Click);
         // 
         // toolStripDeleteButton
         // 
         this.toolStripDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDeleteButton.Image")));
         this.toolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripDeleteButton.Name = "toolStripDeleteButton";
         this.toolStripDeleteButton.Size = new System.Drawing.Size(44, 22);
         this.toolStripDeleteButton.Text = "Delete";
         this.toolStripDeleteButton.Click += new System.EventHandler(this.toolStripDeleteButton_Click);
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
         // 
         // toolStripBackButton
         // 
         this.toolStripBackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripBackButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackButton.Image")));
         this.toolStripBackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripBackButton.Name = "toolStripBackButton";
         this.toolStripBackButton.Size = new System.Drawing.Size(44, 22);
         this.toolStripBackButton.Text = "<Back";
         this.toolStripBackButton.Click += new System.EventHandler(this.toolStripBackButton_Click);
         // 
         // toolStripNextButton
         // 
         this.toolStripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.toolStripNextButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNextButton.Image")));
         this.toolStripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.toolStripNextButton.Name = "toolStripNextButton";
         this.toolStripNextButton.Size = new System.Drawing.Size(43, 22);
         this.toolStripNextButton.Text = "Next>";
         this.toolStripNextButton.Click += new System.EventHandler(this.toolStripNextButton_Click);
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
         // 
         // SaveButton
         // 
         this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
         this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
         this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.SaveButton.Name = "SaveButton";
         this.SaveButton.Size = new System.Drawing.Size(35, 22);
         this.SaveButton.Text = "Save";
         this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
         // 
         // tabControl1
         // 
         this.tabControl1.Controls.Add(this.tabPage1);
         this.tabControl1.Controls.Add(this.tabPage2);
         this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl1.Location = new System.Drawing.Point(0, 25);
         this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
         this.tabControl1.Name = "tabControl1";
         this.tabControl1.SelectedIndex = 0;
         this.tabControl1.Size = new System.Drawing.Size(736, 447);
         this.tabControl1.TabIndex = 1;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.PriceTextBox);
         this.tabPage1.Controls.Add(this.NameTextBox);
         this.tabPage1.Controls.Add(this.ProductsListBox);
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
         this.tabPage1.Size = new System.Drawing.Size(728, 421);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "Form";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // PriceTextBox
         // 
         this.PriceTextBox.Location = new System.Drawing.Point(333, 113);
         this.PriceTextBox.Margin = new System.Windows.Forms.Padding(2);
         this.PriceTextBox.Name = "PriceTextBox";
         this.PriceTextBox.Size = new System.Drawing.Size(166, 20);
         this.PriceTextBox.TabIndex = 3;
         // 
         // NameTextBox
         // 
         this.NameTextBox.Location = new System.Drawing.Point(333, 84);
         this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
         this.NameTextBox.Name = "NameTextBox";
         this.NameTextBox.Size = new System.Drawing.Size(166, 20);
         this.NameTextBox.TabIndex = 2;
         // 
         // ProductsListBox
         // 
         this.ProductsListBox.FormattingEnabled = true;
         this.ProductsListBox.Location = new System.Drawing.Point(28, 32);
         this.ProductsListBox.Margin = new System.Windows.Forms.Padding(2);
         this.ProductsListBox.Name = "ProductsListBox";
         this.ProductsListBox.Size = new System.Drawing.Size(197, 264);
         this.ProductsListBox.TabIndex = 1;
         // 
         // tabPage2
         // 
         this.tabPage2.Controls.Add(this.ProductsDataGridView);
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
         this.tabPage2.Size = new System.Drawing.Size(728, 421);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "Grid";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // ProductsDataGridView
         // 
         this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
         this.ProductsDataGridView.Location = new System.Drawing.Point(2, 2);
         this.ProductsDataGridView.Margin = new System.Windows.Forms.Padding(2);
         this.ProductsDataGridView.Name = "ProductsDataGridView";
         this.ProductsDataGridView.RowTemplate.Height = 33;
         this.ProductsDataGridView.Size = new System.Drawing.Size(724, 417);
         this.ProductsDataGridView.TabIndex = 0;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(736, 472);
         this.Controls.Add(this.tabControl1);
         this.Controls.Add(this.toolStrip1);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         this.tabControl1.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.tabPage1.PerformLayout();
         this.tabPage2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripCategoresLabel;
        private System.Windows.Forms.ToolStripComboBox toolStripCategoriesComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripSourceLabel;
        private System.Windows.Forms.ToolStripComboBox toolStripSourceComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripAddButton;
        private System.Windows.Forms.ToolStripButton toolStripDeleteButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripBackButton;
        private System.Windows.Forms.ToolStripButton toolStripNextButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton SaveButton;

    }
}

