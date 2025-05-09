namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            button3 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            button5 = new Button();
            sidebarTime = new System.Windows.Forms.Timer(components);
            sidebarLay = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button6 = new Button();
            comCargo = new ComboBox();
            label3 = new Label();
            cobDepartamento = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblNome = new Label();
            txtCPF = new TextBox();
            txtNome = new TextBox();
            tabPage2 = new TabPage();
            sidebar2 = new FlowLayoutPanel();
            txtSalario = new TextBox();
            label4 = new Label();
            txtDatadeCo = new TextBox();
            label5 = new Label();
            txtTelefone = new TextBox();
            lblTelefone = new Label();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            sidebar2.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.LightBlue;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(160, 501);
            sidebar.MinimumSize = new Size(46, 501);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(160, 501);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 100);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 42);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-23, -12);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(193, 71);
            button3.TabIndex = 2;
            button3.Text = "Funcionario";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(156, 42);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-23, -12);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(193, 71);
            button2.TabIndex = 2;
            button2.Text = "Departamento";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 205);
            panel5.Name = "panel5";
            panel5.Size = new Size(156, 42);
            panel5.TabIndex = 6;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-23, -12);
            button4.Name = "button4";
            button4.Padding = new Padding(30, 0, 0, 0);
            button4.Size = new Size(193, 71);
            button4.TabIndex = 2;
            button4.Text = "Login usuario:";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 253);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 42);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-23, -12);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(193, 71);
            button1.TabIndex = 2;
            button1.Text = "Cargo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(711, 473);
            button5.Name = "button5";
            button5.Size = new Size(88, 28);
            button5.TabIndex = 1;
            button5.Text = "Sair";
            button5.UseVisualStyleBackColor = true;
            // 
            // sidebarTime
            // 
            sidebarTime.Interval = 10;
            sidebarTime.Tick += sidebarTime_Tick;
            // 
            // sidebarLay
            // 
            sidebarLay.Interval = 10;
            sidebarLay.Tick += sidebarLay_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(637, 498);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.AliceBlue;
            tabPage1.Controls.Add(lblTelefone);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtDatadeCo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtSalario);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(comCargo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cobDepartamento);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lblNome);
            tabPage1.Controls.Add(txtCPF);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(629, 470);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // button6
            // 
            button6.Location = new Point(471, 426);
            button6.Name = "button6";
            button6.Size = new Size(128, 36);
            button6.TabIndex = 10;
            button6.Text = "Enviar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comCargo
            // 
            comCargo.FormattingEnabled = true;
            comCargo.Location = new Point(68, 75);
            comCargo.Name = "comCargo";
            comCargo.Size = new Size(212, 23);
            comCargo.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 126);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Departamneto";
            // 
            // cobDepartamento
            // 
            cobDepartamento.FormattingEnabled = true;
            cobDepartamento.Location = new Point(111, 118);
            cobDepartamento.Name = "cobDepartamento";
            cobDepartamento.Size = new Size(169, 23);
            cobDepartamento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 78);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Cargo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 33);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome";
            lblNome.Click += txtNome_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(408, 25);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(208, 23);
            txtCPF.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(68, 25);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(244, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(629, 470);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sidebar2
            // 
            sidebar2.Controls.Add(tabControl1);
            sidebar2.Dock = DockStyle.Fill;
            sidebar2.Location = new Point(160, 0);
            sidebar2.MaximumSize = new Size(753, 501);
            sidebar2.MinimumSize = new Size(634, 501);
            sidebar2.Name = "sidebar2";
            sidebar2.Size = new Size(640, 501);
            sidebar2.TabIndex = 2;
            sidebar2.Paint += sidebar2_Paint;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(408, 75);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(208, 23);
            txtSalario.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 78);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 12;
            label4.Text = "Salario:";
            // 
            // txtDatadeCo
            // 
            txtDatadeCo.Location = new Point(408, 118);
            txtDatadeCo.Name = "txtDatadeCo";
            txtDatadeCo.Size = new Size(208, 23);
            txtDatadeCo.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(287, 126);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 14;
            label5.Text = "Data de Contratação";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(408, 166);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(208, 23);
            txtTelefone.TabIndex = 15;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(351, 174);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 16;
            lblTelefone.Text = "Telefone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(sidebar2);
            Controls.Add(sidebar);
            Controls.Add(button5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            sidebar2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTime;
        private System.Windows.Forms.Timer sidebarLay;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button6;
        private ComboBox comCargo;
        private Label label3;
        private ComboBox cobDepartamento;
        private Label label2;
        private Label label1;
        private Label lblNome;
        private TextBox txtCPF;
        private TextBox txtNome;
        private TabPage tabPage2;
        private FlowLayoutPanel sidebar2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Label label5;
        private TextBox txtDatadeCo;
        private Label label4;
        private TextBox txtSalario;
    }
}
