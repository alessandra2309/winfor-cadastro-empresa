namespace CadastroPDS
{
    partial class CadastroE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tx_razaoS = new TextBox();
            tx_nomeF = new TextBox();
            cb_situacaoC = new ComboBox();
            dt_dataI = new DateTimePicker();
            tx_capitalS = new TextBox();
            cb_endereco = new ComboBox();
            tx_nome = new TextBox();
            cb_naturezaJ = new ComboBox();
            bt_salvar = new Button();
            bt_cancelar = new Button();
            mk_cpf = new MaskedTextBox();
            mk_telefone = new MaskedTextBox();
            mk_cnpj = new MaskedTextBox();
            panel1 = new Panel();
            rb_grande = new RadioButton();
            rb_medio = new RadioButton();
            rb_pequeno = new RadioButton();
            label11 = new Label();
            panel2 = new Panel();
            rb_filial = new RadioButton();
            rb_matriz = new RadioButton();
            label10 = new Label();
            panel3 = new Panel();
            rb_real = new RadioButton();
            rb_lucro = new RadioButton();
            rb_simplesN = new RadioButton();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 24);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Cnpj";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 88);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 164);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Nome Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 320);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 3;
            label4.Text = "Situação Cadastral";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 24);
            label6.Name = "label6";
            label6.Size = new Size(191, 20);
            label6.TabIndex = 5;
            label6.Text = "Data de Inicio de Atividade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(629, 24);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 6;
            label7.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 122);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 7;
            label8.Text = "Capital Socíal";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(270, 244);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 8;
            label9.Text = "Endereço";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(270, 324);
            label12.Name = "label12";
            label12.Size = new Size(123, 20);
            label12.TabIndex = 11;
            label12.Text = "Natureza Jurídica";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(633, 122);
            label13.Name = "label13";
            label13.Size = new Size(133, 20);
            label13.TabIndex = 12;
            label13.Text = "Nome Proprietário";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(69, 239);
            label14.Name = "label14";
            label14.Size = new Size(115, 20);
            label14.TabIndex = 13;
            label14.Text = "Cpf Proprietário";
            // 
            // tx_razaoS
            // 
            tx_razaoS.Location = new Point(69, 122);
            tx_razaoS.Name = "tx_razaoS";
            tx_razaoS.Size = new Size(125, 27);
            tx_razaoS.TabIndex = 15;
            // 
            // tx_nomeF
            // 
            tx_nomeF.Location = new Point(69, 194);
            tx_nomeF.Name = "tx_nomeF";
            tx_nomeF.Size = new Size(125, 27);
            tx_nomeF.TabIndex = 16;
            // 
            // cb_situacaoC
            // 
            cb_situacaoC.FormattingEnabled = true;
            cb_situacaoC.Items.AddRange(new object[] { "Ativa", "Nula", "Suspensa", "Inapta", "Baixada" });
            cb_situacaoC.Location = new Point(64, 353);
            cb_situacaoC.Name = "cb_situacaoC";
            cb_situacaoC.Size = new Size(125, 28);
            cb_situacaoC.TabIndex = 17;
            // 
            // dt_dataI
            // 
            dt_dataI.Location = new Point(283, 56);
            dt_dataI.Name = "dt_dataI";
            dt_dataI.Size = new Size(250, 27);
            dt_dataI.TabIndex = 19;
            // 
            // tx_capitalS
            // 
            tx_capitalS.Location = new Point(472, 157);
            tx_capitalS.Name = "tx_capitalS";
            tx_capitalS.Size = new Size(125, 27);
            tx_capitalS.TabIndex = 24;
            // 
            // cb_endereco
            // 
            cb_endereco.FormattingEnabled = true;
            cb_endereco.Items.AddRange(new object[] { "Acre - AC", "Alagoas - AL", "Amapá - AP", "Amazonas - AM", "Bahia - BA", "Ceará - CE", "Distrito Federal - DF", "Espírito Santo - ES", "Goiás - GO", "Maranhão - MA", "Mato Grosso - MT", "Mato Grosso do Sul - MS", "Minas Gerais - MG", "Pará - PA", "Paraíba - PB", "Paraná - PR", "Pernambuco - PE", "Piauí - PI", "Rio de Janeiro - RJ", "Rio Grande do Norte - RN", "Rio Grande do Sul - RS", "Rondônia - RO", "Roraima - RR", "Santa Catarina - SC", "São Paulo - SP", "Sergipe - SE", "Tocantins - TO" });
            cb_endereco.Location = new Point(270, 275);
            cb_endereco.Name = "cb_endereco";
            cb_endereco.Size = new Size(151, 28);
            cb_endereco.TabIndex = 25;
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(633, 157);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(125, 27);
            tx_nome.TabIndex = 26;
            // 
            // cb_naturezaJ
            // 
            cb_naturezaJ.FormattingEnabled = true;
            cb_naturezaJ.Items.AddRange(new object[] { "EI - Empresário Individual", "MEI - Microempreendedor Individual", "Sociedade Anônima" });
            cb_naturezaJ.Location = new Point(272, 353);
            cb_naturezaJ.Name = "cb_naturezaJ";
            cb_naturezaJ.Size = new Size(151, 28);
            cb_naturezaJ.TabIndex = 33;
            // 
            // bt_salvar
            // 
            bt_salvar.ForeColor = Color.Red;
            bt_salvar.Location = new Point(486, 363);
            bt_salvar.Name = "bt_salvar";
            bt_salvar.Size = new Size(122, 45);
            bt_salvar.TabIndex = 34;
            bt_salvar.Text = "Salvar";
            bt_salvar.UseVisualStyleBackColor = true;
            bt_salvar.Click += button1_Click;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Location = new Point(627, 363);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(122, 45);
            bt_cancelar.TabIndex = 35;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += button2_Click_1;
            // 
            // mk_cpf
            // 
            mk_cpf.Location = new Point(69, 271);
            mk_cpf.Mask = "000.000.000-00";
            mk_cpf.Name = "mk_cpf";
            mk_cpf.Size = new Size(125, 27);
            mk_cpf.TabIndex = 36;
            // 
            // mk_telefone
            // 
            mk_telefone.Location = new Point(633, 58);
            mk_telefone.Mask = "(00)0000-0000";
            mk_telefone.Name = "mk_telefone";
            mk_telefone.Size = new Size(125, 27);
            mk_telefone.TabIndex = 37;
            // 
            // mk_cnpj
            // 
            mk_cnpj.Location = new Point(71, 47);
            mk_cnpj.Mask = "00.000.000/0000-00";
            mk_cnpj.Name = "mk_cnpj";
            mk_cnpj.Size = new Size(125, 27);
            mk_cnpj.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Controls.Add(rb_grande);
            panel1.Controls.Add(rb_medio);
            panel1.Controls.Add(rb_pequeno);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(623, 202);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 142);
            panel1.TabIndex = 39;
            // 
            // rb_grande
            // 
            rb_grande.AutoSize = true;
            rb_grande.Location = new Point(13, 103);
            rb_grande.Name = "rb_grande";
            rb_grande.Size = new Size(78, 24);
            rb_grande.TabIndex = 36;
            rb_grande.TabStop = true;
            rb_grande.Text = "Grande";
            rb_grande.UseVisualStyleBackColor = true;
            // 
            // rb_medio
            // 
            rb_medio.AutoSize = true;
            rb_medio.Location = new Point(13, 73);
            rb_medio.Name = "rb_medio";
            rb_medio.Size = new Size(73, 24);
            rb_medio.TabIndex = 35;
            rb_medio.TabStop = true;
            rb_medio.Text = "Médio";
            rb_medio.UseVisualStyleBackColor = true;
            // 
            // rb_pequeno
            // 
            rb_pequeno.AutoSize = true;
            rb_pequeno.Location = new Point(13, 43);
            rb_pequeno.Name = "rb_pequeno";
            rb_pequeno.Size = new Size(87, 24);
            rb_pequeno.TabIndex = 34;
            rb_pequeno.TabStop = true;
            rb_pequeno.Text = "Pequeno";
            rb_pequeno.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 20);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 33;
            label11.Text = "Porte de  Empresa";
            // 
            // panel2
            // 
            panel2.Controls.Add(rb_filial);
            panel2.Controls.Add(rb_matriz);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(472, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 146);
            panel2.TabIndex = 40;
            // 
            // rb_filial
            // 
            rb_filial.AutoSize = true;
            rb_filial.Location = new Point(26, 90);
            rb_filial.Name = "rb_filial";
            rb_filial.Size = new Size(61, 24);
            rb_filial.TabIndex = 32;
            rb_filial.TabStop = true;
            rb_filial.Text = "Filial";
            rb_filial.UseVisualStyleBackColor = true;
            // 
            // rb_matriz
            // 
            rb_matriz.AutoSize = true;
            rb_matriz.Location = new Point(26, 60);
            rb_matriz.Name = "rb_matriz";
            rb_matriz.Size = new Size(72, 24);
            rb_matriz.TabIndex = 31;
            rb_matriz.TabStop = true;
            rb_matriz.Text = "Matriz";
            rb_matriz.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 32);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 30;
            label10.Text = "tipo";
            // 
            // panel3
            // 
            panel3.Controls.Add(rb_real);
            panel3.Controls.Add(rb_lucro);
            panel3.Controls.Add(rb_simplesN);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(236, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 125);
            panel3.TabIndex = 41;
            // 
            // rb_real
            // 
            rb_real.AutoSize = true;
            rb_real.Location = new Point(36, 96);
            rb_real.Name = "rb_real";
            rb_real.Size = new Size(59, 24);
            rb_real.TabIndex = 26;
            rb_real.TabStop = true;
            rb_real.Text = "Real";
            rb_real.UseVisualStyleBackColor = true;
            // 
            // rb_lucro
            // 
            rb_lucro.AutoSize = true;
            rb_lucro.Location = new Point(36, 66);
            rb_lucro.Name = "rb_lucro";
            rb_lucro.Size = new Size(140, 24);
            rb_lucro.TabIndex = 25;
            rb_lucro.TabStop = true;
            rb_lucro.Text = "Lucro Presumido";
            rb_lucro.UseVisualStyleBackColor = true;
            // 
            // rb_simplesN
            // 
            rb_simplesN.AutoSize = true;
            rb_simplesN.Location = new Point(36, 40);
            rb_simplesN.Name = "rb_simplesN";
            rb_simplesN.Size = new Size(145, 24);
            rb_simplesN.TabIndex = 24;
            rb_simplesN.TabStop = true;
            rb_simplesN.Text = "Simples Nacional";
            rb_simplesN.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 12);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 23;
            label5.Text = "Regime Tributário";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CadastroE
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(816, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mk_cnpj);
            Controls.Add(mk_telefone);
            Controls.Add(mk_cpf);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_salvar);
            Controls.Add(cb_naturezaJ);
            Controls.Add(tx_nome);
            Controls.Add(cb_endereco);
            Controls.Add(tx_capitalS);
            Controls.Add(dt_dataI);
            Controls.Add(cb_situacaoC);
            Controls.Add(tx_nomeF);
            Controls.Add(tx_razaoS);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CadastroE";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "CadastroE";
          //  Load += CadastroE_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox tx_razaoS;
        private TextBox tx_nomeF;
        private ComboBox cb_situacaoC;
        private DateTimePicker dt_dataI;
        private TextBox tx_capitalS;
        private ComboBox cb_endereco;
        private TextBox tx_nome;
        private ComboBox cb_naturezaJ;
        private Button bt_salvar;
        private Button bt_cancelar;
        private MaskedTextBox mk_cpf;
        private MaskedTextBox mk_telefone;
        private MaskedTextBox mk_cnpj;
        private Panel panel1;
        private RadioButton rb_grande;
        private RadioButton rb_medio;
        private RadioButton rb_pequeno;
        private Label label11;
        private Panel panel2;
        private RadioButton rb_filial;
        private RadioButton rb_matriz;
        private Label label10;
        private Panel panel3;
        private RadioButton rb_real;
        private RadioButton rb_lucro;
        private RadioButton rb_simplesN;
        private Label label5;
        private ErrorProvider errorProvider1;
    }
}