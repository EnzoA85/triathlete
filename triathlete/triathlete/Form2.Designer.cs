namespace triathlete
{
    partial class Form2
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
            btn_creer = new Button();
            lbl_choisir_club = new Label();
            lbl_nom = new Label();
            lbl_adresse = new Label();
            lbl_téléphone = new Label();
            btn_modifier = new Button();
            btn_supprimer = new Button();
            cb_choisir_club = new ComboBox();
            tbx_nom = new TextBox();
            tbx_adresse = new TextBox();
            tbx_telephone = new TextBox();
            gbx_gestion_club = new GroupBox();
            button1 = new Button();
            gbx_gestion_club.SuspendLayout();
            SuspendLayout();
            // 
            // btn_creer
            // 
            btn_creer.Location = new Point(6, 172);
            btn_creer.Name = "btn_creer";
            btn_creer.Size = new Size(75, 23);
            btn_creer.TabIndex = 0;
            btn_creer.Text = "Créer";
            btn_creer.UseVisualStyleBackColor = true;
            // 
            // lbl_choisir_club
            // 
            lbl_choisir_club.AutoSize = true;
            lbl_choisir_club.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_choisir_club.Location = new Point(6, 20);
            lbl_choisir_club.Name = "lbl_choisir_club";
            lbl_choisir_club.Size = new Size(114, 21);
            lbl_choisir_club.TabIndex = 1;
            lbl_choisir_club.Text = "Choisir un club";
            // 
            // lbl_nom
            // 
            lbl_nom.AutoSize = true;
            lbl_nom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nom.Location = new Point(6, 56);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(45, 21);
            lbl_nom.TabIndex = 2;
            lbl_nom.Text = "Nom";
            // 
            // lbl_adresse
            // 
            lbl_adresse.AutoSize = true;
            lbl_adresse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_adresse.Location = new Point(6, 92);
            lbl_adresse.Name = "lbl_adresse";
            lbl_adresse.Size = new Size(65, 21);
            lbl_adresse.TabIndex = 3;
            lbl_adresse.Text = "Adresse";
            // 
            // lbl_téléphone
            // 
            lbl_téléphone.AutoSize = true;
            lbl_téléphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_téléphone.Location = new Point(6, 128);
            lbl_téléphone.Name = "lbl_téléphone";
            lbl_téléphone.Size = new Size(80, 21);
            lbl_téléphone.TabIndex = 4;
            lbl_téléphone.Text = "Téléphone";
            // 
            // btn_modifier
            // 
            btn_modifier.Location = new Point(128, 172);
            btn_modifier.Name = "btn_modifier";
            btn_modifier.RightToLeft = RightToLeft.No;
            btn_modifier.Size = new Size(75, 23);
            btn_modifier.TabIndex = 5;
            btn_modifier.Text = "Modifier";
            btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            btn_supprimer.Location = new Point(253, 172);
            btn_supprimer.Name = "btn_supprimer";
            btn_supprimer.Size = new Size(75, 23);
            btn_supprimer.TabIndex = 6;
            btn_supprimer.Text = "Supprimer";
            btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // cb_choisir_club
            // 
            cb_choisir_club.FormattingEnabled = true;
            cb_choisir_club.Location = new Point(146, 22);
            cb_choisir_club.Name = "cb_choisir_club";
            cb_choisir_club.Size = new Size(182, 23);
            cb_choisir_club.TabIndex = 7;
            cb_choisir_club.SelectedIndexChanged += cb_choisir_club_SelectedIndexChanged;
            // 
            // tbx_nom
            // 
            tbx_nom.Location = new Point(146, 58);
            tbx_nom.Name = "tbx_nom";
            tbx_nom.Size = new Size(182, 23);
            tbx_nom.TabIndex = 8;
            // 
            // tbx_adresse
            // 
            tbx_adresse.Location = new Point(146, 94);
            tbx_adresse.Name = "tbx_adresse";
            tbx_adresse.Size = new Size(182, 23);
            tbx_adresse.TabIndex = 9;
            // 
            // tbx_telephone
            // 
            tbx_telephone.Location = new Point(146, 126);
            tbx_telephone.Name = "tbx_telephone";
            tbx_telephone.Size = new Size(182, 23);
            tbx_telephone.TabIndex = 10;
            // 
            // gbx_gestion_club
            // 
            gbx_gestion_club.Controls.Add(lbl_choisir_club);
            gbx_gestion_club.Controls.Add(tbx_telephone);
            gbx_gestion_club.Controls.Add(btn_creer);
            gbx_gestion_club.Controls.Add(tbx_adresse);
            gbx_gestion_club.Controls.Add(lbl_nom);
            gbx_gestion_club.Controls.Add(tbx_nom);
            gbx_gestion_club.Controls.Add(lbl_adresse);
            gbx_gestion_club.Controls.Add(cb_choisir_club);
            gbx_gestion_club.Controls.Add(lbl_téléphone);
            gbx_gestion_club.Controls.Add(btn_supprimer);
            gbx_gestion_club.Controls.Add(btn_modifier);
            gbx_gestion_club.Location = new Point(12, 12);
            gbx_gestion_club.Name = "gbx_gestion_club";
            gbx_gestion_club.Size = new Size(334, 203);
            gbx_gestion_club.TabIndex = 11;
            gbx_gestion_club.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 221);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Les Club";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 253);
            Controls.Add(button1);
            Controls.Add(gbx_gestion_club);
            Name = "Form2";
            Text = "Gestion des clubs";
            Load += Form2_Load;
            gbx_gestion_club.ResumeLayout(false);
            gbx_gestion_club.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_creer;
        private Label lbl_choisir_club;
        private Label lbl_nom;
        private Label lbl_adresse;
        private Label lbl_téléphone;
        private Button btn_modifier;
        private Button btn_supprimer;
        private ComboBox cb_choisir_club;
        private TextBox tbx_nom;
        private TextBox tbx_adresse;
        private TextBox tbx_telephone;
        private GroupBox gbx_gestion_club;
        private Button button1;
    }
}