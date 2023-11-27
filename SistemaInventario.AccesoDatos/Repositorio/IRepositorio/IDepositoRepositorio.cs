﻿using SistemaInventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRepositorio
{
    public interface IDepositoRepositorio: IRepositorio<Deposito>
    {
        void Actualizar(Deposito deposito);

    }
}