﻿namespace UI_Layer
{
    partial class UserPage
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTarget = new Label();
            lblTotal = new Label();
            lblAdSoyad = new Label();
            lblKilo = new Label();
            lblBoy = new Label();
            lblKiloLabel = new Label();
            lblBoyLabel = new Label();
            chboxAraOgun = new Guna.UI2.WinForms.Guna2CheckBox();
            chboxAksam = new Guna.UI2.WinForms.Guna2CheckBox();
            chboxOgle = new Guna.UI2.WinForms.Guna2CheckBox();
            chboxKahvalti = new Guna.UI2.WinForms.Guna2CheckBox();
            lviewGunluk = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnUpDay = new Guna.UI2.WinForms.Guna2Button();
            btnDownDay = new Guna.UI2.WinForms.Guna2Button();
            btnToday = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // lblTarget
            // 
            lblTarget.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTarget.ForeColor = Color.WhiteSmoke;
            lblTarget.Location = new Point(93, 150);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(428, 20);
            lblTarget.TabIndex = 104;
            lblTarget.Text = "Günlük İhtiyacım Olan Kalori:";
            lblTarget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.WhiteSmoke;
            lblTotal.Location = new Point(93, 115);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(428, 20);
            lblTotal.TabIndex = 102;
            lblTotal.Text = "Toplam Alınan Kalori:";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.ForeColor = Color.WhiteSmoke;
            lblAdSoyad.Location = new Point(93, 43);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(428, 20);
            lblAdSoyad.TabIndex = 101;
            lblAdSoyad.Text = "kullanıcı adı soyadı";
            lblAdSoyad.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKilo
            // 
            lblKilo.AutoSize = true;
            lblKilo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKilo.ForeColor = Color.WhiteSmoke;
            lblKilo.Location = new Point(356, 86);
            lblKilo.Name = "lblKilo";
            lblKilo.Size = new Size(49, 20);
            lblKilo.TabIndex = 100;
            lblKilo.Text = "80 cm";
            // 
            // lblBoy
            // 
            lblBoy.AutoSize = true;
            lblBoy.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBoy.ForeColor = Color.WhiteSmoke;
            lblBoy.Location = new Point(220, 86);
            lblBoy.Name = "lblBoy";
            lblBoy.Size = new Size(55, 20);
            lblBoy.TabIndex = 99;
            lblBoy.Text = "180 cm";
            // 
            // lblKiloLabel
            // 
            lblKiloLabel.AutoSize = true;
            lblKiloLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKiloLabel.ForeColor = Color.WhiteSmoke;
            lblKiloLabel.Location = new Point(308, 86);
            lblKiloLabel.Name = "lblKiloLabel";
            lblKiloLabel.Size = new Size(39, 20);
            lblKiloLabel.TabIndex = 98;
            lblKiloLabel.Text = "Kilo:";
            // 
            // lblBoyLabel
            // 
            lblBoyLabel.AutoSize = true;
            lblBoyLabel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBoyLabel.ForeColor = Color.WhiteSmoke;
            lblBoyLabel.Location = new Point(181, 86);
            lblBoyLabel.Name = "lblBoyLabel";
            lblBoyLabel.Size = new Size(43, 20);
            lblBoyLabel.TabIndex = 97;
            lblBoyLabel.Text = "Boy: ";
            // 
            // chboxAraOgun
            // 
            chboxAraOgun.AutoSize = true;
            chboxAraOgun.Checked = true;
            chboxAraOgun.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chboxAraOgun.CheckedState.BorderRadius = 0;
            chboxAraOgun.CheckedState.BorderThickness = 0;
            chboxAraOgun.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chboxAraOgun.CheckState = CheckState.Checked;
            chboxAraOgun.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chboxAraOgun.ForeColor = Color.WhiteSmoke;
            chboxAraOgun.Location = new Point(430, 193);
            chboxAraOgun.Name = "chboxAraOgun";
            chboxAraOgun.Size = new Size(91, 24);
            chboxAraOgun.TabIndex = 96;
            chboxAraOgun.Text = "Ara Öğün";
            chboxAraOgun.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chboxAraOgun.UncheckedState.BorderRadius = 0;
            chboxAraOgun.UncheckedState.BorderThickness = 0;
            chboxAraOgun.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chboxAraOgun.CheckedChanged += chboxAraOgun_CheckedChanged_1;
            // 
            // chboxAksam
            // 
            chboxAksam.AutoSize = true;
            chboxAksam.Checked = true;
            chboxAksam.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chboxAksam.CheckedState.BorderRadius = 0;
            chboxAksam.CheckedState.BorderThickness = 0;
            chboxAksam.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chboxAksam.CheckState = CheckState.Checked;
            chboxAksam.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chboxAksam.ForeColor = Color.WhiteSmoke;
            chboxAksam.Location = new Point(299, 193);
            chboxAksam.Name = "chboxAksam";
            chboxAksam.Size = new Size(125, 24);
            chboxAksam.TabIndex = 95;
            chboxAksam.Text = "Akşam Yemeği";
            chboxAksam.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chboxAksam.UncheckedState.BorderRadius = 0;
            chboxAksam.UncheckedState.BorderThickness = 0;
            chboxAksam.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chboxAksam.CheckedChanged += chboxAksam_CheckedChanged_1;
            // 
            // chboxOgle
            // 
            chboxOgle.AutoSize = true;
            chboxOgle.Checked = true;
            chboxOgle.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chboxOgle.CheckedState.BorderRadius = 0;
            chboxOgle.CheckedState.BorderThickness = 0;
            chboxOgle.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chboxOgle.CheckState = CheckState.Checked;
            chboxOgle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chboxOgle.ForeColor = Color.WhiteSmoke;
            chboxOgle.Location = new Point(180, 193);
            chboxOgle.Name = "chboxOgle";
            chboxOgle.Size = new Size(113, 24);
            chboxOgle.TabIndex = 94;
            chboxOgle.Text = "Öğle Yemeği";
            chboxOgle.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chboxOgle.UncheckedState.BorderRadius = 0;
            chboxOgle.UncheckedState.BorderThickness = 0;
            chboxOgle.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chboxOgle.CheckedChanged += chboxOgle_CheckedChanged_1;
            // 
            // chboxKahvalti
            // 
            chboxKahvalti.AutoSize = true;
            chboxKahvalti.Checked = true;
            chboxKahvalti.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            chboxKahvalti.CheckedState.BorderRadius = 0;
            chboxKahvalti.CheckedState.BorderThickness = 0;
            chboxKahvalti.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            chboxKahvalti.CheckState = CheckState.Checked;
            chboxKahvalti.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            chboxKahvalti.ForeColor = Color.WhiteSmoke;
            chboxKahvalti.Location = new Point(93, 193);
            chboxKahvalti.Name = "chboxKahvalti";
            chboxKahvalti.Size = new Size(81, 24);
            chboxKahvalti.TabIndex = 93;
            chboxKahvalti.Text = "Kahvaltı";
            chboxKahvalti.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            chboxKahvalti.UncheckedState.BorderRadius = 0;
            chboxKahvalti.UncheckedState.BorderThickness = 0;
            chboxKahvalti.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            chboxKahvalti.CheckedChanged += chboxKahvalti_CheckedChanged;
            // 
            // lviewGunluk
            // 
            lviewGunluk.BackColor = Color.CornflowerBlue;
            lviewGunluk.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lviewGunluk.ForeColor = Color.White;
            lviewGunluk.GridLines = true;
            lviewGunluk.Location = new Point(93, 223);
            lviewGunluk.Name = "lviewGunluk";
            lviewGunluk.Size = new Size(428, 219);
            lviewGunluk.TabIndex = 92;
            lviewGunluk.UseCompatibleStateImageBehavior = false;
            lviewGunluk.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yemek";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adet/Porsiyon";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kalori";
            columnHeader3.Width = 98;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Öğün";
            columnHeader4.Width = 75;
            // 
            // btnUpDay
            // 
            btnUpDay.BorderColor = Color.WhiteSmoke;
            btnUpDay.BorderRadius = 7;
            btnUpDay.BorderThickness = 3;
            btnUpDay.CustomizableEdges = customizableEdges1;
            btnUpDay.DisabledState.BorderColor = Color.DarkGray;
            btnUpDay.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpDay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpDay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpDay.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpDay.ForeColor = SystemColors.Window;
            btnUpDay.Location = new Point(533, 252);
            btnUpDay.Name = "btnUpDay";
            btnUpDay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUpDay.Size = new Size(41, 172);
            btnUpDay.TabIndex = 91;
            btnUpDay.Text = ">";
            btnUpDay.Click += btnUpDay_Click_1;
            // 
            // btnDownDay
            // 
            btnDownDay.BorderColor = Color.WhiteSmoke;
            btnDownDay.BorderRadius = 7;
            btnDownDay.BorderThickness = 3;
            btnDownDay.CustomizableEdges = customizableEdges3;
            btnDownDay.DisabledState.BorderColor = Color.DarkGray;
            btnDownDay.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDownDay.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDownDay.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDownDay.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnDownDay.ForeColor = SystemColors.Window;
            btnDownDay.Location = new Point(33, 252);
            btnDownDay.Name = "btnDownDay";
            btnDownDay.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDownDay.Size = new Size(41, 172);
            btnDownDay.TabIndex = 90;
            btnDownDay.Text = "<";
            btnDownDay.Click += btnDownDay_Click_1;
            // 
            // btnToday
            // 
            btnToday.BorderColor = Color.WhiteSmoke;
            btnToday.BorderRadius = 7;
            btnToday.BorderThickness = 3;
            btnToday.CustomizableEdges = customizableEdges5;
            btnToday.DisabledState.BorderColor = Color.DarkGray;
            btnToday.DisabledState.CustomBorderColor = Color.DarkGray;
            btnToday.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnToday.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnToday.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnToday.ForeColor = Color.White;
            btnToday.Location = new Point(220, 462);
            btnToday.Name = "btnToday";
            btnToday.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnToday.Size = new Size(172, 41);
            btnToday.TabIndex = 89;
            btnToday.Text = "Bugün";
            btnToday.Click += btnToday_Click_1;
            // 
            // UserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(586, 574);
            Controls.Add(lblTarget);
            Controls.Add(lblTotal);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblKilo);
            Controls.Add(lblBoy);
            Controls.Add(lblKiloLabel);
            Controls.Add(lblBoyLabel);
            Controls.Add(chboxAraOgun);
            Controls.Add(chboxAksam);
            Controls.Add(chboxOgle);
            Controls.Add(chboxKahvalti);
            Controls.Add(lviewGunluk);
            Controls.Add(btnUpDay);
            Controls.Add(btnDownDay);
            Controls.Add(btnToday);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserPage";
            Text = "UserPage";
            Load += UserPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTarget;
        private Label lblTotal;
        private Label lblAdSoyad;
        private Label lblKilo;
        private Label lblBoy;
        private Label lblKiloLabel;
        private Label lblBoyLabel;
        private Guna.UI2.WinForms.Guna2CheckBox chboxAraOgun;
        private Guna.UI2.WinForms.Guna2CheckBox chboxAksam;
        private Guna.UI2.WinForms.Guna2CheckBox chboxOgle;
        private Guna.UI2.WinForms.Guna2CheckBox chboxKahvalti;
        private ListView lviewGunluk;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button btnUpDay;
        private Guna.UI2.WinForms.Guna2Button btnDownDay;
        private Guna.UI2.WinForms.Guna2Button btnToday;
    }
}