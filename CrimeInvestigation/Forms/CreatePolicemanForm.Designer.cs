namespace CrimeInvestigation.Forms
{
    partial class CreatePolicemanForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxRandom = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBoxAddData = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboRank = new System.Windows.Forms.ComboBox();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxAddData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.331F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.669F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxAddData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureAvatar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.70035F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.29965F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 317);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxRandom);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(3, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxRandom
            // 
            this.checkBoxRandom.AutoSize = true;
            this.checkBoxRandom.ForeColor = System.Drawing.Color.White;
            this.checkBoxRandom.Location = new System.Drawing.Point(98, 25);
            this.checkBoxRandom.Name = "checkBoxRandom";
            this.checkBoxRandom.Size = new System.Drawing.Size(129, 19);
            this.checkBoxRandom.TabIndex = 1;
            this.checkBoxRandom.Text = "Случайный выбор";
            this.checkBoxRandom.UseVisualStyleBackColor = true;
            this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.DimGray;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(9, 19);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 28);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Добавить";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // groupBoxAddData
            // 
            this.groupBoxAddData.BackColor = System.Drawing.Color.Black;
            this.groupBoxAddData.Controls.Add(this.label3);
            this.groupBoxAddData.Controls.Add(this.label2);
            this.groupBoxAddData.Controls.Add(this.textBoxLName);
            this.groupBoxAddData.Controls.Add(this.textBoxFName);
            this.groupBoxAddData.Controls.Add(this.label1);
            this.groupBoxAddData.Controls.Add(this.comboRank);
            this.groupBoxAddData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAddData.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.groupBoxAddData.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAddData.Name = "groupBoxAddData";
            this.groupBoxAddData.Size = new System.Drawing.Size(233, 240);
            this.groupBoxAddData.TabIndex = 1;
            this.groupBoxAddData.TabStop = false;
            this.groupBoxAddData.Text = "Личные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLName.Location = new System.Drawing.Point(13, 91);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(196, 22);
            this.textBoxLName.TabIndex = 3;
            this.textBoxLName.TextChanged += new System.EventHandler(this.textBoxLName_TextChanged);
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFName.Location = new System.Drawing.Point(13, 40);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(196, 22);
            this.textBoxFName.TabIndex = 2;
            this.textBoxFName.TextChanged += new System.EventHandler(this.textBoxFName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Звание";
            // 
            // comboRank
            // 
            this.comboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRank.FormattingEnabled = true;
            this.comboRank.Location = new System.Drawing.Point(13, 143);
            this.comboRank.Name = "comboRank";
            this.comboRank.Size = new System.Drawing.Size(196, 23);
            this.comboRank.TabIndex = 0;
            this.comboRank.SelectedIndexChanged += new System.EventHandler(this.comboRank_SelectedIndexChanged);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureAvatar.Location = new System.Drawing.Point(242, 3);
            this.pictureAvatar.Name = "pictureAvatar";
            this.tableLayoutPanel1.SetRowSpan(this.pictureAvatar, 2);
            this.pictureAvatar.Size = new System.Drawing.Size(335, 311);
            this.pictureAvatar.TabIndex = 2;
            this.pictureAvatar.TabStop = false;
            // 
            // CreatePolicemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 317);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimizeBox = false;
            this.Name = "CreatePolicemanForm";
            this.Text = "Оформление нового полицейского";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxAddData.ResumeLayout(false);
            this.groupBoxAddData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxRandom;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.GroupBox groupBoxAddData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboRank;
        private System.Windows.Forms.PictureBox pictureAvatar;
    }
}