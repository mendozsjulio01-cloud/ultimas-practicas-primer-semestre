namespace temperatura
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
            temperaturaLabel = new Label();
            humedadLabel = new Label();
            botonConectar = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            temperaturaLabel.Location = new Point(58, 150);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new Size(132, 28);
            temperaturaLabel.TabIndex = 0;
            temperaturaLabel.Text = "Temperatura\r\n";
            temperaturaLabel.Click += temperaturaLabel_Click;
            // 
            // humedadLabel
            // 
            humedadLabel.AutoSize = true;
            humedadLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            humedadLabel.Location = new Point(84, 360);
            humedadLabel.Name = "humedadLabel";
            humedadLabel.Size = new Size(103, 28);
            humedadLabel.TabIndex = 1;
            humedadLabel.Text = "Humedad";
            humedadLabel.Click += humedadLabel_Click;
            // 
            // botonConectar
            // 
            botonConectar.BackColor = Color.DarkViolet;
            botonConectar.Font = new Font("Segoe UI", 14F);
            botonConectar.ForeColor = SystemColors.ButtonFace;
            botonConectar.Location = new Point(371, 346);
            botonConectar.Name = "botonConectar";
            botonConectar.Size = new Size(119, 58);
            botonConectar.TabIndex = 2;
            botonConectar.Text = "Comenzar";
            botonConectar.UseVisualStyleBackColor = false;
            botonConectar.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkViolet;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(892, 376);
            button1.Name = "button1";
            button1.Size = new Size(159, 48);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(524, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 274);
            listBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Temperatura;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.humedad;
            pictureBox2.Location = new Point(12, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(230, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(1063, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(botonConectar);
            Controls.Add(humedadLabel);
            Controls.Add(temperaturaLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label temperaturaLabel;
        private Label humedadLabel;
        private Button botonConectar;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
