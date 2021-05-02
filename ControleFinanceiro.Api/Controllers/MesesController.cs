﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFinanceiro.Entities.Models;
using ControleFinanceiro.Infra.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesesController : ControllerBase
    {
        private readonly IMesRepositorio _mesRepositorio;

        public MesesController(IMesRepositorio mesRepositorio)
        {
            _mesRepositorio = mesRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mes>>> GetMeses()
        {
            return await _mesRepositorio.PegarTodos().ToListAsync();
        }
    }
}
