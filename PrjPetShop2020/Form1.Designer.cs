
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
            this.panelCentral = new System.Windows.Forms.Panel();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAnimal = new System.Windows.Forms.Button();
            this.buttonRaca = new System.Windows.Forms.Button();
            this.buttonServico = new System.Windows.Forms.Button();
            this.buttonAgendamento = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.Indigo;
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
            this.panelTopo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopo.Controls.Add(this.button1);
            this.panelTopo.Controls.Add(this.buttonSair);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(229, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(838, 53);
            this.panelTopo.TabIndex = 1;
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(229, 53);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(838, 743);
            this.panelCentral.TabIndex = 2;
            // 
            // buttonCliente
            // 
            this.buttonCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCliente.FlatAppearance.BorderSize = 0;
            this.buttonCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCliente.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCliente.ForeColor = System.Drawing.Color.White;
            this.buttonCliente.Location = new System.Drawing.Point(34, 200);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(156, 60);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "CLIENTES";
            this.buttonCliente.UseVisualStyleBackColor = false;
            // 
            // buttonAnimal
            // 
            this.buttonAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAnimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAnimal.FlatAppearance.BorderSize = 0;
            this.buttonAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnimal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimal.ForeColor = System.Drawing.Color.White;
            this.buttonAnimal.Location = new System.Drawing.Point(34, 276);
            this.buttonAnimal.Name = "buttonAnimal";
            this.buttonAnimal.Size = new System.Drawing.Size(156, 60);
            this.buttonAnimal.TabIndex = 1;
            this.buttonAnimal.Text = "ANIMAIS";
            this.buttonAnimal.UseVisualStyleBackColor = false;
            // 
            // buttonRaca
            // 
            this.buttonRaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonRaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRaca.FlatAppearance.BorderSize = 0;
            this.buttonRaca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRaca.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaca.ForeColor = System.Drawing.Color.White;
            this.buttonRaca.Location = new System.Drawing.Point(34, 354);
            this.buttonRaca.Name = "buttonRaca";
            this.buttonRaca.Size = new System.Drawing.Size(156, 60);
            this.buttonRaca.TabIndex = 2;
            this.buttonRaca.Text = "RAÇAS";
            this.buttonRaca.UseVisualStyleBackColor = false;
            // 
            // buttonServico
            // 
            this.buttonServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonServico.FlatAppearance.BorderSize = 0;
            this.buttonServico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonServico.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServico.ForeColor = System.Drawing.Color.White;
            this.buttonServico.Location = new System.Drawing.Point(34, 431);
            this.buttonServico.Name = "buttonServico";
            this.buttonServico.Size = new System.Drawing.Size(156, 60);
            this.buttonServico.TabIndex = 3;
            this.buttonServico.Text = "SERVIÇOS";
            this.buttonServico.UseVisualStyleBackColor = false;
            // 
            // buttonAgendamento
            // 
            this.buttonAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgendamento.FlatAppearance.BorderSize = 0;
            this.buttonAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAgendamento.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgendamento.ForeColor = System.Drawing.Color.White;
            this.buttonAgendamento.Location = new System.Drawing.Point(34, 509);
            this.buttonAgendamento.Name = "buttonAgendamento";
            this.buttonAgendamento.Size = new System.Drawing.Size(156, 60);
            this.buttonAgendamento.TabIndex = 4;
            this.buttonAgendamento.Text = "AGENDAMENTOS";
            this.buttonAgendamento.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.BackgroundImage = global::PrjPetShop2020.Properties.Resources.unnamed;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(756, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSair.BackgroundImage = global::PrjPetShop2020.Properties.Resources._106830;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSair.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.Color.White;
            this.buttonSair.Location = new System.Drawing.Point(794, 12);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(25, 25);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.ForeColor = System.Drawing.Color.White;
            this.buttonInicio.Location = new System.Drawing.Point(34, 122);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(156, 60);
            this.buttonInicio.TabIndex = 5;
            this.buttonInicio.Text = "INÍCIO";
            this.buttonInicio.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonInicio;
    }
}

