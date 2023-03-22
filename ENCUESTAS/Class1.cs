using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENCUESTAS
{
    public class Class1
    {
        encuestasEntities db = new encuestasEntities();

        public List<encuestas> Listar()
        {
            var encuestas = from e in db.encuestas
                            select e;
            return encuestas.ToList();
        }

        public List<areas> ListarAreas()
        {
            var areas= from a in db.areas
                       select a;
            return areas.ToList();
        }

        public ENCUESTAS.encuestas Agregar(ENCUESTAS.encuestas item)
        {
            db.encuestas.Add(item);
            db.SaveChanges();
            return item;
        }

    }
}
