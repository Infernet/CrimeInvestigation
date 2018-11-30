namespace CrimeInvestigation.Forms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPolicemen = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCriminalCases = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShowPoliceman = new System.Windows.Forms.Button();
            this.buttonRemovePoliceman = new System.Windows.Forms.Button();
            this.buttonAddPoliceman = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonShowCriminal = new System.Windows.Forms.Button();
            this.buttonCriminalSendToPolice = new System.Windows.Forms.Button();
            this.buttonRemoveCriminal = new System.Windows.Forms.Button();
            this.buttonAddCriminal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.listBoxPolicemen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Полицейский состав";
            // 
            // listBoxPolicemen
            // 
            this.listBoxPolicemen.BackColor = System.Drawing.Color.LightGray;
            this.listBoxPolicemen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPolicemen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPolicemen.FormattingEnabled = true;
            this.listBoxPolicemen.HorizontalScrollbar = true;
            this.listBoxPolicemen.ItemHeight = 17;
            this.listBoxPolicemen.Location = new System.Drawing.Point(3, 16);
            this.listBoxPolicemen.Name = "listBoxPolicemen";
            this.listBoxPolicemen.Size = new System.Drawing.Size(418, 289);
            this.listBoxPolicemen.TabIndex = 0;
            this.listBoxPolicemen.SelectedIndexChanged += new System.EventHandler(this.listBoxPolicemen_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxCriminalCases);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(433, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уголовные дела";
            // 
            // listBoxCriminalCases
            // 
            this.listBoxCriminalCases.BackColor = System.Drawing.Color.LightGray;
            this.listBoxCriminalCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCriminalCases.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCriminalCases.FormattingEnabled = true;
            this.listBoxCriminalCases.HorizontalScrollbar = true;
            this.listBoxCriminalCases.ItemHeight = 17;
            this.listBoxCriminalCases.Location = new System.Drawing.Point(3, 16);
            this.listBoxCriminalCases.Name = "listBoxCriminalCases";
            this.listBoxCriminalCases.Size = new System.Drawing.Size(418, 289);
            this.listBoxCriminalCases.TabIndex = 0;
            this.listBoxCriminalCases.SelectedIndexChanged += new System.EventHandler(this.listBoxCriminalCases_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShowPoliceman);
            this.groupBox3.Controls.Add(this.buttonRemovePoliceman);
            this.groupBox3.Controls.Add(this.buttonAddPoliceman);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(424, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление списком полиции";
            // 
            // buttonShowPoliceman
            // 
            this.buttonShowPoliceman.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowPoliceman.ForeColor = System.Drawing.Color.White;
            this.buttonShowPoliceman.Location = new System.Drawing.Point(301, 19);
            this.buttonShowPoliceman.Name = "buttonShowPoliceman";
            this.buttonShowPoliceman.Size = new System.Drawing.Size(74, 26);
            this.buttonShowPoliceman.TabIndex = 2;
            this.buttonShowPoliceman.Text = "Подробнее";
            this.buttonShowPoliceman.UseVisualStyleBackColor = false;
            this.buttonShowPoliceman.Click += new System.EventHandler(this.buttonShowPoliceman_Click);
            // 
            // buttonRemovePoliceman
            // 
            this.buttonRemovePoliceman.BackColor = System.Drawing.Color.DimGray;
            this.buttonRemovePoliceman.ForeColor = System.Drawing.Color.White;
            this.buttonRemovePoliceman.Location = new System.Drawing.Point(154, 19);
            this.buttonRemovePoliceman.Name = "buttonRemovePoliceman";
            this.buttonRemovePoliceman.Size = new System.Drawing.Size(141, 26);
            this.buttonRemovePoliceman.TabIndex = 1;
            this.buttonRemovePoliceman.Text = "Отправить в отставку";
            this.buttonRemovePoliceman.UseVisualStyleBackColor = false;
            this.buttonRemovePoliceman.Click += new System.EventHandler(this.buttonRemovePoliceman_Click);
            // 
            // buttonAddPoliceman
            // 
            this.buttonAddPoliceman.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddPoliceman.ForeColor = System.Drawing.Color.White;
            this.buttonAddPoliceman.Location = new System.Drawing.Point(7, 20);
            this.buttonAddPoliceman.Name = "buttonAddPoliceman";
            this.buttonAddPoliceman.Size = new System.Drawing.Size(141, 25);
            this.buttonAddPoliceman.TabIndex = 0;
            this.buttonAddPoliceman.Text = "Добавить полицейского";
            this.buttonAddPoliceman.UseVisualStyleBackColor = false;
            this.buttonAddPoliceman.Click += new System.EventHandler(this.buttonAddPoliceman_Click);
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.textBoxLogs);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(854, 194);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Логи";
            // 
            // textBoxLogs
            // 
            this.textBoxLogs.BackColor = System.Drawing.Color.LightGray;
            this.textBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogs.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogs.Location = new System.Drawing.Point(3, 16);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLogs.Size = new System.Drawing.Size(848, 175);
            this.textBoxLogs.TabIndex = 0;
            this.textBoxLogs.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonShowCriminal);
            this.groupBox5.Controls.Add(this.buttonCriminalSendToPolice);
            this.groupBox5.Controls.Add(this.buttonRemoveCriminal);
            this.groupBox5.Controls.Add(this.buttonAddCriminal);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(433, 317);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(424, 51);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление уголовными делами";
            // 
            // buttonShowCriminal
            // 
            this.buttonShowCriminal.BackColor = System.Drawing.Color.DimGray;
            this.buttonShowCriminal.ForeColor = System.Drawing.Color.White;
            this.buttonShowCriminal.Location = new System.Drawing.Point(235, 19);
            this.buttonShowCriminal.Name = "buttonShowCriminal";
            this.buttonShowCriminal.Size = new System.Drawing.Size(87, 26);
            this.buttonShowCriminal.TabIndex = 5;
            this.buttonShowCriminal.Text = "Посмотреть";
            this.buttonShowCriminal.UseVisualStyleBackColor = false;
            this.buttonShowCriminal.Click += new System.EventHandler(this.buttonShowCriminal_Click);
            // 
            // buttonCriminalSendToPolice
            // 
            this.buttonCriminalSendToPolice.BackColor = System.Drawing.Color.DimGray;
            this.buttonCriminalSendToPolice.ForeColor = System.Drawing.Color.White;
            this.buttonCriminalSendToPolice.Location = new System.Drawing.Point(328, 19);
            this.buttonCriminalSendToPolice.Name = "buttonCriminalSendToPolice";
            this.buttonCriminalSendToPolice.Size = new System.Drawing.Size(87, 26);
            this.buttonCriminalSendToPolice.TabIndex = 4;
            this.buttonCriminalSendToPolice.Text = "Расследовать";
            this.buttonCriminalSendToPolice.UseVisualStyleBackColor = false;
            this.buttonCriminalSendToPolice.Click += new System.EventHandler(this.buttonCriminalSendToPolice_Click);
            // 
            // buttonRemoveCriminal
            // 
            this.buttonRemoveCriminal.BackColor = System.Drawing.Color.DimGray;
            this.buttonRemoveCriminal.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveCriminal.Location = new System.Drawing.Point(99, 19);
            this.buttonRemoveCriminal.Name = "buttonRemoveCriminal";
            this.buttonRemoveCriminal.Size = new System.Drawing.Size(87, 26);
            this.buttonRemoveCriminal.TabIndex = 3;
            this.buttonRemoveCriminal.Text = "Удалить";
            this.buttonRemoveCriminal.UseVisualStyleBackColor = false;
            this.buttonRemoveCriminal.Click += new System.EventHandler(this.buttonRemoveCriminal_Click);
            // 
            // buttonAddCriminal
            // 
            this.buttonAddCriminal.BackColor = System.Drawing.Color.DimGray;
            this.buttonAddCriminal.ForeColor = System.Drawing.Color.White;
            this.buttonAddCriminal.Location = new System.Drawing.Point(6, 19);
            this.buttonAddCriminal.Name = "buttonAddCriminal";
            this.buttonAddCriminal.Size = new System.Drawing.Size(87, 26);
            this.buttonAddCriminal.TabIndex = 2;
            this.buttonAddCriminal.Text = "Добавить";
            this.buttonAddCriminal.UseVisualStyleBackColor = false;
            this.buttonAddCriminal.Click += new System.EventHandler(this.buttonAddCriminal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 571);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 571);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonAddPoliceman;
        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.Button buttonShowPoliceman;
        private System.Windows.Forms.Button buttonRemovePoliceman;
        private System.Windows.Forms.Button buttonShowCriminal;
        private System.Windows.Forms.Button buttonCriminalSendToPolice;
        private System.Windows.Forms.Button buttonRemoveCriminal;
        private System.Windows.Forms.Button buttonAddCriminal;
        private System.Windows.Forms.ListBox listBoxPolicemen;
        private System.Windows.Forms.ListBox listBoxCriminalCases;
    }
}