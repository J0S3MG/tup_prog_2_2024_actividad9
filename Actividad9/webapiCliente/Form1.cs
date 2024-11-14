namespace webapiCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            int tipo = 1;
            using var cliente = new HttpClient();
            string url = "https://localhost:7268/api/Comercio/AgregarTicket?tipo={tipo}&nro=0&dni={dni}";
            HttpRequestMessage consulta = new HttpRequestMessage();
            consulta.Method = HttpMethod.Get;
            consulta.RequestUri = new Uri(url);

            HttpResponseMessage respuesta = cliente.Send(consulta);
            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("No ok");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
