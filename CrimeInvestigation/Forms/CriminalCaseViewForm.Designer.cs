namespace CrimeInvestigation.Forms
{
    partial class CriminalCaseViewForm
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
            this.textBoxPoliceman = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComplexity = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // groupBoxAddData
            // 
            this.groupBoxAddData.Controls.Add(this.textBoxPoliceman);
            this.groupBoxAddData.Controls.Add(this.label4);
            this.groupBoxAddData.Controls.Add(this.textBoxStatus);
            this.groupBoxAddData.Controls.Add(this.label3);
            this.groupBoxAddData.Controls.Add(this.label2);
            this.groupBoxAddData.Controls.Add(this.textBoxComplexity);
            this.groupBoxAddData.Controls.Add(this.textBoxName);
            this.groupBoxAddData.Controls.Add(this.label1);
            this.groupBoxAddData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddData.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.groupBoxAddData.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAddData.Name = "groupBoxAddData";
            this.groupBoxAddData.Size = new System.Drawing.Size(222, 311);
            this.groupBoxAddData.TabIndex = 1;
            this.groupBoxAddData.TabStop = false;
            this.groupBoxAddData.Text = "Информация";
            // 
            // textBoxPoliceman
            // 
            this.textBoxPoliceman.Enabled = false;
            this.textBoxPoliceman.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoliceman.Location = new System.Drawing.Point(13, 225);
            this.textBoxPoliceman.Name = "textBoxPoliceman";
            this.textBoxPoliceman.Size = new System.Drawing.Size(196, 22);
            this.textBoxPoliceman.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label4.Location = new System.Drawing.Point(10, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кто расследовал";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Enabled = false;
            this.textBoxStatus.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStatus.Location = new System.Drawing.Point(13, 168);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(196, 22);
            this.textBoxStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label3.Location = new System.Drawing.Point(10, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сложность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // textBoxComplexity
            // 
            this.textBoxComplexity.Enabled = false;
            this.textBoxComplexity.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxComplexity.Location = new System.Drawing.Point(13, 113);
            this.textBoxComplexity.Name = "textBoxComplexity";
            this.textBoxComplexity.Size = new System.Drawing.Size(196, 22);
            this.textBoxComplexity.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(13, 60);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(196, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label1.Location = new System.Drawing.Point(10, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статус";
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
            // CriminalCaseViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 317);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "CriminalCaseViewForm";
            this.Text = "Обзор уголовного дела";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxAddData.ResumeLayout(false);
            this.groupBoxAddData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxAddData;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComplexity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.TextBox textBoxPoliceman;
        private System.Windows.Forms.Label label4;
    }
}