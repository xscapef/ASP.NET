﻿using Arquitetura.Dominio.Aggregates.Enums;
using Arquitetura.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.DTO
{
    public class SocioListDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public eSexo? Sexo { get; set; }
        public eEstadoCivil? EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
