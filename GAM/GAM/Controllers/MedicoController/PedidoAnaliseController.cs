﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GAM.Data;
using GAM.Models.MedicoViewModels;
using GAM.Models.Enums;
using Microsoft.AspNetCore.Authorization;
using GAM.Security;
using Microsoft.AspNetCore.DataProtection;

namespace GAM.Controllers.MedicoController
{
    [Authorize(Roles = "Medico")]
    public class PedidoAnaliseController : Controller
    {
        private readonly ApplicationDbContext _context;
        private EncryptorDador _encryptor;

        public PedidoAnaliseController(ApplicationDbContext context, IDataProtectionProvider provider)
        {
            _context = context;
            _encryptor = new EncryptorDador(provider);
        }

        // GET: ResultadoAnalises
        public IActionResult Index()
        {
            var allDadores = _encryptor.DecryptDataList(_context.Dador.ToList());
            ICollection<PedidoAnaliseViewModel> listDadoresAmostrasPendentes = new List<PedidoAnaliseViewModel>();

            foreach (var d in allDadores)
            {
                var amostraDadorPendente = _context.Amostra
                    .Where(a => a.DadorId == d.DadorId)
                    .Where(a => a.EstadoAmostra == EstadoAmostraEnum.PorAnalisar)
                    .Where(a => a.TipoAmostra == TipoAmostraEnum.Sangue)
                    .Select(s => new PedidoAnaliseViewModel { NomeDador = d.Nome, AmostraId = s.AmostraId, EstadoAmostra = s.EstadoAmostra})
                    .FirstOrDefault();

                if (amostraDadorPendente != null)
                {
                    listDadoresAmostrasPendentes.Add(amostraDadorPendente);
                }
            }

            return View(listDadoresAmostrasPendentes);
        }

        // GET: ResultadoAnalises/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resultadoAnalise = await _context.ResultadoAnalise.SingleOrDefaultAsync(m => m.ResultadoAnaliseId == id);
            if (resultadoAnalise == null)
            {
                return NotFound();
            }
            return View(resultadoAnalise);
        } 

        private bool ResultadoAnaliseExists(int id)
        {
            return _context.ResultadoAnalise.Any(e => e.ResultadoAnaliseId == id);
        }
    }
}
