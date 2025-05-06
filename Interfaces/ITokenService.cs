using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanTracker.Interfaces
{
    public interface ITokenService
    {
        public string CreateToken(Guid userId, string email, string username, int time);

        public Guid VerifyTokenAndGetId(string token);
    }
}