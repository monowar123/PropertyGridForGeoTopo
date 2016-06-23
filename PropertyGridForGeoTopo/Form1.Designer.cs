namespace PropertyGridForGeoTopo
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtnYesToAll = new System.Windows.Forms.RadioButton();
            this.rbtnNoToAll = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.Location = new System.Drawing.Point(9, 7);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.propertyGrid1.Size = new System.Drawing.Size(367, 207);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(301, 223);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbtnYesToAll
            // 
            this.rbtnYesToAll.AutoSize = true;
            this.rbtnYesToAll.Location = new System.Drawing.Point(220, 7);
            this.rbtnYesToAll.Name = "rbtnYesToAll";
            this.rbtnYesToAll.Size = new System.Drawing.Size(68, 17);
            this.rbtnYesToAll.TabIndex = 3;
            this.rbtnYesToAll.TabStop = true;
            this.rbtnYesToAll.Text = "Yes to all";
            this.rbtnYesToAll.UseVisualStyleBackColor = true;
            this.rbtnYesToAll.CheckedChanged += new System.EventHandler(this.rbtnYesToAll_CheckedChanged);
            // 
            // rbtnNoToAll
            // 
            this.rbtnNoToAll.AutoSize = true;
            this.rbtnNoToAll.Location = new System.Drawing.Point(301, 7);
            this.rbtnNoToAll.Name = "rbtnNoToAll";
            this.rbtnNoToAll.Size = new System.Drawing.Size(64, 17);
            this.rbtnNoToAll.TabIndex = 4;
            this.rbtnNoToAll.TabStop = true;
            this.rbtnNoToAll.Text = "No to all";
            this.rbtnNoToAll.UseVisualStyleBackColor = true;
            this.rbtnNoToAll.CheckedChanged += new System.EventHandler(this.rbtnNoToAll_CheckedChanged);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 254);
            this.Controls.Add(this.rbtnNoToAll);
            this.Controls.Add(this.rbtnYesToAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.propertyGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbtnYesToAll;
        private System.Windows.Forms.RadioButton rbtnNoToAll;
    }
}

