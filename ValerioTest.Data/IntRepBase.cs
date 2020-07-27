using System;
using System.Collections.Generic;
using System.Text;

namespace ValerioTest.Data
{
    public interface IntRepBase<TModel> : IntRepBase<TModel, int>  
    {

    }
    public interface IntRepBase<TModel, TKey>     //classi generiche
    {

        IEnumerable<TModel> GetAll();

        TModel GetById(TKey id);

        void Insert(TModel value);

        void Update(TModel value);

        void Delete(TKey id);

    }
}
