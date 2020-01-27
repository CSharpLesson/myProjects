using Postgres.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Postgres.Service
{
    public class AptekaService : IApteka
    {
        private DataContext _apteka;

        public AptekaService(DataContext apteka)
        {
            _apteka = apteka;
        }

        public  List<Apteka>  GetAll()
        {
            return _apteka.Aptekas.ToList();
        }

        public Apteka GetById(int Id)
        {
            return _apteka.Aptekas.Where(x=>x.Id==Id).FirstOrDefault();
        }

        public void Insert(Apteka apteka)
        {
            _apteka.Aptekas.Add(apteka);
            _apteka.SaveChanges();
        }

        public void Remove(Apteka apteka)
        {
            _apteka.Aptekas.Remove(apteka);
            _apteka.SaveChanges();
        }

        public void Update(Apteka apteka)
        {
            _apteka.Aptekas.Update(apteka);
            _apteka.SaveChanges();
        }
    }
}
