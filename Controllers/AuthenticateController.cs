using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RailTimesApi.Data;
using RailTimesApi.LoginModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace RailTimesApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthenticateController : Controller
    {
        private UserManager<ApplicationUser> userManager;

        public AuthenticateController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            if (model != null) {
                var user = await userManager.FindByNameAsync(model.Username);
                if(user != null && await userManager.CheckPasswordAsync(user, model.Password))
                {

                    var authClaims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("secret key for noahs super awesome project"));

                    var token = new JwtSecurityToken(
                        issuer: "willthiswork",
                        audience: "willthiswork",
                        expires: DateTime.Now.AddHours(3),
                        claims: authClaims,
                        signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                        );

                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                    });
                }
                else {
                    Console.WriteLine("User not found");
                }
            }
            return Unauthorized();
        }
    }
}