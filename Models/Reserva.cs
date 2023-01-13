
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {

        List<Pessoa> Hospedes = new List<Pessoa>();

        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTADO
            if (Suite.Capacidade < hospedes.Count)
            {
                throw new Exception("Numero de hóspedes excede a capacidade.");
            }
            else
            {
                //IMPLEMENTADO
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                Hospedes = hospedes;
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTADO
           
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTADO
            decimal valor = DiasReservados * Suite.ValorDiaria;


            // *IMPLEMENTADO
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor = Suite.ValorDiaria * 100 / 10 - Suite.ValorDiaria;
            }

            return valor;
        }
    }
}

