namespace ExcelToJsonConverter
{
    partial class FormMain
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labSourceFile = new System.Windows.Forms.Label();
            this.dgExcel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rtxtJson = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labKey = new System.Windows.Forms.Label();
            this.comboKeyColumnNumber = new System.Windows.Forms.ComboBox();
            this.comboValueColumnNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgExcel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(112, 33);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(692, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(810, 31);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labSourceFile
            // 
            this.labSourceFile.AutoSize = true;
            this.labSourceFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSourceFile.Location = new System.Drawing.Point(14, 34);
            this.labSourceFile.Name = "labSourceFile";
            this.labSourceFile.Size = new System.Drawing.Size(76, 16);
            this.labSourceFile.TabIndex = 1;
            this.labSourceFile.Text = "Source File";
            // 
            // dgExcel
            // 
            this.dgExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExcel.Location = new System.Drawing.Point(17, 71);
            this.dgExcel.Name = "dgExcel";
            this.dgExcel.ReadOnly = true;
            this.dgExcel.Size = new System.Drawing.Size(868, 216);
            this.dgExcel.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgExcel);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.labSourceFile);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 304);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvert.Location = new System.Drawing.Point(754, 325);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(143, 45);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert to JSON";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rtxtJson
            // 
            this.rtxtJson.Location = new System.Drawing.Point(29, 387);
            this.rtxtJson.Name = "rtxtJson";
            this.rtxtJson.Size = new System.Drawing.Size(868, 174);
            this.rtxtJson.TabIndex = 4;
            this.rtxtJson.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(387, 610);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 43);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save JSON File";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labKey
            // 
            this.labKey.AutoSize = true;
            this.labKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labKey.Location = new System.Drawing.Point(39, 339);
            this.labKey.Name = "labKey";
            this.labKey.Size = new System.Drawing.Size(82, 16);
            this.labKey.TabIndex = 5;
            this.labKey.Text = "Key Column:";
            // 
            // comboKeyColumnNumber
            // 
            this.comboKeyColumnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKeyColumnNumber.FormattingEnabled = true;
            this.comboKeyColumnNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboKeyColumnNumber.Location = new System.Drawing.Point(127, 335);
            this.comboKeyColumnNumber.Name = "comboKeyColumnNumber";
            this.comboKeyColumnNumber.Size = new System.Drawing.Size(43, 24);
            this.comboKeyColumnNumber.TabIndex = 6;
            this.comboKeyColumnNumber.Text = "1";
            // 
            // comboValueColumnNumber
            // 
            this.comboValueColumnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboValueColumnNumber.FormattingEnabled = true;
            this.comboValueColumnNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboValueColumnNumber.Location = new System.Drawing.Point(377, 335);
            this.comboValueColumnNumber.Name = "comboValueColumnNumber";
            this.comboValueColumnNumber.Size = new System.Drawing.Size(44, 24);
            this.comboValueColumnNumber.TabIndex = 6;
            this.comboValueColumnNumber.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value Column:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(936, 694);
            this.Controls.Add(this.comboValueColumnNumber);
            this.Controls.Add(this.comboKeyColumnNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labKey);
            this.Controls.Add(this.rtxtJson);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSave);
            this.Name = "FormMain";
            this.Text = "Excel To Json Converter";
            ((System.ComponentModel.ISupportInitialize)(this.dgExcel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label labSourceFile;
        private System.Windows.Forms.DataGridView dgExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox rtxtJson;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labKey;
        private System.Windows.Forms.ComboBox comboKeyColumnNumber;
        private System.Windows.Forms.ComboBox comboValueColumnNumber;
        private System.Windows.Forms.Label label1;
    }
}

