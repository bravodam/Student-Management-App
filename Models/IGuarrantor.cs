using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code360NEWWEB.Models
{
    public interface IGuarrantor
    {
        Guarrantor GetGuarrantor(int Id);
        IEnumerable<Guarrantor> GetAllGuarrantor();
        Guarrantor Add(Guarrantor guarrantor);
        Guarrantor Update(Guarrantor guarrantorChanges);
        Guarrantor Delete(int Id);
    }
}
