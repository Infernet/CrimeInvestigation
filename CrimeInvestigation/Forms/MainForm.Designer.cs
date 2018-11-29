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
            this.viewPolicemen = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewCriminals = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonShowPoliceman = new System.Windows.Forms.Button();
            this.buttonRemovePoliceman = new System.Windows.Forms.Button();
            this.buttonAddPoliceman = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.viewPolicemen);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Полицейский состав";
            // 
            // viewPolicemen
            // 
            this.viewPolicemen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPolicemen.Location = new System.Drawing.Point(3, 16);
            this.viewPolicemen.MultiSelect = false;
            this.viewPolicemen.Name = "viewPolicemen";
            this.viewPolicemen.Size = new System.Drawing.Size(443, 281);
            this.viewPolicemen.TabIndex = 0;
            this.viewPolicemen.UseCompatibleStateImageBehavior = false;
            this.viewPolicemen.View = System.Windows.Forms.View.List;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewCriminals);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(458, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Уголовные дела";
            // 
            // viewCriminals
            // 
            this.viewCriminals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCriminals.Location = new System.Drawing.Point(3, 16);
            this.viewCriminals.MultiSelect = false;
            this.viewCriminals.Name = "viewCriminals";
            this.viewCriminals.Size = new System.Drawing.Size(393, 281);
            this.viewCriminals.TabIndex = 0;
            this.viewCriminals.UseCompatibleStateImageBehavior = false;
            this.viewCriminals.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonShowPoliceman);
            this.groupBox3.Controls.Add(this.buttonRemovePoliceman);
            this.groupBox3.Controls.Add(this.buttonAddPoliceman);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление списком полиции";
            // 
            // buttonShowPoliceman
            // 
            this.buttonShowPoliceman.Location = new System.Drawing.Point(301, 20);
            this.buttonShowPoliceman.Name = "buttonShowPoliceman";
            this.buttonShowPoliceman.Size = new System.Drawing.Size(141, 26);
            this.buttonShowPoliceman.TabIndex = 2;
            this.buttonShowPoliceman.Text = "Подробнее";
            this.buttonShowPoliceman.UseVisualStyleBackColor = true;
            // 
            // buttonRemovePoliceman
            // 
            this.buttonRemovePoliceman.Location = new System.Drawing.Point(154, 20);
            this.buttonRemovePoliceman.Name = "buttonRemovePoliceman";
            this.buttonRemovePoliceman.Size = new System.Drawing.Size(141, 26);
            this.buttonRemovePoliceman.TabIndex = 1;
            this.buttonRemovePoliceman.Text = "Отправить в отставку";
            this.buttonRemovePoliceman.UseVisualStyleBackColor = true;
            // 
            // buttonAddPoliceman
            // 
            this.buttonAddPoliceman.Location = new System.Drawing.Point(7, 20);
            this.buttonAddPoliceman.Name = "buttonAddPoliceman";
            this.buttonAddPoliceman.Size = new System.Drawing.Size(141, 26);
            this.buttonAddPoliceman.TabIndex = 0;
            this.buttonAddPoliceman.Text = "Добавить полицейского";
            this.buttonAddPoliceman.UseVisualStyleBackColor = true;
            this.buttonAddPoliceman.Click += new System.EventHandler(this.buttonAddPoliceman_Click);
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(854, 137);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Логи";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(848, 118);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonShowCriminal);
            this.groupBox5.Controls.Add(this.buttonCriminalSendToPolice);
            this.groupBox5.Controls.Add(this.buttonRemoveCriminal);
            this.groupBox5.Controls.Add(this.buttonAddCriminal);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(458, 309);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 52);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Управление уголовными делами";
            // 
            // buttonShowCriminal
            // 
            this.buttonShowCriminal.Location = new System.Drawing.Point(212, 19);
            this.buttonShowCriminal.Name = "buttonShowCriminal";
            this.buttonShowCriminal.Size = new System.Drawing.Size(87, 26);
            this.buttonShowCriminal.TabIndex = 5;
            this.buttonShowCriminal.Text = "Посмотреть";
            this.buttonShowCriminal.UseVisualStyleBackColor = true;
            // 
            // buttonCriminalSendToPolice
            // 
            this.buttonCriminalSendToPolice.Location = new System.Drawing.Point(305, 19);
            this.buttonCriminalSendToPolice.Name = "buttonCriminalSendToPolice";
            this.buttonCriminalSendToPolice.Size = new System.Drawing.Size(87, 26);
            this.buttonCriminalSendToPolice.TabIndex = 4;
            this.buttonCriminalSendToPolice.Text = "Расследовать";
            this.buttonCriminalSendToPolice.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveCriminal
            // 
            this.buttonRemoveCriminal.Location = new System.Drawing.Point(99, 19);
            this.buttonRemoveCriminal.Name = "buttonRemoveCriminal";
            this.buttonRemoveCriminal.Size = new System.Drawing.Size(87, 26);
            this.buttonRemoveCriminal.TabIndex = 3;
            this.buttonRemoveCriminal.Text = "Удалить";
            this.buttonRemoveCriminal.UseVisualStyleBackColor = true;
            // 
            // buttonAddCriminal
            // 
            this.buttonAddCriminal.Location = new System.Drawing.Point(6, 19);
            this.buttonAddCriminal.Name = "buttonAddCriminal";
            this.buttonAddCriminal.Size = new System.Drawing.Size(87, 26);
            this.buttonAddCriminal.TabIndex = 2;
            this.buttonAddCriminal.Text = "Добавить";
            this.buttonAddCriminal.UseVisualStyleBackColor = true;
            this.buttonAddCriminal.Click += new System.EventHandler(this.buttonAddCriminal_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.90698F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.09302F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.0399F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.9601F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 507);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 507);
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
        private System.Windows.Forms.ListView viewPolicemen;
        private System.Windows.Forms.ListView viewCriminals;
        private System.Windows.Forms.Button buttonAddPoliceman;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonShowPoliceman;
        private System.Windows.Forms.Button buttonRemovePoliceman;
        private System.Windows.Forms.Button buttonShowCriminal;
        private System.Windows.Forms.Button buttonCriminalSendToPolice;
        private System.Windows.Forms.Button buttonRemoveCriminal;
        private System.Windows.Forms.Button buttonAddCriminal;
    }
}