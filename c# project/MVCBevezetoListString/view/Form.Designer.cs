namespace MVCBevezetoListString
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1Hozzadas = new System.Windows.Forms.Button();
            this.button2Torol = new System.Windows.Forms.Button();
            this.button3Modosit = new System.Windows.Forms.Button();
            this.button4Kiszamol = new System.Windows.Forms.Button();
            this.button5Kilep = new System.Windows.Forms.Button();
            this.listBox1Lista = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTaj = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjon meg egy TAJ számot";
            // 
            // button1Hozzadas
            // 
            this.button1Hozzadas.Location = new System.Drawing.Point(388, 25);
            this.button1Hozzadas.Name = "button1Hozzadas";
            this.button1Hozzadas.Size = new System.Drawing.Size(75, 23);
            this.button1Hozzadas.TabIndex = 1;
            this.button1Hozzadas.Text = "Hozzáadás";
            this.button1Hozzadas.UseVisualStyleBackColor = true;
            this.button1Hozzadas.Click += new System.EventHandler(this.button1Hozzadas_Click);
            // 
            // button2Torol
            // 
            this.button2Torol.Location = new System.Drawing.Point(200, 124);
            this.button2Torol.Name = "button2Torol";
            this.button2Torol.Size = new System.Drawing.Size(75, 23);
            this.button2Torol.TabIndex = 2;
            this.button2Torol.Text = "Törlés";
            this.button2Torol.UseVisualStyleBackColor = true;
            this.button2Torol.Click += new System.EventHandler(this.button2Torol_Click);
            // 
            // button3Modosit
            // 
            this.button3Modosit.Location = new System.Drawing.Point(200, 79);
            this.button3Modosit.Name = "button3Modosit";
            this.button3Modosit.Size = new System.Drawing.Size(75, 23);
            this.button3Modosit.TabIndex = 3;
            this.button3Modosit.Text = "Módosítás";
            this.button3Modosit.UseVisualStyleBackColor = true;
            this.button3Modosit.Click += new System.EventHandler(this.button3Modosit_Click);
            // 
            // button4Kiszamol
            // 
            this.button4Kiszamol.Location = new System.Drawing.Point(3, 10);
            this.button4Kiszamol.Name = "button4Kiszamol";
            this.button4Kiszamol.Size = new System.Drawing.Size(75, 23);
            this.button4Kiszamol.TabIndex = 4;
            this.button4Kiszamol.Text = "Kiszámol";
            this.button4Kiszamol.UseVisualStyleBackColor = true;
            this.button4Kiszamol.Click += new System.EventHandler(this.button4Kiszamol_Click);
            // 
            // button5Kilep
            // 
            this.button5Kilep.Location = new System.Drawing.Point(515, 404);
            this.button5Kilep.Name = "button5Kilep";
            this.button5Kilep.Size = new System.Drawing.Size(75, 23);
            this.button5Kilep.TabIndex = 5;
            this.button5Kilep.Text = "Kilépés";
            this.button5Kilep.UseVisualStyleBackColor = true;
            this.button5Kilep.Click += new System.EventHandler(this.button5Kilep_Click);
            // 
            // listBox1Lista
            // 
            this.listBox1Lista.FormattingEnabled = true;
            this.listBox1Lista.Location = new System.Drawing.Point(16, 5);
            this.listBox1Lista.Name = "listBox1Lista";
            this.listBox1Lista.Size = new System.Drawing.Size(164, 329);
            this.listBox1Lista.TabIndex = 6;
            this.listBox1Lista.SelectedIndexChanged += new System.EventHandler(this.listBox1Lista_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button4Kiszamol);
            this.panel1.Location = new System.Drawing.Point(378, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 280);
            this.panel1.TabIndex = 7;
            // 
            // textBoxTaj
            // 
            this.textBoxTaj.Location = new System.Drawing.Point(175, 28);
            this.textBoxTaj.Name = "textBoxTaj";
            this.textBoxTaj.Size = new System.Drawing.Size(190, 20);
            this.textBoxTaj.TabIndex = 8;
            this.textBoxTaj.TextChanged += new System.EventHandler(this.textBoxTaj_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Darabszám";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listBox1Lista);
            this.panel2.Controls.Add(this.button3Modosit);
            this.panel2.Controls.Add(this.button2Torol);
            this.panel2.Location = new System.Drawing.Point(12, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 349);
            this.panel2.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxTaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5Kilep);
            this.Controls.Add(this.button1Hozzadas);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Hozzadas;
        private System.Windows.Forms.Button button2Torol;
        private System.Windows.Forms.Button button3Modosit;
        private System.Windows.Forms.Button button4Kiszamol;
        private System.Windows.Forms.Button button5Kilep;
        private System.Windows.Forms.ListBox listBox1Lista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxTaj;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

