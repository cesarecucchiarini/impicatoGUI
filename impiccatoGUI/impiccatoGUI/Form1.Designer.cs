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
            lbox_indizio = new ListBox();
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
            SuspendLayout();
            // 
            // lbox_indizio
            // 
            lbox_indizio.FormattingEnabled = true;
            lbox_indizio.ItemHeight = 15;
            lbox_indizio.Items.AddRange(new object[] { "niente", "prima lettera", "ultima lettera", "tema" });
            lbox_indizio.Location = new Point(599, 214);
            lbox_indizio.Name = "lbox_indizio";
            lbox_indizio.Size = new Size(95, 19);
            lbox_indizio.TabIndex = 0;
            // 
            // lbl_segreto
            // 
            lbl_segreto.AutoSize = true;
            lbl_segreto.BackColor = SystemColors.ActiveCaption;
            lbl_segreto.Font = new Font("Segoe UI", 12F);
            lbl_segreto.Location = new Point(323, 91);
            lbl_segreto.Name = "lbl_segreto";
            lbl_segreto.Size = new Size(0, 21);
            lbl_segreto.TabIndex = 1;
            // 
            // btn_invio
            // 
            btn_invio.Location = new Point(332, 302);
            btn_invio.Name = "btn_invio";
            btn_invio.Size = new Size(75, 23);
            btn_invio.TabIndex = 2;
            btn_invio.Text = "invio";
            btn_invio.UseVisualStyleBackColor = true;
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
            lbl_usate.Location = new Point(599, 91);
            lbl_usate.Name = "lbl_usate";
            lbl_usate.Size = new Size(0, 21);
            lbl_usate.TabIndex = 6;
            // 
            // btn_info
            // 
            btn_info.Location = new Point(332, 369);
            btn_info.Name = "btn_info";
            btn_info.Size = new Size(75, 23);
            btn_info.TabIndex = 11;
            btn_info.Text = "info";
            btn_info.UseVisualStyleBackColor = true;
            // 
            // cbox_jolly
            // 
            cbox_jolly.AutoSize = true;
            cbox_jolly.Font = new Font("Segoe UI", 9F);
            cbox_jolly.Location = new Point(495, 218);
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
            label5.Location = new Point(323, 64);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 19;
            label5.Text = "parola segreta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Location = new Point(599, 64);
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
            btn_parola.Location = new Point(152, 56);
            btn_parola.Name = "btn_parola";
            btn_parola.Size = new Size(75, 23);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(lbox_indizio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbox_indizio;
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
    }
}
