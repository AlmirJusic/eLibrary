using AutoMapper;
using eLibrary.Model;
using eLibrary.Database;
using eLibrary.Model.Requests.Korisnik;
using eLibrary.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace eLibrary.Services.Services
{
    public class KorisnikService : IKorisnikService
    {

        private readonly eLibraryContext db;
        private readonly IMapper mapper;

        public KorisnikService(eLibraryContext _db, IMapper map)
        {
            db = _db;
            mapper = map;

        }


        public List<Model.Korisnik> Get(KorisnikSearchRequest search)
        {
            var query = db.Korisnik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().Contains(search.Ime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().Contains(search.Prezime.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                query = query.Where(x => x.Username.ToLower().Contains(search.Username.ToLower()));
            }


            var list = query.ToList();
            return mapper.Map<List<eLibrary.Model.Korisnik>>(list);


        }
        public Model.Korisnik GetbyId(int id)
        {
            var k = db.Korisnik.Find(id);

            return mapper.Map<eLibrary.Model.Korisnik>(k);
        }


        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return System.Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = System.Convert.FromBase64String(salt);
            byte[] bytes = System.Text.Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA512");
            byte[] inArray = algorithm.ComputeHash(dst);
            return System.Convert.ToBase64String(inArray);
        }

        public Model.Korisnik Authenticiraj(string username, string password)
        {
            var user = db.Korisnik.Include(x=>x.Uloga).Include(x => x.Grad.Drzava).FirstOrDefault(x => x.Username == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);

                if (newHash == user.PasswordHash)
                {
                    return mapper.Map<eLibrary.Model.Korisnik>(user);
                }
            }
            return null;
        }


        //***************************************//
        public Model.Korisnik Insert(KorisnikInsertRequest request)
        {


            var k = mapper.Map<eLibrary.Database.Models.Korisnik>(request);


            db.Add(k);


            if (request.PasswordHash != request.PasswordConfirm)
            {
                throw new System.Exception("Lozinka i potvrda se ne slažu");
            }

            k.PasswordSalt = GenerateSalt();
            k.PasswordHash = GenerateHash(k.PasswordSalt, k.PasswordHash);

            db.SaveChanges();




            return mapper.Map<eLibrary.Model.Korisnik>(k);
        }



        //***************************************//

        public Model.Korisnik Update(int id, KorisnikUpdateRequest request)
        {
            var k = db.Korisnik.Find(id);

            k.Ime = request.Ime;
            k.Username = request.Username;
            k.Prezime = request.Prezime;
            k.Spol_ID = request.Spol_ID;
            k.Grad_ID = request.Grad_ID;
            k.Uloga_ID = request.Uloga_ID;
            k.Email = request.Email;
            k.DatumRodjenja = request.DatumRodjenja;
            


            db.SaveChanges();
            return mapper.Map<eLibrary.Model.Korisnik>(k);

        }

        public bool Remove(int id)
        {
            var entity = db.Korisnik.Find(id);
            if (entity != null)
            {
                db.Korisnik.Remove(entity);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        
    }



}

