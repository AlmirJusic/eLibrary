
using eLibrary.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace eLibrary.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {

        
      
        public static Model.Korisnik PrijavljeniKlijent;
        private readonly IKorisnikService _klijentservice;

        

        public BasicAuthenticationHandler(
                IOptionsMonitor<AuthenticationSchemeOptions> options,
                ILoggerFactory logger,
                UrlEncoder encoder,
                ISystemClock clock,
                IKorisnikService klijentservice
                )
                : base(options, logger, encoder, clock)
            {

           
            _klijentservice = klijentservice;


        }

            protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
            {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");


            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = System.Text.Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
               
                PrijavljeniKlijent = _klijentservice.Authenticiraj(username, password);
           

            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (PrijavljeniKlijent == null)
                return AuthenticateResult.Fail("Invalid Username or Password");




            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, PrijavljeniKlijent.Username),
                new Claim(ClaimTypes.Name, PrijavljeniKlijent.Ime),



            };



           
                claims.Add(new Claim(ClaimTypes.Role, PrijavljeniKlijent.Uloga.NazivUloge));
            

            //var identity = new ClaimsIdentity(claims, Scheme.Name);
            //    var principal = new ClaimsPrincipal(identity);
            //    var ticket = new AuthenticationTicke

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);

        }
        }


    
}
