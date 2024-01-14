namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string _numero { get; set; }
        private string _email;
        private string _modelo;
        private int _memoria;

        public Smartphone(string numero, string email, string modelo, int memoria)
        {
            _numero = numero;
            _email = email;
            _modelo = modelo;
            _memoria = memoria; 
        }

        public void ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void receberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void instalarAplicativo(string nomeApp);
    }
}