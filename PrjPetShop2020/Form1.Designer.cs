
namespace PrjPetShop2020
{
    partial class Form1
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAnimal = new System.Windows.Forms.Button();
            this.buttonRaca = new System.Windows.Forms.Button();
            this.buttonServico = new System.Windows.Forms.Button();
            this.buttonAgendamento = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Indigo;
            this.panelLateral.Controls.Add(this.label2);
            this.panelLateral.Controls.Add(this.label1);
            this.panelLateral.Controls.Add(this.panelSelecao);
            this.panelLateral.Controls.Add(this.buttonInicio);
            this.panelLateral.Controls.Add(this.buttonAgendamento);
            this.panelLateral.Controls.Add(this.buttonServico);
            this.panelLateral.Controls.Add(this.buttonRaca);
            this.panelLateral.Controls.Add(this.buttonAnimal);
            this.panelLateral.Controls.Add(this.buttonCliente);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(229, 796);
            this.panelLateral.TabIndex = 0;
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelTopo.Controls.Add(this.buttonMin);
            this.panelTopo.Controls.Add(this.buttonSair);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(229, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(838, 53);
            this.panelTopo.TabIndex = 1;
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCliente.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCliente.Location = new System.Drawing.Point(34, 265);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(156, 60);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "CLIENTES";
            this.buttonCliente.UseVisualStyleBackColor = false;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonAnimal
            // 
            this.buttonAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnimal.FlatAppearance.BorderSize = 0;
            this.buttonAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnimal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimal.ForeColor = System.Drawing.Color.White;
            this.buttonAnimal.Location = new System.Drawing.Point(34, 341);
            this.buttonAnimal.Name = "buttonAnimal";
            this.buttonAnimal.Size = new System.Drawing.Size(156, 60);
            this.buttonAnimal.TabIndex = 1;
            this.buttonAnimal.Text = "ANIMAIS";
            this.buttonAnimal.UseVisualStyleBackColor = false;
            this.buttonAnimal.Click += new System.EventHandler(this.buttonAnimal_Click);
            // 
            // buttonRaca
            // 
            this.buttonRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonRaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRaca.FlatAppearance.BorderSize = 0;
            this.buttonRaca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRaca.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaca.ForeColor = System.Drawing.Color.White;
            this.buttonRaca.Location = new System.Drawing.Point(34, 419);
            this.buttonRaca.Name = "buttonRaca";
            this.buttonRaca.Size = new System.Drawing.Size(156, 60);
            this.buttonRaca.TabIndex = 2;
            this.buttonRaca.Text = "RAÇAS";
            this.buttonRaca.UseVisualStyleBackColor = false;
            this.buttonRaca.Click += new System.EventHandler(this.buttonRaca_Click);
            // 
            // buttonServico
            // 
            this.buttonServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonServico.FlatAppearance.BorderSize = 0;
            this.buttonServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonServico.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServico.ForeColor = System.Drawing.Color.White;
            this.buttonServico.Location = new System.Drawing.Point(34, 496);
            this.buttonServico.Name = "buttonServico";
            this.buttonServico.Size = new System.Drawing.Size(156, 60);
            this.buttonServico.TabIndex = 3;
            this.buttonServico.Text = "SERVIÇOS";
            this.buttonServico.UseVisualStyleBackColor = false;
            this.buttonServico.Click += new System.EventHandler(this.buttonServico_Click);
            // 
            // buttonAgendamento
            // 
            this.buttonAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgendamento.FlatAppearance.BorderSize = 0;
            this.buttonAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgendamento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgendamento.ForeColor = System.Drawing.Color.White;
            this.buttonAgendamento.Location = new System.Drawing.Point(34, 574);
            this.buttonAgendamento.Name = "buttonAgendamento";
            this.buttonAgendamento.Size = new System.Drawing.Size(156, 60);
            this.buttonAgendamento.TabIndex = 4;
            this.buttonAgendamento.Text = "AGENDAMENTOS";
            this.buttonAgendamento.UseVisualStyleBackColor = false;
            this.buttonAgendamento.Click += new System.EventHandler(this.buttonAgendamento_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.Color.White;
            this.buttonInicio.Location = new System.Drawing.Point(34, 187);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(156, 60);
            this.buttonInicio.TabIndex = 5;
            this.buttonInicio.Text = "INÍCIO";
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.DarkMagenta;
            this.panelSelecao.Location = new System.Drawing.Point(18, 187);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(10, 60);
            this.panelSelecao.TabIndex = 6;
            this.panelSelecao.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSelecao_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "PetShop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Patinhas Felizes";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelCentral.BackgroundImage = global::PrjPetShop2020.Properties.Resources.depositphotos_135506204_stock_illustration_vector_seamless_pattern_with_cute;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(229, 53);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(838, 743);
            this.panelCentral.TabIndex = 2;
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonMin.BackgroundImage = global::PrjPetShop2020.Properties.Resources.unnamed;
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Location = new System.Drawing.Point(756, 12);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(25, 25);
            this.buttonMin.TabIndex = 6;
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSair.BackgroundImage = global::PrjPetShop2020.Properties.Resources._106830;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(794, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(25, 25);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 796);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelLateral);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelTopo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button buttonAgendamento;
        private System.Windows.Forms.Button buttonServico;
        private System.Windows.Forms.Button buttonRaca;
        private System.Windows.Forms.Button buttonAnimal;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

