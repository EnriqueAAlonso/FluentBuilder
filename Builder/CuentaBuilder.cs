using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CuentaBuilder
    {
        private readonly Cuenta _cuenta;

        private CuentaBuilder(TipoCuenta t)
        {
            _cuenta = new Cuenta(t);
        }
        public static CuentaBuilder Crear(TipoCuenta t)
        {
            return new CuentaBuilder(t);
        }

        public CuentaBuilder SetSaldo(double sal)
        {
            _cuenta.SetSaldo(sal);
            return this;
        }

        public CuentaBuilder SetTasa(double sal)
        {
            _cuenta.SetTasa(sal);
            return this;
        }
        public CuentaBuilder SetNumero(double sal)
        {
            _cuenta.SetNumero(sal);
            return this;
        }

        public CuentaBuilder SetPropietario(string prop)
        {
            _cuenta.SetPropietario(prop);
            return this;
        }

        public CuentaBuilder SetTipo(TipoCuenta t)
        {
            _cuenta.SetCuenta(t);
            return this;
        }

        public Cuenta Crear()
        {
            return _cuenta;
        }
    }
}
