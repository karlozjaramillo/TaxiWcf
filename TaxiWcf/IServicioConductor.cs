using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TaxiWcf.Models;

namespace TaxiWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioConductor" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioConductor
    {
        [OperationContract]
        void AgregarConductor(Conductor conductor);

        [OperationContract]
        List<Conductor> ListarConductores();

        [OperationContract]
        void EliminarConductor(long id);

        [OperationContract]
        void EditarConductor(Conductor conductor);
    }
}
