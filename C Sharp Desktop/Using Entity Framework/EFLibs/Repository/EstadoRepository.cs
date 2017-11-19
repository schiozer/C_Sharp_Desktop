using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace EFLibs
{
    public class EstadoRepository
    {
        public Estado SaveEstado(Estado estado)
        {
            using (var context = new testesEntitiesDatabase())
            {
                context.Estado.Add(estado);
                context.SaveChanges();
            }
            return estado;
        }

        public IList<Estado> GetEstados()
        {
            using (var context = new testesEntitiesDatabase())
            {
                return context.Estado.ToList<Estado>();
            }
        }
    }
}
