
namespace MVC01.View
{
    partial class Exec2
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
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.NumeroVagaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntradaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbVagasLivres = new System.Windows.Forms.ComboBox();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.lblVagasLivres = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblLavou = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.lblHoraSaida = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroVagaCol,
            this.PlacaCol,
            this.HoraEntradaCol});
            this.dgVagas.Location = new System.Drawing.Point(12, 12);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.Size = new System.Drawing.Size(446, 150);
            this.dgVagas.TabIndex = 0;
            // 
            // NumeroVagaCol
            // 
            this.NumeroVagaCol.HeaderText = "Vaga";
            this.NumeroVagaCol.Name = "NumeroVagaCol";
            this.NumeroVagaCol.ReadOnly = true;
            // 
            // PlacaCol
            // 
            this.PlacaCol.HeaderText = "Placa";
            this.PlacaCol.Name = "PlacaCol";
            this.PlacaCol.ReadOnly = true;
            // 
            // HoraEntradaCol
            // 
            this.HoraEntradaCol.HeaderText = "HoraEntrada";
            this.HoraEntradaCol.Name = "HoraEntradaCol";
            this.HoraEntradaCol.ReadOnly = true;
            // 
            // cbVagasLivres
            // 
            this.cbVagasLivres.FormattingEnabled = true;
            this.cbVagasLivres.Location = new System.Drawing.Point(35, 197);
            this.cbVagasLivres.Name = "cbVagasLivres";
            this.cbVagasLivres.Size = new System.Drawing.Size(121, 21);
            this.cbVagasLivres.TabIndex = 1;
            // 
            // cbPlacas
            // 
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(225, 197);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(121, 21);
            this.cbPlacas.TabIndex = 2;
            // 
            // lblVagasLivres
            // 
            this.lblVagasLivres.AutoSize = true;
            this.lblVagasLivres.Location = new System.Drawing.Point(32, 165);
            this.lblVagasLivres.Name = "lblVagasLivres";
            this.lblVagasLivres.Size = new System.Drawing.Size(68, 13);
            this.lblVagasLivres.TabIndex = 3;
            this.lblVagasLivres.Text = "Vagas Livres";
            // 
            // lblPlacas
            // 
            this.lblPlacas.AutoSize = true;
            this.lblPlacas.Location = new System.Drawing.Point(222, 165);
            this.lblPlacas.Name = "lblPlacas";
            this.lblPlacas.Size = new System.Drawing.Size(39, 13);
            this.lblPlacas.TabIndex = 4;
            this.lblPlacas.Text = "Placas";
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(33, 243);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(67, 13);
            this.lblHoraEntrada.TabIndex = 5;
            this.lblHoraEntrada.Text = "HoraEntrada";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(35, 352);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblLavou
            // 
            this.lblLavou.AutoSize = true;
            this.lblLavou.Location = new System.Drawing.Point(225, 261);
            this.lblLavou.Name = "lblLavou";
            this.lblLavou.Size = new System.Drawing.Size(43, 13);
            this.lblLavou.TabIndex = 8;
            this.lblLavou.Text = "Lavou?";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(225, 278);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 9;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(225, 301);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Nao";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // lblHoraSaida
            // 
            this.lblHoraSaida.AutoSize = true;
            this.lblHoraSaida.Location = new System.Drawing.Point(222, 336);
            this.lblHoraSaida.Name = "lblHoraSaida";
            this.lblHoraSaida.Size = new System.Drawing.Size(57, 13);
            this.lblHoraSaida.TabIndex = 11;
            this.lblHoraSaida.Text = "HoraSaida";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(35, 261);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtHoraEntrada.TabIndex = 12;
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(225, 352);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(100, 20);
            this.txtHoraSaida.TabIndex = 13;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(185, 405);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(326, 392);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(75, 36);
            this.btnEncerrar.TabIndex = 15;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(35, 322);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 20);
            this.txtPlaca.TabIndex = 16;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(32, 303);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 17;
            this.lblPlaca.Text = "Placa";
            // 
            // Exec2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 450);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.lblHoraSaida);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.lblLavou);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.lblVagasLivres);
            this.Controls.Add(this.cbPlacas);
            this.Controls.Add(this.cbVagasLivres);
            this.Controls.Add(this.dgVagas);
            this.Name = "Exec2";
            this.Text = "Exec2";
            this.Load += new System.EventHandler(this.Exec2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVagaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntradaCol;
        private System.Windows.Forms.ComboBox cbVagasLivres;
        private System.Windows.Forms.ComboBox cbPlacas;
        private System.Windows.Forms.Label lblVagasLivres;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblLavou;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label lblHoraSaida;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.TextBox txtHoraSaida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblPlaca;
    }
}