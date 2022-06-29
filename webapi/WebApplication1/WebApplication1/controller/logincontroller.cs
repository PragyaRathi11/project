

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.viewmodel;
using System.Data;
namespace WebApplication1.controller
{

  [Route("api[controller]")]
    [ApiController]

    public class logincontroller : ControllerBase


    {
        //  [HttpGet(Name ="Getloginviewmodel")]
        // public string Post()
        //{
        //  return ;
        //}

        //    }
        //}
        // {
        //  EcomContext db;
        //      private object tbllogin;

        //    public logincontroller(EcomContext _db)
        //  {
        //  db = _db;
        //}

        //[HttpPost]
        //[Route("login")]
        //public bool LoginUser(loginviewmodel loginviewmodel)
        //{
        ///   if (db.Tbllogins.Any(x => x.UserName == loginviewmodel.username && x.Password == loginviewmodel.Password)) 
        //{
        ///  return true;
        //}            
        //return false;
        //}
        //[HttpGet]
        //[Route("register")]
        //public void Register(Registerviewmodel Registerviewmodel)
        //{
        //  Tbllogin tbllogin = new Tbllogin();
        //tbllogin.UserName = Registerviewmodel.userame;
        //tbllogin.Password = Registerviewmodel.password;
        //db.tbllogin.Add(tbllogin);
        //db.SaveChanges();

        EcomContext db;
        IJWTMangerRepository iJWTMangerRepository;
        private object login;

        public logincontroller(Tbllogin _db, iJWTMangerRepository _iJWTMangerRepository)
        {
            db = _db;
            iJWTMangerRepository = _iJWTMangerRepository;
        }

        [HttpGet]
        public IEnumerable<Tbllogin> Get()
        {
            return db.Tbllogin;
        }


        [HttpPost]
        [Route("login")]
        public IActionResult Login(loginviewmodel loginViewModel)
        {
            var token = iJWTMangerRepository.Authenicate(loginViewModel, false);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(Registerviewmodel Registerviewmodel)
        {
            Registerviewmodel = new Registerviewmodel();
            Registerviewmodel.EmailId = Registerviewmodel.EmailId;
            Registerviewmodel.password = Registerviewmodel.password;
            var token = iJWTMangerRepository.Authenicate(login, true);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);

        }
       
    }
}
