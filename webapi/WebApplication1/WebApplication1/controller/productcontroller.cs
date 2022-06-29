using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.viewmodel;
using System.Data;

    namespace WebApplication1.controller
    {
    [Route("api/[controller]")]
    [ApiController]
    public class productcontroller : ControllerBase
    {
        EcomContext db;
        public productcontroller(EcomContext _db)
        {
            db = _db;
        }
        [HttpGet]
        //public void<ProductDetail> GetProducts()
        //{
        //  return db.ProductDetails;


        //}


        public void Register(product product)
        {
        }



    }

}
    
