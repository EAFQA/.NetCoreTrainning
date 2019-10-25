﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (ProdutoId == 0)
            {
                AdicionarCritica("Não foi identificado qual a referência do produto.");
            }

            if (Quantidade == 0)
            {
                AdicionarCritica("Quantidade não informado.");
            }
        }
    }
}