﻿namespace AstroGrep.Windows.Forms
{
   partial class frmAddEditExclusions
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
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.cboTypes = new System.Windows.Forms.ComboBox();
         this.cboOptions = new System.Windows.Forms.ComboBox();
         this.lblType = new System.Windows.Forms.Label();
         this.lblValue = new System.Windows.Forms.Label();
         this.lblOptions = new System.Windows.Forms.Label();
         this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
         this.lblCategory = new System.Windows.Forms.Label();
         this.cboCategories = new System.Windows.Forms.ComboBox();
         this.fvtValue = new AstroGrep.Windows.Controls.FilterValueType();
         this.SuspendLayout();
         // 
         // btnOK
         // 
         this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnOK.Location = new System.Drawing.Point(111, 291);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 0;
         this.btnOK.Text = "&OK";
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.btnCancel.Location = new System.Drawing.Point(192, 291);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "&Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // cboTypes
         // 
         this.cboTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboTypes.FormattingEnabled = true;
         this.cboTypes.Location = new System.Drawing.Point(12, 80);
         this.cboTypes.Name = "cboTypes";
         this.cboTypes.Size = new System.Drawing.Size(252, 21);
         this.cboTypes.TabIndex = 2;
         this.cboTypes.SelectedIndexChanged += new System.EventHandler(this.cboTypes_SelectedIndexChanged);
         // 
         // cboOptions
         // 
         this.cboOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboOptions.FormattingEnabled = true;
         this.cboOptions.Location = new System.Drawing.Point(12, 203);
         this.cboOptions.Name = "cboOptions";
         this.cboOptions.Size = new System.Drawing.Size(252, 21);
         this.cboOptions.TabIndex = 4;
         // 
         // lblType
         // 
         this.lblType.AutoSize = true;
         this.lblType.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.lblType.Location = new System.Drawing.Point(12, 63);
         this.lblType.Name = "lblType";
         this.lblType.Size = new System.Drawing.Size(31, 13);
         this.lblType.TabIndex = 5;
         this.lblType.Text = "Type";
         // 
         // lblValue
         // 
         this.lblValue.AutoSize = true;
         this.lblValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.lblValue.Location = new System.Drawing.Point(12, 121);
         this.lblValue.Name = "lblValue";
         this.lblValue.Size = new System.Drawing.Size(34, 13);
         this.lblValue.TabIndex = 6;
         this.lblValue.Text = "Value";
         // 
         // lblOptions
         // 
         this.lblOptions.AutoSize = true;
         this.lblOptions.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.lblOptions.Location = new System.Drawing.Point(12, 187);
         this.lblOptions.Name = "lblOptions";
         this.lblOptions.Size = new System.Drawing.Size(43, 13);
         this.lblOptions.TabIndex = 7;
         this.lblOptions.Text = "Options";
         // 
         // chkIgnoreCase
         // 
         this.chkIgnoreCase.AutoSize = true;
         this.chkIgnoreCase.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.chkIgnoreCase.Location = new System.Drawing.Point(12, 230);
         this.chkIgnoreCase.Name = "chkIgnoreCase";
         this.chkIgnoreCase.Size = new System.Drawing.Size(88, 18);
         this.chkIgnoreCase.TabIndex = 8;
         this.chkIgnoreCase.Text = "Ignore case";
         this.chkIgnoreCase.UseVisualStyleBackColor = true;
         // 
         // lblCategory
         // 
         this.lblCategory.AutoSize = true;
         this.lblCategory.Location = new System.Drawing.Point(12, 9);
         this.lblCategory.Name = "lblCategory";
         this.lblCategory.Size = new System.Drawing.Size(49, 13);
         this.lblCategory.TabIndex = 9;
         this.lblCategory.Text = "Category";
         // 
         // cboCategories
         // 
         this.cboCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboCategories.FormattingEnabled = true;
         this.cboCategories.Location = new System.Drawing.Point(12, 25);
         this.cboCategories.Name = "cboCategories";
         this.cboCategories.Size = new System.Drawing.Size(252, 21);
         this.cboCategories.TabIndex = 10;
         this.cboCategories.SelectedIndexChanged += new System.EventHandler(this.cboCategories_SelectedIndexChanged);
         // 
         // fvtValue
         // 
         this.fvtValue.Location = new System.Drawing.Point(12, 137);
         this.fvtValue.Name = "fvtValue";
         this.fvtValue.Size = new System.Drawing.Size(255, 21);
         this.fvtValue.TabIndex = 11;
         this.fvtValue.Value = "";
         // 
         // frmAddEditExclusions
         // 
         this.AcceptButton = this.btnOK;
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.btnCancel;
         this.ClientSize = new System.Drawing.Size(279, 326);
         this.Controls.Add(this.fvtValue);
         this.Controls.Add(this.cboCategories);
         this.Controls.Add(this.lblCategory);
         this.Controls.Add(this.chkIgnoreCase);
         this.Controls.Add(this.lblOptions);
         this.Controls.Add(this.lblValue);
         this.Controls.Add(this.lblType);
         this.Controls.Add(this.cboOptions);
         this.Controls.Add(this.cboTypes);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOK);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAddEditExclusions";
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Exclusion";
         this.Load += new System.EventHandler(this.frmExclusions_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.ComboBox cboTypes;
      private System.Windows.Forms.ComboBox cboOptions;
      private System.Windows.Forms.Label lblType;
      private System.Windows.Forms.Label lblValue;
      private System.Windows.Forms.Label lblOptions;
      private System.Windows.Forms.CheckBox chkIgnoreCase;
      private System.Windows.Forms.Label lblCategory;
      private System.Windows.Forms.ComboBox cboCategories;
      private Controls.FilterValueType fvtValue;
   }
}