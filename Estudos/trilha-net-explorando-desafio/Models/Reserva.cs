namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public Reserva() { }
        public Reserva(int diasReservados){DiasReservados = diasReservados;}
        
        public void CadastrarHospedes(List<Pessoa> hospedes)
            {
                if (hospedes.Count <= Suite.Capacidade){Hospedes = hospedes;}
                else{throw new Exception("A capacidade dessa suíte é menor que a quantidade de hóspedes.");}
            }

        public void CadastrarSuite(Suite suite){Suite = suite;}
        public int ObterQuantidadeHospedes(){return Hospedes.Count;}
        public decimal CalcularValorDiaria()
            {decimal valor = DiasReservados * Suite.ValorDiaria;decimal diarias = valor;
                if (DiasReservados >= 10){valor -= diarias * 0.10M;}
                else{valor = diarias;}
                return valor;
            }
    }
}