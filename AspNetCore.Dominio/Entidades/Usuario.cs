using System.Collections;
using System.Collections.Generic;

namespace AspNetCore.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Crítica. Email não foi informado.");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Crítica. Email não foi informado.");
            }
        }
    }
}
