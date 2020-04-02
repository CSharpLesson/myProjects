using OraclBilanIshlash.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraclBilanIshlash.Interfaces
{
    public interface IAuthService
    {
        List<AuthRoles> GetAll();
    }
}
