namespace CrimeInvestigation.Forms
{
    partial class CreateCriminalCase
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
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.groupBoxAddData = new System.Windows.Forms.GroupBox();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboComplexity = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.groupBoxAddData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureAvatar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAddData, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.24426F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.75574F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAvatar.Location = new System.Drawing.Point(3, 3);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(464, 364);
            this.pictureAvatar.TabIndex = 2;
            this.pictureAvatar.TabStop = false;
            // 
            // groupBoxAddData
            // 
            this.groupBoxAddData.Controls.Add(this.checkBoxRandom);
            this.groupBoxAddData.Controls.Add(this.label2);
            this.groupBoxAddData.Controls.Add(this.buttonSubmit);
            this.groupBoxAddData.Controls.Add(this.label1);
            this.groupBoxAddData.Controls.Add(this.textBoxName);
            this.groupBoxAddData.Controls.Add(this.comboComplexity);
            this.groupBoxAddData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddData.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.groupBoxAddData.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddData.Location = new System.Drawing.Point(3, 373);
            this.groupBoxAddData.Name = "groupBoxAddData";
            this.groupBoxAddData.Size = new System.Drawing.Size(464, 103);
            this.groupBoxAddData.TabIndex = 1;
            this.groupBoxAddData.TabStop = false;
            this.groupBoxAddData.Text = "Данные об уголовном деле";
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.Location = new System.Drawing.Point(280, 70);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(129, 19);
            this.checkBoxRandom.TabIndex = 1;
            this.checkBoxRandom.Text = "Случайный выбор";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DimGray;
            this.buttonSubmit.Location = new System.Drawing.Point(6, 63);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(116, 30);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Добавить";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сложность";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(6, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(240, 22);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // comboComplexity
            // 
            this.comboComplexity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboComplexity.FormattingEnabled = true;
            this.comboComplexity.Location = new System.Drawing.Point(280, 34);
            this.comboComplexity.Name = "comboComplexity";
            this.comboComplexity.Size = new System.Drawing.Size(175, 23);
            this.comboComplexity.TabIndex = 0;
            this.comboComplexity.SelectedIndexChanged += new System.EventHandler(this.comboComplexity_SelectedIndexChanged);
            // 
            // CreateCriminalCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "CreateCriminalCase";
            this.Text = "Оформление уголовного дела";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.groupBoxAddData.ResumeLayout(false);
            this.groupBoxAddData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.GroupBox groupBoxAddData;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboComplexity;
    }
}