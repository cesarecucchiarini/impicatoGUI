namespace impiccatoGUI
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
            lbl_segreto = new Label();
            btn_invio = new Button();
            lbl_tentativi = new Label();
            lbl_monete = new Label();
            lbl_jolly = new Label();
            lbl_usate = new Label();
            btn_info = new Button();
            cbox_jolly = new CheckBox();
            tbox_inserimento = new TextBox();
            tbox_carattere = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_parola = new Button();
            label10 = new Label();
            label11 = new Label();
            lbl_punti = new Label();
            combox_indizio = new ComboBox();
            lbl_tema = new Label();
            label14 = new Label();
            pbox_impiccato = new PictureBox();
            label12 = new Label();
            lbox_diff = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pbox_impiccato).BeginInit();
            SuspendLayout();
            // 
            // lbl_segreto
            // 
            lbl_segreto.AutoSize = true;
            lbl_segreto.BackColor = SystemColors.ActiveCaption;
            lbl_segreto.Font = new Font("Segoe UI", 12F);
            lbl_segreto.Location = new Point(323, 72);
            lbl_segreto.Name = "lbl_segreto";
            lbl_segreto.Size = new Size(0, 21);
            lbl_segreto.TabIndex = 1;
            // 
            // btn_invio
            // 
            btn_invio.Enabled = false;
            btn_invio.Location = new Point(332, 302);
            btn_invio.Name = "btn_invio";
            btn_invio.Size = new Size(75, 23);
            btn_invio.TabIndex = 2;
            btn_invio.Text = "invio";
            btn_invio.UseVisualStyleBackColor = true;
            btn_invio.Click += btn_invio_Click;
            // 
            // lbl_tentativi
            // 
            lbl_tentativi.AutoSize = true;
            lbl_tentativi.BackColor = SystemColors.ActiveCaption;
            lbl_tentativi.Location = new Point(71, 18);
            lbl_tentativi.Name = "lbl_tentativi";
            lbl_tentativi.Size = new Size(0, 15);
            lbl_tentativi.TabIndex = 3;
            // 
            // lbl_monete
            // 
            lbl_monete.AutoSize = true;
            lbl_monete.BackColor = SystemColors.ActiveCaption;
            lbl_monete.Location = new Point(71, 53);
            lbl_monete.Name = "lbl_monete";
            lbl_monete.Size = new Size(0, 15);
            lbl_monete.TabIndex = 4;
            // 
            // lbl_jolly
            // 
            lbl_jolly.AutoSize = true;
            lbl_jolly.BackColor = SystemColors.ActiveCaption;
            lbl_jolly.Location = new Point(71, 91);
            lbl_jolly.Name = "lbl_jolly";
            lbl_jolly.Size = new Size(0, 15);
            lbl_jolly.TabIndex = 5;
            // 
            // lbl_usate
            // 
            lbl_usate.AutoSize = true;
            lbl_usate.BackColor = SystemColors.ActiveCaption;
            lbl_usate.Font = new Font("Segoe UI", 12F);
            lbl_usate.Location = new Point(599, 72);
            lbl_usate.Name = "lbl_usate";
            lbl_usate.Size = new Size(0, 21);
            lbl_usate.TabIndex = 6;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(332, 355);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(75, 23);
            btn_info.TabIndex = 11;
            btn_info.Text = "info";
            btn_info.UseVisualStyleBackColor = true;
            btn_info.Click += btn_info_Click;
            // 
            // cbox_jolly
            // 
            cbox_jolly.AutoSize = true;
            cbox_jolly.Font = new Font("Segoe UI", 9F);
            cbox_jolly.Location = new Point(503, 218);
            cbox_jolly.Name = "cbox_jolly";
            cbox_jolly.Size = new Size(15, 14);
            cbox_jolly.TabIndex = 12;
            cbox_jolly.UseVisualStyleBackColor = true;
            // 
            // tbox_inserimento
            // 
            tbox_inserimento.Location = new Point(302, 214);
            tbox_inserimento.Name = "tbox_inserimento";
            tbox_inserimento.Size = new Size(150, 23);
            tbox_inserimento.TabIndex = 13;
            // 
            // tbox_carattere
            // 
            tbox_carattere.Location = new Point(198, 214);
            tbox_carattere.Name = "tbox_carattere";
            tbox_carattere.Size = new Size(29, 23);
            tbox_carattere.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(160, 196);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 15;
            label1.Text = "inserisci una lettera";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(302, 196);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 16;
            label2.Text = "inserisci la parola completa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(495, 196);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 17;
            label3.Text = "jolly";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Location = new Point(626, 196);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "indizio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(323, 53);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 19;
            label5.Text = "parola segreta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(599, 53);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 20;
            label6.Text = "lettere usate:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(12, 18);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 21;
            label7.Text = "tentativi:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(12, 53);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 22;
            label8.Text = "monete:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Location = new Point(12, 91);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 23;
            label9.Text = "jolly:";
            // 
            // btn_parola
            // 
            btn_parola.Location = new Point(160, 53);
            btn_parola.Name = "btn_parola";
            btn_parola.Size = new Size(61, 40);
            btn_parola.TabIndex = 24;
            btn_parola.Text = "genera parola";
            btn_parola.UseVisualStyleBackColor = true;
            btn_parola.Click += btn_parola_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Location = new Point(71, 125);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Location = new Point(12, 125);
            label11.Name = "label11";
            label11.Size = new Size(38, 15);
            label11.TabIndex = 25;
            label11.Text = "punti:";
            // 
            // lbl_punti
            // 
            lbl_punti.AutoSize = true;
            lbl_punti.BackColor = SystemColors.ActiveCaption;
            lbl_punti.Location = new Point(71, 125);
            lbl_punti.Name = "lbl_punti";
            lbl_punti.Size = new Size(0, 15);
            lbl_punti.TabIndex = 27;
            // 
            // combox_indizio
            // 
            combox_indizio.DropDownStyle = ComboBoxStyle.DropDownList;
            combox_indizio.FormattingEnabled = true;
            combox_indizio.Items.AddRange(new object[] { "prima lettera", "ultima lettera", "tema" });
            combox_indizio.Location = new Point(613, 214);
            combox_indizio.Name = "combox_indizio";
            combox_indizio.Size = new Size(70, 23);
            combox_indizio.TabIndex = 32;
            // 
            // lbl_tema
            // 
            lbl_tema.AutoSize = true;
            lbl_tema.BackColor = SystemColors.ActiveCaption;
            lbl_tema.Location = new Point(71, 164);
            lbl_tema.Name = "lbl_tema";
            lbl_tema.Size = new Size(0, 15);
            lbl_tema.TabIndex = 34;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaption;
            label14.Location = new Point(12, 164);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 33;
            label14.Text = "tema:";
            // 
            // pbox_impiccato
            // 
            pbox_impiccato.Location = new Point(29, 258);
            pbox_impiccato.Name = "pbox_impiccato";
            pbox_impiccato.Size = new Size(215, 180);
            pbox_impiccato.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_impiccato.TabIndex = 35;
            pbox_impiccato.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Location = new Point(644, 355);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 37;
            label12.Text = "difficoltà";
            // 
            // lbox_diff
            // 
            lbox_diff.FormattingEnabled = true;
            lbox_diff.ItemHeight = 15;
            lbox_diff.Items.AddRange(new object[] { "facile", "medio", "difficile" });
            lbox_diff.Location = new Point(613, 373);
            lbox_diff.Name = "lbox_diff";
            lbox_diff.Size = new Size(120, 49);
            lbox_diff.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbox_diff);
            Controls.Add(label12);
            Controls.Add(pbox_impiccato);
            Controls.Add(lbl_tema);
            Controls.Add(label14);
            Controls.Add(combox_indizio);
            Controls.Add(lbl_punti);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(btn_parola);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbox_carattere);
            Controls.Add(tbox_inserimento);
            Controls.Add(cbox_jolly);
            Controls.Add(btn_info);
            Controls.Add(lbl_usate);
            Controls.Add(lbl_jolly);
            Controls.Add(lbl_monete);
            Controls.Add(lbl_tentativi);
            Controls.Add(btn_invio);
            Controls.Add(lbl_segreto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbox_impiccato).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_segreto;
        private Button btn_invio;
        private Label lbl_tentativi;
        private Label lbl_monete;
        private Label lbl_jolly;
        private Label lbl_usate;
        private Button btn_info;
        private CheckBox cbox_jolly;
        private TextBox tbox_inserimento;
        private TextBox tbox_carattere;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btn_parola;
        private Label label10;
        private Label label11;
        private Label lbl_punti;
        private ComboBox combox_indizio;
        private Label lbl_tema;
        private Label label14;
        private PictureBox pbox_impiccato;
        private Label label12;
        private ListBox lbox_diff;
    }
}
