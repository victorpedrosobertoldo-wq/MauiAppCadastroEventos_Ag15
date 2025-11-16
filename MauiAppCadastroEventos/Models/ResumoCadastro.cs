using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppCadastroEventos.Models
{


    public class ResumoCadastro
    {
        public Locais Localselecionado { get; set; }

        public string Nome { get; set; }
        public int QtdPessoas { get; set; }

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public int Estadia
        {
            get => DataFinal.Subtract(DataInicial).Days;

        }    

        public double ValorTotal
        {
            get
            {
                double ValorPessoas = QtdPessoas * Localselecionado.preco;

                double Total = ValorPessoas * Estadia;
                return Total;
            }
        }
    }
}
