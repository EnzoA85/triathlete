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
            lbl_ville = new Label();
            lbl_téléphone = new Label();
            btn_modifier = new Button();
            btn_supprimer = new Button();
            cb_choisir_club = new ComboBox();
            tbx_nom = new TextBox();
            tbx_ville = new TextBox();
            tbx_telephone = new TextBox();
            gbx_gestion_club = new GroupBox();
            tbx_rue = new TextBox();
            tbx_cp = new TextBox();
            lbl_cp = new Label();
            lbl_rue = new Label();
            button1 = new Button();
            gbx_gestion_club.SuspendLayout();
            SuspendLayout();
            // 
            // btn_creer
            // 
            btn_creer.Location = new Point(6, 265);
            btn_creer.Name = "btn_creer";
            btn_creer.Size = new Size(75, 23);
            btn_creer.TabIndex = 0;
            btn_creer.Text = "Créer";
            btn_creer.UseVisualStyleBackColor = true;
            btn_creer.Click += btn_creer_Click;
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
            lbl_nom.Location = new Point(6, 77);
            lbl_nom.Name = "lbl_nom";
            lbl_nom.Size = new Size(45, 21);
            lbl_nom.TabIndex = 2;
            lbl_nom.Text = "Nom";
            // 
            // lbl_ville
            // 
            lbl_ville.AutoSize = true;
            lbl_ville.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ville.Location = new Point(6, 113);
            lbl_ville.Name = "lbl_ville";
            lbl_ville.Size = new Size(40, 21);
            lbl_ville.TabIndex = 3;
            lbl_ville.Text = "Ville";
            // 
            // lbl_téléphone
            // 
            lbl_téléphone.AutoSize = true;
            lbl_téléphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_téléphone.Location = new Point(6, 223);
            lbl_téléphone.Name = "lbl_téléphone";
            lbl_téléphone.Size = new Size(80, 21);
            lbl_téléphone.TabIndex = 4;
            lbl_téléphone.Text = "Téléphone";
            // 
            // btn_modifier
            // 
            btn_modifier.Location = new Point(128, 265);
            btn_modifier.Name = "btn_modifier";
            btn_modifier.RightToLeft = RightToLeft.No;
            btn_modifier.Size = new Size(75, 23);
            btn_modifier.TabIndex = 5;
            btn_modifier.Text = "Modifier";
            btn_modifier.UseVisualStyleBackColor = true;
            btn_modifier.Click += btn_modifier_Click;
            // 
            // btn_supprimer
            // 
            btn_supprimer.Location = new Point(253, 265);
            btn_supprimer.Name = "btn_supprimer";
            btn_supprimer.Size = new Size(75, 23);
            btn_supprimer.TabIndex = 6;
            btn_supprimer.Text = "Supprimer";
            btn_supprimer.UseVisualStyleBackColor = true;
            btn_supprimer.Click += btn_supprimer_Click;
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
            tbx_nom.Location = new Point(146, 79);
            tbx_nom.Name = "tbx_nom";
            tbx_nom.Size = new Size(182, 23);
            tbx_nom.TabIndex = 8;
            // 
            // tbx_ville
            // 
            tbx_ville.Location = new Point(146, 115);
            tbx_ville.Name = "tbx_ville";
            tbx_ville.Size = new Size(182, 23);
            tbx_ville.TabIndex = 9;
            // 
            // tbx_telephone
            // 
            tbx_telephone.Location = new Point(146, 225);
            tbx_telephone.Name = "tbx_telephone";
            tbx_telephone.Size = new Size(182, 23);
            tbx_telephone.TabIndex = 10;
            // 
            // gbx_gestion_club
            // 
            gbx_gestion_club.Controls.Add(tbx_rue);
            gbx_gestion_club.Controls.Add(tbx_cp);
            gbx_gestion_club.Controls.Add(lbl_cp);
            gbx_gestion_club.Controls.Add(lbl_rue);
            gbx_gestion_club.Controls.Add(lbl_choisir_club);
            gbx_gestion_club.Controls.Add(tbx_telephone);
            gbx_gestion_club.Controls.Add(btn_creer);
            gbx_gestion_club.Controls.Add(tbx_ville);
            gbx_gestion_club.Controls.Add(lbl_nom);
            gbx_gestion_club.Controls.Add(tbx_nom);
            gbx_gestion_club.Controls.Add(lbl_ville);
            gbx_gestion_club.Controls.Add(cb_choisir_club);
            gbx_gestion_club.Controls.Add(lbl_téléphone);
            gbx_gestion_club.Controls.Add(btn_supprimer);
            gbx_gestion_club.Controls.Add(btn_modifier);
            gbx_gestion_club.Location = new Point(12, 12);
            gbx_gestion_club.Name = "gbx_gestion_club";
            gbx_gestion_club.Size = new Size(334, 299);
            gbx_gestion_club.TabIndex = 11;
            gbx_gestion_club.TabStop = false;
            // 
            // tbx_rue
            // 
            tbx_rue.Location = new Point(146, 150);
            tbx_rue.Name = "tbx_rue";
            tbx_rue.Size = new Size(182, 23);
            tbx_rue.TabIndex = 14;
            // 
            // tbx_cp
            // 
            tbx_cp.Location = new Point(146, 187);
            tbx_cp.Name = "tbx_cp";
            tbx_cp.Size = new Size(182, 23);
            tbx_cp.TabIndex = 13;
            // 
            // lbl_cp
            // 
            lbl_cp.AutoSize = true;
            lbl_cp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cp.Location = new Point(6, 185);
            lbl_cp.Name = "lbl_cp";
            lbl_cp.Size = new Size(91, 21);
            lbl_cp.TabIndex = 12;
            lbl_cp.Text = "Code Postal";
            // 
            // lbl_rue
            // 
            lbl_rue.AutoSize = true;
            lbl_rue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_rue.Location = new Point(6, 148);
            lbl_rue.Name = "lbl_rue";
            lbl_rue.Size = new Size(37, 21);
            lbl_rue.TabIndex = 11;
            lbl_rue.Text = "Rue";
            // 
            // button1
            // 
            button1.Location = new Point(12, 317);
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
            ClientSize = new Size(364, 346);
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
        private Label lbl_ville;
        private Label lbl_téléphone;
        private Button btn_modifier;
        private Button btn_supprimer;
        private ComboBox cb_choisir_club;
        private TextBox tbx_nom;
        private TextBox tbx_ville;
        private TextBox tbx_telephone;
        private GroupBox gbx_gestion_club;
        private Button button1;
        private TextBox tbx_rue;
        private TextBox tbx_cp;
        private Label lbl_cp;
        private Label lbl_rue;
    }
}