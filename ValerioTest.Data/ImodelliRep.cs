using System;
using System.Collections.Generic;
using System.Text;
using ValerioTest.Models;

namespace ValerioTest.Data
{
    public interface ImodelliRep : IntRepBase<Modelli>
    {
        IEnumerable<Modelli> GetByCategory(int categoryID);
    }
}
