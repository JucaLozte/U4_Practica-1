namespace Practica_1_Gestion_de_ahorros
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
            groupBox1 = new GroupBox();
            btnAbrir = new Button();
            txtMonto = new TextBox();
            txtCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRetiro = new Button();
            btnDeposito = new Button();
            groupBox3 = new GroupBox();
            btnNuevo = new Button();
            txtSaldo = new TextBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(txtMonto);
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // btnAbrir
            // 
            btnAbrir.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbrir.Location = new Point(316, 59);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(114, 29);
            btnAbrir.TabIndex = 4;
            btnAbrir.Text = "Abrir cuenta";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += Abrir_Click;
            // 
            // txtMonto
            // 
            txtMonto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMonto.Location = new Point(88, 83);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(189, 27);
            txtMonto.TabIndex = 3;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCliente.Location = new Point(90, 35);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(189, 27);
            txtCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Monto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 38);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRetiro);
            groupBox2.Controls.Add(btnDeposito);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(21, 143);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(496, 93);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transacciones";
            // 
            // btnRetiro
            // 
            btnRetiro.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetiro.Location = new Point(249, 39);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(104, 36);
            btnRetiro.TabIndex = 1;
            btnRetiro.Text = "Retiro";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // btnDeposito
            // 
            btnDeposito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeposito.Location = new Point(73, 40);
            btnDeposito.Name = "btnDeposito";
            btnDeposito.Size = new Size(104, 35);
            btnDeposito.TabIndex = 0;
            btnDeposito.Text = "Depósito";
            btnDeposito.UseVisualStyleBackColor = true;
            btnDeposito.Click += btnDeposito_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Controls.Add(txtSaldo);
            groupBox3.Controls.Add(listBox2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(21, 242);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(496, 241);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial";
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(351, 154);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(351, 111);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(94, 27);
            txtSaldo.TabIndex = 5;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(186, 69);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(123, 144);
            listBox2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(369, 78);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Saldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(222, 36);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 3;
            label4.Text = "Retiros";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(17, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(121, 144);
            listBox1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 36);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 2;
            label3.Text = "Depósitos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(541, 495);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Gestión de cuenta de ahorros";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAbrir;
        private TextBox txtMonto;
        private TextBox txtCliente;
        private Label label2;
        private Label label1;
        private Button btnRetiro;
        private Button btnDeposito;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label4;
        private Label label3;
        private Button btnNuevo;
        private TextBox txtSaldo;
        private Label label5;
    }
}