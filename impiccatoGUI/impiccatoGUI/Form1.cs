namespace impiccatoGUI
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int monete = 0, tentativi = 0, punti = 0;
        bool jolly = false;
        string usate = "";
        static string[] scelta = new string[2];
        string[] parole = File.ReadAllLines("./paroleImpiccatoGUI.txt");
        char[] parolaSegreta;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_parola_Click(object sender, EventArgs e)
        {
            monete = 30;
            tentativi = 10;
            jolly = true;
            usate = "";
            lbl_usate.Text = usate;
            lbl_tentativi.Text = tentativi.ToString();
            lbl_monete.Text=monete.ToString();
            lbl_jolly.Text=jolly.ToString();
            lbl_punti.Text = punti.ToString();
            
            int arg1=rnd.Next(10);
            scelta[0] = parole[arg1 * 50 + arg1 + 1];
            scelta[1] = parole[arg1 * 50 + arg1 + 1 + rnd.Next(1, 51)];

            parolaSegreta = new char[scelta[1].Length];
            for(int i = 0; i < parolaSegreta.Length; i++)
            {
                parolaSegreta[i] = '_';
            }
            lbl_segreto.Text = new string(parolaSegreta);
        }
    }
}
