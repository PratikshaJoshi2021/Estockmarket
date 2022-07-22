using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstockMarket.ViewModels;

namespace EstockMarket.Interfaces
{
    public interface IJWTManagerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);
    }
}
