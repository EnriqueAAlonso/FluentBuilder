using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public enum TipoCuenta
    {
        Gold,
        Platinum,
        Black,
        Basic
    };
    public class Cuenta
    {
        private string _propietario;
        private double _numero;
        private double _saldo;
        private double _tasa;
        private TipoCuenta _tipodeCuenta;

        public Cuenta(TipoCuenta t)
        {
            _tipodeCuenta = t;
        }

        public Cuenta()
        {
        }

        public string GetPropietario()
        {
            return _propietario;
        }

        public void SetPropietario(string prop)
        {
            _propietario = prop;
        }
        public double GetNumero()
        {
            return _numero;
        }

        public void SetNumero(double num)
        {
            _numero = num;
        }
        public double GetSaldo()
        {
            return _saldo;
        }

        public void SetSaldo(double sal)
        {
            _saldo = sal;
        }
        public double GetTasa()
        {
            return _tasa;
        }

        public void SetTasa(double num)
        {
            _tasa = num;
        }
        public TipoCuenta GetCuenta()
        {
            return _tipodeCuenta;
        }

        public void SetCuenta(TipoCuenta num)
        {
            _tipodeCuenta = num;
        }

        public override string ToString()
        {
            return
                $"Numero de cuenta  {_numero}/ Propietario {_propietario}/ Tasa {_tasa}/ Saldo Inicial {_saldo} / Tipo de Cuenta {_tipodeCuenta}";
        }



    }
}
