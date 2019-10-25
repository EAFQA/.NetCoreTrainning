using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (Preco == 0)
            {
                AdicionarCritica("Favor inserir um produto com valor > 0");
            }
        }
    }
}
