using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTApplication
{
    public class MainClass
    {
        static void Main(string[] args)
        {

            var header = new Header()
            {
                Alg = "HS256",
                Type = "JWT"
            };

            var claims = new Dictionary<string, string>();
            claims.Add("isAdmin", "false");
            claims.Add("sub", "User Login");

            var payload = new Payload() {Claims = claims };

            var jwtToken = JWTCreateClass.GenerateToken(header, payload, "subscribe");
        
        }
    }
}
