using System.Drawing.Drawing2D;

namespace impiccatoGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < parole.Length / 51; i++)
            {
                combox_tema.Items.Add(parole[i * 50 + i]);
            }
            MessageBox.Show("In questa versione dell'impiccato puoi scegliere il tema, o lasciarlo casuale, e la difficolt�.\n" +
                "Quando si clicca sul pulsante\"invio\" verr� controllato prima l'input di un singolo carattere, poi l'input della" +
                "parola intera, poi la richiesta dei jolly e infine l'indizio.\n" +
                "Quando si commette un'errore di scrittura, ad esempio inserendo la stessa lettera due volte, il gioco continuer� senza " +
                "scalare tentativi.\n" +
                "Se si sbaglia una lettera un tentativo verr� scalato, se invece si sbaglia una parola allora si perder� automaticamente la partita.\n" +
                "Se si vuole cambiare la parola segreta basta cliccare di nuovo sul pulsante genera.");
        }

        Random rnd = new Random();
        int monete = 0, tentativi = 0, punti = 0, maxTent = 0;
        bool jolly = false;
        string usate = "";
        static string[] scelta = new string[3];
        string[] parole = File.ReadAllLines("./paroleImpiccatoGUI.txt");
        char[] parolaSegreta;
        string[] immagini = null;
        public void fine()
        {
            this.Controls.Clear();
            Label lbl_sconfitta = new Label();
            lbl_sconfitta.Font = new Font("Arial", 30);
            lbl_sconfitta.Text = "Hai perso";
            lbl_sconfitta.Location = new Point(300, 156);
            lbl_sconfitta.AutoSize = true;
            this.Controls.Add(lbl_sconfitta);
            Button btn_chiudi = new Button();
            btn_chiudi.Location = new Point(324, 299);
            btn_chiudi.Text = "ciudi";
            btn_chiudi.Click += btn_chiudi_Click;
            this.Controls.Add(btn_chiudi);
            PictureBox pbox_sconfitta = new PictureBox();
            pbox_sconfitta.Location = new Point(625, 246);
            pbox_sconfitta.Name = "pbox_impiccato";
            pbox_sconfitta.Size = new Size(273, 236);
            pbox_sconfitta.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox_sconfitta.TabIndex = 35;
            pbox_sconfitta.TabStop = false;
            pbox_sconfitta.Image = Image.FromFile(".\\impic\\10Errori.png");
            this.Controls.Add(pbox_sconfitta);
        }
        public void aggiornamento()
        {
            lbl_usate.Text = usate;
            lbl_tentativi.Text = tentativi.ToString();
            lbl_monete.Text = monete.ToString();
            lbl_jolly.Text = jolly.ToString();
            lbl_punti.Text = punti.ToString();
            lbl_segreto.Text = new string(parolaSegreta);
            tbox_carattere.Text = null;
            tbox_inserimento.Text = null;
            cbox_jolly.Checked = false;
            combox_indizio.Text = null;
            pbox_impiccato.Image = Image.FromFile(immagini[maxTent - tentativi]);
            cbox_descrizione.Checked = false;
        }
        public void azzeramento()
        {
            string d = lbox_diff.Text;
            monete = d switch { "facile" => 30, "medio" => 20, "difficile" => 10, _ => 20 };
            tentativi = maxTent = d switch { "facile" => 10, "medio" => 7, "difficile" => 5, _ => 7 };
            switch (d)
            {
                case "facile":
                    immagini = new string[] {
                        ".\\impic\\0Errori.png", ".\\impic\\1Errori.png", ".\\impic\\2Errori.png", ".\\impic\\3Errori.png"
                    , ".\\impic\\4Errori.png", ".\\impic\\5Errori.png",
                        ".\\impic\\6Errori.png", ".\\impic\\7Errori.png", ".\\impic\\8Errori.png"
                    , ".\\impic\\9Errori.png", ".\\impic\\10Errori.png" };
                    break;
                case "medio":
                    immagini = new string[] {
                        ".\\impic\\0Errori.png", ".\\impic\\1Errori.png", ".\\impic\\2Errori.png", ".\\impic\\3Errori.png"
                    , ".\\impic\\4Errori.png", ".\\impic\\5Errori.png",
                        ".\\impic\\6Errori.png", ".\\impic\\10Errori.png" };
                    break;
                case "difficile":
                    immagini = new string[] {
                        ".\\impic\\0Errori.png", ".\\impic\\1Errori.png", ".\\impic\\2Errori.png", ".\\impic\\3Errori.png"
                    ,  ".\\impic\\5Errori.png", ".\\impic\\10Errori.png" };
                    break;
                default:
                    immagini = new string[] {
                        ".\\impic\\0Errori.png", ".\\impic\\1Errori.png", ".\\impic\\2Errori.png", ".\\impic\\3Errori.png"
                    , ".\\impic\\4Errori.png", ".\\impic\\5Errori.png",
                        ".\\impic\\6Errori.png", ".\\impic\\10Errori.png" };
                    break;
            }
            jolly = true;
            usate = "";
            lbl_tema.Text = ""; ;
            lbl_usate.Text = usate;
            lbl_tentativi.Text = tentativi.ToString();
            lbl_monete.Text = monete.ToString();
            lbl_jolly.Text = jolly.ToString();
            lbl_punti.Text = punti.ToString();
            pbox_impiccato.Image = Image.FromFile(immagini[0]);
            btn_invio.Enabled = true;
            lbl_descrizione.Text = "";
            combox_tema.SelectedIndex = -1;
        }
        public void trovaParola()
        {
            if (combox_tema.SelectedIndex == -1)
            {
                int arg1 = rnd.Next(10);
                int arg2 = rnd.Next(1, 51);
                scelta[0] = parole[arg1 * 50 + arg1].ToLower();
                scelta[1] = parole[arg1 * 50 + arg1 + arg2].ToLower().Split(" - ")[0];
                scelta[2] = parole[arg1 * 50 + arg1 + arg2].ToLower().Split(" - ")[1];
            }
            else
            {
                int arg1 = combox_tema.SelectedIndex;
                int arg2 = rnd.Next(1, 51);
                scelta[0] = parole[arg1 * 50 + arg1].ToLower();
                scelta[1] = parole[arg1 * 50 + arg1 + arg2].ToLower().Split(" - ")[0];
                scelta[2] = parole[arg1 * 50 + arg1 + arg2].ToLower().Split(" - ")[1];
            }
        }

        private void btn_parola_Click(object sender, EventArgs e)
        {
            trovaParola();

            azzeramento();

            parolaSegreta = new string('_', scelta[1].Length).ToCharArray();
            lbl_segreto.Text = new string(parolaSegreta);
        }

        private void btn_invio_Click(object sender, EventArgs e)
        {
            if (tbox_carattere.Text.Length > 0)
            {
                if (Char.IsLetter(tbox_carattere.Text[0]))
                {
                    char c = tbox_carattere.Text.ToLower()[0];
                    if (!usate.Contains(c))
                    {
                        usate += c;
                        if (scelta[1].Contains(c))
                        {
                            for (int i = 0; i < scelta[1].Length; i++)
                            {
                                if (scelta[1][i] == c)
                                {
                                    parolaSegreta[i] = c;
                                }
                            }
                            punti += 5;
                        }
                        else
                        {
                            tentativi--;
                        }
                    }
                }
            }
            else if (tbox_inserimento.Text.Length > 0)
            {
                string p = tbox_inserimento.Text.ToLower();
                if (scelta[1] == p)
                {
                    parolaSegreta = scelta[1].ToCharArray();
                    punti += 20;
                }
                else
                {
                    tentativi = 0;
                }
            }
            else if (cbox_jolly.Checked && jolly)
            {
                bool cambio = true;
                while (cambio)
                {
                    int x = rnd.Next(1, parolaSegreta.Length - 1);
                    if (parolaSegreta[x] == '_')
                    {
                        parolaSegreta[x] = scelta[1][x];
                        jolly = false;
                        cambio = false;
                    }
                }
            }
            else if (cbox_descrizione.Checked && jolly)
            {
                lbl_descrizione.Text = scelta[2];
                jolly = false;
            }
            else if (combox_indizio.Text.Length > 0)
            {
                switch (combox_indizio.Text)
                {
                    case "prima lettera":
                        if (parolaSegreta[0] == '_' && monete >= 10)
                        {
                            monete -= 10;
                            parolaSegreta[0] = scelta[1][0];
                        }
                        break;
                    case "ultima lettera":
                        if (parolaSegreta[parolaSegreta.Length - 1] == '_' && monete >= 5)
                        {
                            monete -= 5;
                            parolaSegreta[parolaSegreta.Length - 1] = scelta[1][parolaSegreta.Length - 1];
                        }
                        break;
                    case "tema":
                        if (lbl_tema.Text != scelta[0] && monete >= 15)
                        {
                            monete -= 15;
                            lbl_tema.Text = scelta[0];
                        }
                        break;
                }
            }

            aggiornamento();

            if (!parolaSegreta.Contains('_'))
            {
                btn_invio.Enabled = false;
                lbox_trovate.Items.Add(lbl_segreto.Text);
            }
            else if (tentativi == 0)
            {
                fine();
            }
        }

        private void btn_chiudi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La prossima volta andr� meglio!!");
            this.Close();
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            combox_tema.SelectedIndex = -1;
        }
    }
}
