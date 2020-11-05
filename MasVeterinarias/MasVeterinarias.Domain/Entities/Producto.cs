﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Domain.Entities
{
    public class Producto : BaseEntity
    {
        public string NombrePproducto { get; set; }
        public string Descripcion { get; set; }

        public string Especie { get; set; }

        public string Raza { get; set; }

        public string Etapa { get; set; }

        public string Categoria { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}