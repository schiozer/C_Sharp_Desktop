using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class ItemNotaDeEntrada
    {
        public Produto Produto { get; set; }
        public double PrecoCustoCompra { get; set; }
        public int QuantidadeComprada { get; set; }

        protected bool Equals(ItemNotaDeEntrada other)
        {
            return Produto.Id.Equals(other.Produto.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(ItemNotaDeEntrada))
                return false;

            return Equals((ItemNotaDeEntrada)obj);
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}