using System.Web;

namespace Nasa_pawan
{
    public partial class Form1 : Form
    {
        private bool houstonPronto = false; // Stato di Houston
        private bool capePronto = false;    // Stato di Cape Canaveral

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button_houston_Click(object sender, EventArgs e)
        {
            Thread threadHouston = new Thread(() => ContaAllaRovescia("Houston"));
            threadHouston.Start();
        }

        private void button_cape_Click(object sender, EventArgs e)
        {
            Thread threadCape = new Thread(() => ContaAllaRovescia("Cape Canaveral"));
            threadCape.Start();
        }
        private void ContaAllaRovescia(string centro)
        {
            for (int i = 10; i > 0; i--)
            {
                // Aggiorna l'etichetta corrispondente al centro
                if (centro == "Houston")
                {
                    Invoke(new Action(() =>
                    {
                        label_houston.Text = $"Houston: {i} secondi...";
                    }));
                }
                else if (centro == "Cape Canaveral")
                {
                    Invoke(new Action(() =>
                    {
                        labelCape.Text = $"Cape Canaveral: {i} secondi...";
                    }));
                }
                Thread.Sleep(1000); // Aspetta 1 secondo
            }

            // Quando il conto alla rovescia è terminato, segna il centro come pronto
            if (centro == "Houston")
            {
                Invoke(new Action(() =>
                {
                    houstonPronto = true;
                    labelHouston.Text = "Houston è pronto!";
                }));
            }
            else if (centro == "Cape Canaveral")
            {
                Invoke(new Action(() =>
                {
                    capePronto = true;
                    labelCape.Text = "Cape Canaveral è pronto!";
                }));
            }

            // Controlla se entrambi i centri sono pronti per il lancio
            ControllaLancio();
        }
        private void ControllaLancio()
        {
            if (houstonPronto && capePronto)
            {
                Invoke(new Action(() =>
                {
                    labelStatus.Text = "Stato: Razzo lanciato!";
                    MessageBox.Show("Il razzo è stato lanciato con successo!");
                }));
            }
        }

    }
}
