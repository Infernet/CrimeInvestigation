﻿namespace CrimeInvestigation.Forms
{
    partial class PolicemanViewForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAddData = new System.Windows.Forms.GroupBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxAddData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 352F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAddData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureAvatar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 317);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBoxAddData
            // 
            this.groupBoxAddData.Controls.Add(this.textBoxRank);
            this.groupBoxAddData.Controls.Add(this.label3);
            this.groupBoxAddData.Controls.Add(this.label2);
            this.groupBoxAddData.Controls.Add(this.textBoxLName);
            this.groupBoxAddData.Controls.Add(this.textBoxFName);
            this.groupBoxAddData.Controls.Add(this.label1);
            this.groupBoxAddData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddData.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.groupBoxAddData.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAddData.Name = "groupBoxAddData";
            this.groupBoxAddData.Size = new System.Drawing.Size(222, 311);
            this.groupBoxAddData.TabIndex = 1;
            this.groupBoxAddData.TabStop = false;
            this.groupBoxAddData.Text = "Личные данные";
            // 
            // textBoxRank
            // 
            this.textBoxRank.Enabled = false;
            this.textBoxRank.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRank.Location = new System.Drawing.Point(13, 168);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(196, 22);
            this.textBoxRank.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Enabled = false;
            this.textBoxLName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLName.Location = new System.Drawing.Point(13, 113);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(196, 22);
            this.textBoxLName.TabIndex = 3;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Enabled = false;
            this.textBoxFName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFName.Location = new System.Drawing.Point(13, 60);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(196, 22);
            this.textBoxFName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Звание";
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAvatar.Location = new System.Drawing.Point(231, 3);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(346, 311);
            this.pictureAvatar.TabIndex = 2;
            this.pictureAvatar.TabStop = false;
            // 
            // PolicemanViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 317);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "PolicemanViewForm";
            this.Text = "Карточка полицейского";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxAddData.ResumeLayout(false);
            this.groupBoxAddData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxAddData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.TextBox textBoxRank;
    }
}