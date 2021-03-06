//***CODE BEHIND - BY RODOLFO.FONSECA***//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodeBehind.SqlServer.Models;
using CodeBehind.SqlServer.Repository;
using Microsoft.Extensions.Logging;

namespace CodeBehind.SqlServer.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ILogger<DeleteModel> _logger;

        private readonly IClienteRepository _rep;
        public string Mensagem { get; set; }
        public DeleteModel(ILogger<DeleteModel> logger)
        {
            _logger = logger;
            _rep = new ClienteRepository();
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
