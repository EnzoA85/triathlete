namespace triathlete
{
    partial class menu
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
            btn_club = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // btn_club
            // 
            btn_club.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_club.Location = new Point(12, 171);
            btn_club.Name = "btn_club";
            btn_club.Size = new Size(127, 48);
            btn_club.TabIndex = 0;
            btn_club.Text = "Les Clubs";
            btn_club.UseVisualStyleBackColor = true;
            btn_club.Click += btn_club_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.Location = new Point(303, 171);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(127, 48);
            btn_exit.TabIndex = 1;
            btn_exit.Text = "Quitter";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 231);
            Controls.Add(btn_exit);
            Controls.Add(btn_club);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_club;
        private Button btn_exit;
    }
}