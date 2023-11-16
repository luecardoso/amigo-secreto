namespace AmigoSecreto
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
            textBox_Nome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Inserir = new Button();
            listView_Participantes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button_GerarAmigo = new Button();
            label3 = new Label();
            label_Participantes = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label_Mensagem = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Nome
            // 
            textBox_Nome.Cursor = Cursors.IBeam;
            textBox_Nome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Nome.Location = new Point(117, 71);
            textBox_Nome.Multiline = true;
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(582, 30);
            textBox_Nome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(323, 19);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 1;
            label1.Text = "Amigo Secreto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(32, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // button_Inserir
            // 
            button_Inserir.BackColor = Color.GhostWhite;
            button_Inserir.Cursor = Cursors.Hand;
            button_Inserir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Inserir.Location = new Point(715, 71);
            button_Inserir.Name = "button_Inserir";
            button_Inserir.Size = new Size(123, 30);
            button_Inserir.TabIndex = 3;
            button_Inserir.Text = "Inserir";
            button_Inserir.UseVisualStyleBackColor = false;
            button_Inserir.Click += button_Inserir_Click;
            // 
            // listView_Participantes
            // 
            listView_Participantes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView_Participantes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Participantes.Location = new Point(32, 200);
            listView_Participantes.MultiSelect = false;
            listView_Participantes.Name = "listView_Participantes";
            listView_Participantes.Size = new Size(806, 350);
            listView_Participantes.TabIndex = 4;
            listView_Participantes.UseCompatibleStateImageBehavior = false;
            listView_Participantes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nome";
            columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Email";
            columnHeader2.Width = 400;
            // 
            // button_GerarAmigo
            // 
            button_GerarAmigo.BackColor = Color.RoyalBlue;
            button_GerarAmigo.Cursor = Cursors.Hand;
            button_GerarAmigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_GerarAmigo.ForeColor = SystemColors.ControlLightLight;
            button_GerarAmigo.Location = new Point(655, 588);
            button_GerarAmigo.Name = "button_GerarAmigo";
            button_GerarAmigo.Size = new Size(181, 39);
            button_GerarAmigo.TabIndex = 5;
            button_GerarAmigo.Text = "Gerar amigo secreto";
            button_GerarAmigo.UseVisualStyleBackColor = false;
            button_GerarAmigo.Click += button_GerarAmigo_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 161);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 7;
            label3.Text = "Participantes";
            // 
            // label_Participantes
            // 
            label_Participantes.AutoSize = true;
            label_Participantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_Participantes.ForeColor = Color.RoyalBlue;
            label_Participantes.Location = new Point(166, 161);
            label_Participantes.Name = "label_Participantes";
            label_Participantes.Size = new Size(23, 25);
            label_Participantes.TabIndex = 8;
            label_Participantes.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label_Participantes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(listView_Participantes);
            panel1.Controls.Add(button_GerarAmigo);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 672);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label_Mensagem);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button_Inserir);
            panel2.Controls.Add(textBox_Nome);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 137);
            panel2.TabIndex = 9;
            // 
            // label_Mensagem
            // 
            label_Mensagem.AutoSize = true;
            label_Mensagem.Enabled = false;
            label_Mensagem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Mensagem.ForeColor = SystemColors.ControlLightLight;
            label_Mensagem.Location = new Point(117, 113);
            label_Mensagem.Name = "label_Mensagem";
            label_Mensagem.Size = new Size(68, 15);
            label_Mensagem.TabIndex = 4;
            label_Mensagem.Text = "mensagem";
            label_Mensagem.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 666);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Sorteio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_Nome;
        private Label label1;
        private Label label2;
        private Button button_Inserir;
        private ListView listView_Participantes;
        private Button button_GerarAmigo;
        private Label label3;
        private Label label_Participantes;
        private Panel panel1;
        private Panel panel2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private Label label_Mensagem;
        private Button button1;
    }
}