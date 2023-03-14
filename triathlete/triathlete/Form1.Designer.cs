namespace triathlete
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_club = new DataGridView();
            btn_add_edit_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_club).BeginInit();
            SuspendLayout();
            // 
            // dgv_club
            // 
            dgv_club.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_club.Location = new Point(12, 12);
            dgv_club.Name = "dgv_club";
            dgv_club.RowTemplate.Height = 25;
            dgv_club.Size = new Size(776, 426);
            dgv_club.TabIndex = 0;
            // 
            // btn_add_edit_delete
            // 
            btn_add_edit_delete.Location = new Point(12, 444);
            btn_add_edit_delete.Name = "btn_add_edit_delete";
            btn_add_edit_delete.Size = new Size(162, 23);
            btn_add_edit_delete.TabIndex = 12;
            btn_add_edit_delete.Text = "Ajouter/Modifier/Supprimer";
            btn_add_edit_delete.UseVisualStyleBackColor = true;
            btn_add_edit_delete.Click += btn_add_edit_delete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(btn_add_edit_delete);
            Controls.Add(dgv_club);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_club).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_club;
        private Button btn_add_edit_delete;
    }
}