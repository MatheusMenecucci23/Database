//***CODE BEHIND - BY RODOLFO.FONSECA***//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodeBehind.Maria.Models;
using CodeBehind.Maria.Repository;
using Microsoft.Extensions.Logging;

namespace CodeBehind.Maria.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> _logger;

        private readonly IClienteRepository _rep;
        public string Mensagem { get; set; }
        public DeleteModel(ILogger<DeleteModel> logger, IClienteRepository rep)
        {
            _logger = logger;
            _rep = rep;
        }

        public IActionResult OnGet(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                _rep.Excluir(id);
                Mensagem = "Sucesso";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Create");
                Mensagem = "Falha";
            }
            return RedirectToPage("Index");
        }
    }
}
