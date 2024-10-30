namespace ListBox
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
            carsListBox = new System.Windows.Forms.ListBox();
            btnAdd = new Button();
            label1 = new Label();
            txtNomeModelo = new TextBox();
            button1 = new Button();
            qtdItens = new Label();
            btnOrdenar = new Button();
            btnRemove = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // carsListBox
            // 
            carsListBox.FormattingEnabled = true;
            carsListBox.ItemHeight = 15;
            carsListBox.Items.AddRange(new object[] { "gol ", "hb20", "320i", "panamera", "911", "488", "urus", "aventador" });
            carsListBox.Location = new Point(51, 31);
            carsListBox.Name = "carsListBox";
            carsListBox.SelectionMode = SelectionMode.MultiSimple;
            carsListBox.Size = new Size(204, 349);
            carsListBox.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(504, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 73);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 2;
            label1.Text = "Adicione um modelo de carro:";
            // 
            // txtNomeModelo
            // 
            txtNomeModelo.Location = new Point(504, 70);
            txtNomeModelo.Name = "txtNomeModelo";
            txtNomeModelo.Size = new Size(182, 23);
            txtNomeModelo.TabIndex = 3;
            txtNomeModelo.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(504, 150);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 4;
            button1.Text = "Contar itens";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // qtdItens
            // 
            qtdItens.AutoSize = true;
            qtdItens.Location = new Point(504, 132);
            qtdItens.Name = "qtdItens";
            qtdItens.Size = new Size(19, 15);
            qtdItens.TabIndex = 5;
            qtdItens.Text = "....";
            qtdItens.Visible = false;
            qtdItens.Click += qtdItens_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(504, 190);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(182, 23);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "ordernar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(504, 233);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(182, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(504, 279);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(182, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar);
            Controls.Add(btnRemove);
            Controls.Add(btnOrdenar);
            Controls.Add(qtdItens);
            Controls.Add(button1);
            Controls.Add(txtNomeModelo);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(carsListBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Box Control";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox carsListBox;
        private Button btnAdd;
        private Label label1;
        private TextBox txtNomeModelo;
        private Button button1;
        private Label qtdItens;
        private Button btnOrdenar;
        private Button btnRemove;
        private Button btnLimpar;
    }
}
