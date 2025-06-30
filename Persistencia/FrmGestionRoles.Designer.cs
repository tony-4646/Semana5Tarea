namespace Semana5Tarea.Persistencia
{
    partial class FrmGestionRoles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarEditado = new System.Windows.Forms.Button();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnInsertarRol = new System.Windows.Forms.Button();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.lstRoles = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGuardarEditado);
            this.panel1.Controls.Add(this.btnEditarRol);
            this.panel1.Controls.Add(this.btnEliminarRol);
            this.panel1.Controls.Add(this.btnInsertarRol);
            this.panel1.Controls.Add(this.txtNombreRol);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.lstRoles);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 361);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnLimpiar.Location = new System.Drawing.Point(37, 272);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(61, 27);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(242, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gestor de Roles";
            // 
            // btnGuardarEditado
            // 
            this.btnGuardarEditado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGuardarEditado.Enabled = false;
            this.btnGuardarEditado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnGuardarEditado.Location = new System.Drawing.Point(224, 214);
            this.btnGuardarEditado.Name = "btnGuardarEditado";
            this.btnGuardarEditado.Size = new System.Drawing.Size(119, 40);
            this.btnGuardarEditado.TabIndex = 7;
            this.btnGuardarEditado.Text = "Guardar";
            this.btnGuardarEditado.UseVisualStyleBackColor = false;
            this.btnGuardarEditado.Click += new System.EventHandler(this.btnGuardarEditado_Click);
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEditarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnEditarRol.Location = new System.Drawing.Point(224, 168);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(119, 40);
            this.btnEditarRol.TabIndex = 6;
            this.btnEditarRol.Text = "Editar";
            this.btnEditarRol.UseVisualStyleBackColor = false;
            this.btnEditarRol.Click += new System.EventHandler(this.btnEditarRol_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEliminarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnEliminarRol.Location = new System.Drawing.Point(37, 214);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(119, 40);
            this.btnEliminarRol.TabIndex = 5;
            this.btnEliminarRol.Text = "Borrar";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnInsertarRol
            // 
            this.btnInsertarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnInsertarRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnInsertarRol.Location = new System.Drawing.Point(37, 168);
            this.btnInsertarRol.Name = "btnInsertarRol";
            this.btnInsertarRol.Size = new System.Drawing.Size(119, 40);
            this.btnInsertarRol.TabIndex = 4;
            this.btnInsertarRol.Text = "Insertar";
            this.btnInsertarRol.UseVisualStyleBackColor = false;
            this.btnInsertarRol.Click += new System.EventHandler(this.btnInsertarRol_Click);
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(37, 115);
            this.txtNombreRol.MaxLength = 15;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(306, 32);
            this.txtNombreRol.TabIndex = 3;
            this.txtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRol_KeyPress);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Nombre del rol";
            // 
            // lstRoles
            // 
            this.lstRoles.FormattingEnabled = true;
            this.lstRoles.ItemHeight = 25;
            this.lstRoles.Location = new System.Drawing.Point(410, 69);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.ScrollAlwaysVisible = true;
            this.lstRoles.Size = new System.Drawing.Size(247, 254);
            this.lstRoles.TabIndex = 1;
            this.lstRoles.SelectedIndexChanged += new System.EventHandler(this.lstRoles_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.btnVolver.Location = new System.Drawing.Point(622, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(61, 27);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmGestionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(695, 361);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmGestionRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionRoles";
            this.Load += new System.EventHandler(this.FrmGestionRoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListBox lstRoles;
        private System.Windows.Forms.Button btnGuardarEditado;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnInsertarRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}