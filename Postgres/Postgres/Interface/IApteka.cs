using System;
using System.Collections.Generic;
using System.Text;

namespace Postgres.Interface
{
    public interface IApteka
    {
         List<Apteka>  GetAll();
        Apteka GetById(int id);        
        void Remove(Apteka apteka);
        void Insert(Apteka apteka);
        void Update(Apteka apteka);

    }
}
