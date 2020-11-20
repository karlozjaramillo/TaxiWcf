using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TaxiWcf.Models;

namespace TaxiWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioConductor" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioConductor.svc o ServicioConductor.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioConductor : IServicioConductor
    {
        private TaxiWebEntities db = new TaxiWebEntities();

        public void AgregarConductor(Conductor conductor)
        {
            db.Conductor.Add(conductor);
            db.SaveChanges();
        }

        public void EditarConductor(Conductor conductor)
        {
            db.Entry(conductor).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void EliminarConductor(long id)
        {
            Conductor conductor = db.Conductor.Find(id);
            db.Conductor.Remove(conductor);
            db.SaveChanges();
        }

        public List<Conductor> ListarConductores()
        {
            return db.Conductor.ToList();
        }
    }
}
