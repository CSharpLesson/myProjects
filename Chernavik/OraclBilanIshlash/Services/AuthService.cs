using OraclBilanIshlash.Db;
using OraclBilanIshlash.Interfaces;
using OraclBilanIshlash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclBilanIshlash.Services
{
    public class AuthService : IAuthService
    {
        private readonly OracleDataContext _dataContext;

        public AuthService(OracleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<AuthRoles> GetAll()
        {
            var entity = _dataContext.AuthRoles.ToList();
            return entity;
        }
    }
}
