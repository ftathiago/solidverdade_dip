using System.Collections.Generic;
using Venda.Crosscutting.Interfaces;
using Venda.Crosscutting.Models;
using Venda.Application.Models;

namespace Venda.Application.App
{
    public interface IVendaApplication : IValidavel
    {
        bool ProcessarVenda(VendaModel vendaModel);
    }
}