
﻿namespace Geradorador_de_Senha
{
    partial class frmgeradorSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgeradorSenha));
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSenha = new System.Windows.Forms.ComboBox();
            this.chkPasswordChar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHistoricodeSenha = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btngerarSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightGray;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(154, 496);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 200);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.AllowDrop = true;
            this.txtSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtSenha.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(37, 208);
            this.txtSenha.MaxLength = 22;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(313, 31);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(92, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Histórico de Senhas Geradas";
            // 
            // cboSenha
            // 
            this.cboSenha.AllowDrop = true;
            this.cboSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboSenha.DisplayMember = "None";
            this.cboSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSenha.FormattingEnabled = true;
            this.cboSenha.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cboSenha.IntegralHeight = false;
            this.cboSenha.ItemHeight = 20;
            this.cboSenha.Location = new System.Drawing.Point(80, 274);
            this.cboSenha.MaxLength = 22;
            this.cboSenha.Name = "cboSenha";
            this.cboSenha.Size = new System.Drawing.Size(243, 28);
            this.cboSenha.TabIndex = 10;
            // 
            // chkPasswordChar
            // 
            this.chkPasswordChar.AutoSize = true;
            this.chkPasswordChar.BackColor = System.Drawing.Color.Black;
            this.chkPasswordChar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkPasswordChar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkPasswordChar.ForeColor = System.Drawing.Color.LightGreen;
            this.chkPasswordChar.Location = new System.Drawing.Point(232, 349);
            this.chkPasswordChar.Name = "chkPasswordChar";
            this.chkPasswordChar.Size = new System.Drawing.Size(91, 23);
            this.chkPasswordChar.TabIndex = 21;
            this.chkPasswordChar.Text = "Habilitar";
            this.chkPasswordChar.UseVisualStyleBackColor = false;
            this.chkPasswordChar.CheckedChanged += new System.EventHandler(this.chkPasswordChar_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(203, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Esconder Senha";
            // 
            // chkHistoricodeSenha
            // 
            this.chkHistoricodeSenha.AutoSize = true;
            this.chkHistoricodeSenha.BackColor = System.Drawing.Color.Black;
            this.chkHistoricodeSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHistoricodeSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.chkHistoricodeSenha.ForeColor = System.Drawing.Color.LightGreen;
            this.chkHistoricodeSenha.Location = new System.Drawing.Point(52, 349);
            this.chkHistoricodeSenha.Name = "chkHistoricodeSenha";
            this.chkHistoricodeSenha.Size = new System.Drawing.Size(109, 23);
            this.chkHistoricodeSenha.TabIndex = 20;
            this.chkHistoricodeSenha.Text = "Desabilitar";
            this.chkHistoricodeSenha.UseVisualStyleBackColor = false;
            this.chkHistoricodeSenha.CheckedChanged += new System.EventHandler(this.chkHistoricodeSenha_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(43, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Histórico de Senha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(37, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 63);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackColor = System.Drawing.Color.Black;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.LightGreen;
            this.btnCopiar.Location = new System.Drawing.Point(184, 377);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(158, 46);
            this.btnCopiar.TabIndex = 18;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = false;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Black;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpar.ForeColor = System.Drawing.Color.LightGreen;
            this.btnLimpar.Location = new System.Drawing.Point(37, 377);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(160, 46);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btngerarSenha
            // 
            this.btngerarSenha.BackColor = System.Drawing.Color.Black;
            this.btngerarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngerarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngerarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngerarSenha.ForeColor = System.Drawing.Color.LightGreen;
            this.btngerarSenha.Location = new System.Drawing.Point(37, 420);
            this.btngerarSenha.Name = "btngerarSenha";
            this.btngerarSenha.Size = new System.Drawing.Size(305, 60);
            this.btngerarSenha.TabIndex = 16;
            this.btngerarSenha.Text = "Gerar Senha";
            this.btngerarSenha.UseVisualStyleBackColor = false;
            this.btngerarSenha.Click += new System.EventHandler(this.btngerarSenha_Click_1);
            // 
            // frmgeradorSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 521);
            this.Controls.Add(this.chkPasswordChar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkHistoricodeSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btngerarSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSenha);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmgeradorSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmgeradorSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSenha;
        private System.Windows.Forms.CheckBox chkPasswordChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHistoricodeSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btngerarSenha;
    }
}



    
