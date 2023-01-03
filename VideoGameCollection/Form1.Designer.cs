namespace VideoGameCollection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.videoGameModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoGameModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.PlatformTextBox = new System.Windows.Forms.TextBox();
            this.OwnedTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ImportFromCsv = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.videoGameModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGameModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGameModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGameModelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.ownedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Id});
            this.dataGridView1.DataSource = this.videoGameModelBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(27, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(802, 316);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // videoGameModelBindingSource1
            // 
            this.videoGameModelBindingSource1.DataSource = typeof(VideoGameCollection.VideoGameModel);
            // 
            // videoGameModelBindingSource
            // 
            this.videoGameModelBindingSource.DataSource = typeof(VideoGameCollection.VideoGameModel);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(66, 54);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameTextBox.TabIndex = 2;
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(172, 54);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(100, 23);
            this.PublisherTextBox.TabIndex = 3;
            // 
            // PlatformTextBox
            // 
            this.PlatformTextBox.Location = new System.Drawing.Point(278, 54);
            this.PlatformTextBox.Name = "PlatformTextBox";
            this.PlatformTextBox.Size = new System.Drawing.Size(100, 23);
            this.PlatformTextBox.TabIndex = 4;
            // 
            // OwnedTextBox
            // 
            this.OwnedTextBox.Location = new System.Drawing.Point(384, 54);
            this.OwnedTextBox.Name = "OwnedTextBox";
            this.OwnedTextBox.Size = new System.Drawing.Size(100, 23);
            this.OwnedTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(490, 54);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.PriceTextBox.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "AddGame";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ImportFromCsv
            // 
            this.ImportFromCsv.Location = new System.Drawing.Point(46, 455);
            this.ImportFromCsv.Name = "ImportFromCsv";
            this.ImportFromCsv.Size = new System.Drawing.Size(205, 23);
            this.ImportFromCsv.TabIndex = 8;
            this.ImportFromCsv.Text = "ImportGamesFromCSV";
            this.ImportFromCsv.UseVisualStyleBackColor = true;
            this.ImportFromCsv.Click += new System.EventHandler(this.ImportFromCsv_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(711, 54);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(95, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "DeleteGame";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(825, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "UpdateGame";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(22, 54);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(38, 23);
            this.IdTextBox.TabIndex = 11;
            // 
            // videoGameModelBindingSource2
            // 
            this.videoGameModelBindingSource2.DataSource = typeof(VideoGameCollection.VideoGameModel);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            // 
            // ownedDataGridViewTextBoxColumn
            // 
            this.ownedDataGridViewTextBoxColumn.DataPropertyName = "Owned";
            this.ownedDataGridViewTextBoxColumn.HeaderText = "Owned";
            this.ownedDataGridViewTextBoxColumn.Name = "ownedDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 572);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ImportFromCsv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.OwnedTextBox);
            this.Controls.Add(this.PlatformTextBox);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "VideoGameCollection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGameModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGameModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoGameModelBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource videoGameModelBindingSource;
        private TextBox NameTextBox;
        private TextBox PublisherTextBox;
        private TextBox PlatformTextBox;
        private TextBox OwnedTextBox;
        private TextBox PriceTextBox;
        private Button button2;
        private Button ImportFromCsv;
        private OpenFileDialog openFileDialog1;
        private Button DeleteButton;
        private Button button3;
        private TextBox IdTextBox;
        private BindingSource videoGameModelBindingSource1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private BindingSource videoGameModelBindingSource2;
    }
}