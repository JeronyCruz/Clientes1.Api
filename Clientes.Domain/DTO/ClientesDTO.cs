﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Domain.DTO
{
    public class ClientesDTO
    {
        public int ClienteId { get; set; }
        public string? Nombres { get; set; }
        public string? WhatsApp { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

    }
}