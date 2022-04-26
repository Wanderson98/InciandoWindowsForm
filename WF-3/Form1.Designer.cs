namespace WF_3
{
    partial class frmGerenciador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCriarPasta = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblCriarPasta = new MaterialSkin.Controls.MaterialLabel();
            this.txtDeletarPasta = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblDeletarPasta = new MaterialSkin.Controls.MaterialLabel();
            this.lblArquivoOrigem = new MaterialSkin.Controls.MaterialLabel();
            this.txtArquivoOrigem = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPastaOrigem = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPastaOrigem = new MaterialSkin.Controls.MaterialLabel();
            this.btnCriarPasta = new MaterialSkin.Controls.MaterialButton();
            this.btnDeletarPasta = new MaterialSkin.Controls.MaterialButton();
            this.btnMoverArquivo = new MaterialSkin.Controls.MaterialButton();
            this.txtPastaDestino = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblPastaDestino = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txtCriarPasta
            // 
            this.txtCriarPasta.AnimateReadOnly = false;
            this.txtCriarPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCriarPasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCriarPasta.Depth = 0;
            this.txtCriarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCriarPasta.HideSelection = true;
            this.txtCriarPasta.LeadingIcon = null;
            this.txtCriarPasta.Location = new System.Drawing.Point(17, 111);
            this.txtCriarPasta.MaxLength = 32767;
            this.txtCriarPasta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCriarPasta.Name = "txtCriarPasta";
            this.txtCriarPasta.PasswordChar = '\0';
            this.txtCriarPasta.PrefixSuffixText = null;
            this.txtCriarPasta.ReadOnly = false;
            this.txtCriarPasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCriarPasta.SelectedText = "";
            this.txtCriarPasta.SelectionLength = 0;
            this.txtCriarPasta.SelectionStart = 0;
            this.txtCriarPasta.ShortcutsEnabled = true;
            this.txtCriarPasta.Size = new System.Drawing.Size(432, 48);
            this.txtCriarPasta.TabIndex = 0;
            this.txtCriarPasta.TabStop = false;
            this.txtCriarPasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCriarPasta.TrailingIcon = null;
            this.txtCriarPasta.UseSystemPasswordChar = false;
            // 
            // lblCriarPasta
            // 
            this.lblCriarPasta.AutoSize = true;
            this.lblCriarPasta.Depth = 0;
            this.lblCriarPasta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCriarPasta.Location = new System.Drawing.Point(14, 89);
            this.lblCriarPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCriarPasta.Name = "lblCriarPasta";
            this.lblCriarPasta.Size = new System.Drawing.Size(79, 19);
            this.lblCriarPasta.TabIndex = 1;
            this.lblCriarPasta.Text = "Criar Pasta";
            // 
            // txtDeletarPasta
            // 
            this.txtDeletarPasta.AnimateReadOnly = false;
            this.txtDeletarPasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDeletarPasta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDeletarPasta.Depth = 0;
            this.txtDeletarPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDeletarPasta.HideSelection = true;
            this.txtDeletarPasta.LeadingIcon = null;
            this.txtDeletarPasta.Location = new System.Drawing.Point(17, 188);
            this.txtDeletarPasta.MaxLength = 32767;
            this.txtDeletarPasta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDeletarPasta.Name = "txtDeletarPasta";
            this.txtDeletarPasta.PasswordChar = '\0';
            this.txtDeletarPasta.PrefixSuffixText = null;
            this.txtDeletarPasta.ReadOnly = false;
            this.txtDeletarPasta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDeletarPasta.SelectedText = "";
            this.txtDeletarPasta.SelectionLength = 0;
            this.txtDeletarPasta.SelectionStart = 0;
            this.txtDeletarPasta.ShortcutsEnabled = true;
            this.txtDeletarPasta.Size = new System.Drawing.Size(432, 48);
            this.txtDeletarPasta.TabIndex = 0;
            this.txtDeletarPasta.TabStop = false;
            this.txtDeletarPasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDeletarPasta.TrailingIcon = null;
            this.txtDeletarPasta.UseSystemPasswordChar = false;
            // 
            // lblDeletarPasta
            // 
            this.lblDeletarPasta.AutoSize = true;
            this.lblDeletarPasta.Depth = 0;
            this.lblDeletarPasta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeletarPasta.Location = new System.Drawing.Point(14, 166);
            this.lblDeletarPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeletarPasta.Name = "lblDeletarPasta";
            this.lblDeletarPasta.Size = new System.Drawing.Size(96, 19);
            this.lblDeletarPasta.TabIndex = 1;
            this.lblDeletarPasta.Text = "Deletar Pasta";
            // 
            // lblArquivoOrigem
            // 
            this.lblArquivoOrigem.AutoSize = true;
            this.lblArquivoOrigem.Depth = 0;
            this.lblArquivoOrigem.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblArquivoOrigem.Location = new System.Drawing.Point(14, 244);
            this.lblArquivoOrigem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblArquivoOrigem.Name = "lblArquivoOrigem";
            this.lblArquivoOrigem.Size = new System.Drawing.Size(59, 19);
            this.lblArquivoOrigem.TabIndex = 3;
            this.lblArquivoOrigem.Text = "Arquivo ";
            // 
            // txtArquivoOrigem
            // 
            this.txtArquivoOrigem.AnimateReadOnly = false;
            this.txtArquivoOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtArquivoOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtArquivoOrigem.Depth = 0;
            this.txtArquivoOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtArquivoOrigem.HideSelection = true;
            this.txtArquivoOrigem.LeadingIcon = null;
            this.txtArquivoOrigem.Location = new System.Drawing.Point(17, 266);
            this.txtArquivoOrigem.MaxLength = 32767;
            this.txtArquivoOrigem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtArquivoOrigem.Name = "txtArquivoOrigem";
            this.txtArquivoOrigem.PasswordChar = '\0';
            this.txtArquivoOrigem.PrefixSuffixText = null;
            this.txtArquivoOrigem.ReadOnly = false;
            this.txtArquivoOrigem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArquivoOrigem.SelectedText = "";
            this.txtArquivoOrigem.SelectionLength = 0;
            this.txtArquivoOrigem.SelectionStart = 0;
            this.txtArquivoOrigem.ShortcutsEnabled = true;
            this.txtArquivoOrigem.Size = new System.Drawing.Size(432, 48);
            this.txtArquivoOrigem.TabIndex = 2;
            this.txtArquivoOrigem.TabStop = false;
            this.txtArquivoOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtArquivoOrigem.TrailingIcon = null;
            this.txtArquivoOrigem.UseSystemPasswordChar = false;
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.AnimateReadOnly = false;
            this.txtPastaOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPastaOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPastaOrigem.Depth = 0;
            this.txtPastaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPastaOrigem.HideSelection = true;
            this.txtPastaOrigem.LeadingIcon = null;
            this.txtPastaOrigem.Location = new System.Drawing.Point(17, 345);
            this.txtPastaOrigem.MaxLength = 32767;
            this.txtPastaOrigem.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.PasswordChar = '\0';
            this.txtPastaOrigem.PrefixSuffixText = null;
            this.txtPastaOrigem.ReadOnly = false;
            this.txtPastaOrigem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPastaOrigem.SelectedText = "";
            this.txtPastaOrigem.SelectionLength = 0;
            this.txtPastaOrigem.SelectionStart = 0;
            this.txtPastaOrigem.ShortcutsEnabled = true;
            this.txtPastaOrigem.Size = new System.Drawing.Size(432, 48);
            this.txtPastaOrigem.TabIndex = 2;
            this.txtPastaOrigem.TabStop = false;
            this.txtPastaOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPastaOrigem.TrailingIcon = null;
            this.txtPastaOrigem.UseSystemPasswordChar = false;
            // 
            // lblPastaOrigem
            // 
            this.lblPastaOrigem.AutoSize = true;
            this.lblPastaOrigem.Depth = 0;
            this.lblPastaOrigem.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPastaOrigem.Location = new System.Drawing.Point(14, 323);
            this.lblPastaOrigem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPastaOrigem.Name = "lblPastaOrigem";
            this.lblPastaOrigem.Size = new System.Drawing.Size(118, 19);
            this.lblPastaOrigem.TabIndex = 3;
            this.lblPastaOrigem.Text = "Pasta de Origem";
            // 
            // btnCriarPasta
            // 
            this.btnCriarPasta.AutoSize = false;
            this.btnCriarPasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCriarPasta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCriarPasta.Depth = 0;
            this.btnCriarPasta.HighEmphasis = true;
            this.btnCriarPasta.Icon = null;
            this.btnCriarPasta.Location = new System.Drawing.Point(500, 111);
            this.btnCriarPasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCriarPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCriarPasta.Name = "btnCriarPasta";
            this.btnCriarPasta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCriarPasta.Size = new System.Drawing.Size(116, 48);
            this.btnCriarPasta.TabIndex = 4;
            this.btnCriarPasta.Text = "Criar Pasta";
            this.btnCriarPasta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCriarPasta.UseAccentColor = false;
            this.btnCriarPasta.UseVisualStyleBackColor = true;
            this.btnCriarPasta.Click += new System.EventHandler(this.btnCriarPasta_Click);
            // 
            // btnDeletarPasta
            // 
            this.btnDeletarPasta.AutoSize = false;
            this.btnDeletarPasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletarPasta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeletarPasta.Depth = 0;
            this.btnDeletarPasta.HighEmphasis = true;
            this.btnDeletarPasta.Icon = null;
            this.btnDeletarPasta.Location = new System.Drawing.Point(500, 188);
            this.btnDeletarPasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletarPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletarPasta.Name = "btnDeletarPasta";
            this.btnDeletarPasta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDeletarPasta.Size = new System.Drawing.Size(116, 48);
            this.btnDeletarPasta.TabIndex = 4;
            this.btnDeletarPasta.Text = "Deletar";
            this.btnDeletarPasta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeletarPasta.UseAccentColor = false;
            this.btnDeletarPasta.UseVisualStyleBackColor = true;
            this.btnDeletarPasta.Click += new System.EventHandler(this.btnDeletarPasta_Click);
            // 
            // btnMoverArquivo
            // 
            this.btnMoverArquivo.AutoSize = false;
            this.btnMoverArquivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMoverArquivo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMoverArquivo.Depth = 0;
            this.btnMoverArquivo.HighEmphasis = true;
            this.btnMoverArquivo.Icon = null;
            this.btnMoverArquivo.Location = new System.Drawing.Point(500, 345);
            this.btnMoverArquivo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMoverArquivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMoverArquivo.Name = "btnMoverArquivo";
            this.btnMoverArquivo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMoverArquivo.Size = new System.Drawing.Size(116, 51);
            this.btnMoverArquivo.TabIndex = 4;
            this.btnMoverArquivo.Text = "Mover ";
            this.btnMoverArquivo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMoverArquivo.UseAccentColor = false;
            this.btnMoverArquivo.UseVisualStyleBackColor = true;
            this.btnMoverArquivo.Click += new System.EventHandler(this.btnMoverArquivo_Click);
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.AnimateReadOnly = false;
            this.txtPastaDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPastaDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPastaDestino.Depth = 0;
            this.txtPastaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPastaDestino.HideSelection = true;
            this.txtPastaDestino.LeadingIcon = null;
            this.txtPastaDestino.Location = new System.Drawing.Point(17, 430);
            this.txtPastaDestino.MaxLength = 32767;
            this.txtPastaDestino.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.PasswordChar = '\0';
            this.txtPastaDestino.PrefixSuffixText = null;
            this.txtPastaDestino.ReadOnly = false;
            this.txtPastaDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPastaDestino.SelectedText = "";
            this.txtPastaDestino.SelectionLength = 0;
            this.txtPastaDestino.SelectionStart = 0;
            this.txtPastaDestino.ShortcutsEnabled = true;
            this.txtPastaDestino.Size = new System.Drawing.Size(432, 48);
            this.txtPastaDestino.TabIndex = 2;
            this.txtPastaDestino.TabStop = false;
            this.txtPastaDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPastaDestino.TrailingIcon = null;
            this.txtPastaDestino.UseSystemPasswordChar = false;
            // 
            // lblPastaDestino
            // 
            this.lblPastaDestino.AutoSize = true;
            this.lblPastaDestino.Depth = 0;
            this.lblPastaDestino.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPastaDestino.Location = new System.Drawing.Point(14, 408);
            this.lblPastaDestino.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPastaDestino.Name = "lblPastaDestino";
            this.lblPastaDestino.Size = new System.Drawing.Size(121, 19);
            this.lblPastaDestino.TabIndex = 3;
            this.lblPastaDestino.Text = "Pasta de Destino";
            // 
            // frmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 528);
            this.Controls.Add(this.btnMoverArquivo);
            this.Controls.Add(this.btnDeletarPasta);
            this.Controls.Add(this.btnCriarPasta);
            this.Controls.Add(this.lblPastaDestino);
            this.Controls.Add(this.lblPastaOrigem);
            this.Controls.Add(this.lblArquivoOrigem);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.txtArquivoOrigem);
            this.Controls.Add(this.lblDeletarPasta);
            this.Controls.Add(this.lblCriarPasta);
            this.Controls.Add(this.txtDeletarPasta);
            this.Controls.Add(this.txtCriarPasta);
            this.MaximizeBox = false;
            this.Name = "frmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtCriarPasta;
        private MaterialSkin.Controls.MaterialLabel lblCriarPasta;
        private MaterialSkin.Controls.MaterialTextBox2 txtDeletarPasta;
        private MaterialSkin.Controls.MaterialLabel lblDeletarPasta;
        private MaterialSkin.Controls.MaterialLabel lblArquivoOrigem;
        private MaterialSkin.Controls.MaterialTextBox2 txtArquivoOrigem;
        private MaterialSkin.Controls.MaterialTextBox2 txtPastaOrigem;
        private MaterialSkin.Controls.MaterialLabel lblPastaOrigem;
        private MaterialSkin.Controls.MaterialButton btnCriarPasta;
        private MaterialSkin.Controls.MaterialButton btnDeletarPasta;
        private MaterialSkin.Controls.MaterialButton btnMoverArquivo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPastaDestino;
        private MaterialSkin.Controls.MaterialLabel lblPastaDestino;
    }
}

