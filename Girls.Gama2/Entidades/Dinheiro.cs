using System;

namespace Girls.Gama2.Entidades
{
    public class Dinheiro
    {
        

        public Dinheiro(string cpf,
                        double valor,
                        string descricao,
                        double valorPago)
        {
            Cpf = cpf;
            Valor = valor;
            ValorPago = valorPago;
            Descricao = descricao;
            Data = DateTime.Now;
            Confirmacao = false;
        }

        public double Valor { get; set; }
        public double ValorPago { get; set; }
        public DateTime Data { get; set; }
        public string Cpf { get; set; }
        public string Descricao { get; set; }
        public Boolean Confirmacao { get; set; }

        public void GerarPagamento()
        {
            Confirmacao = true;
        }


   
    }
}
