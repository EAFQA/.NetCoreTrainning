using AspNetCore.Dominio.Contracts;
using AspNetCore.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio()
        {
        
        }
    }
}
