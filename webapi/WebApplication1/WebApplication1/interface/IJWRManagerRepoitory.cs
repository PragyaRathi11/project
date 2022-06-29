//namespace WebApplication1.internal interface
//{
    //public class IJWRManagerRepoitory
//{
//}
//}



//using WebApplication1_Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace WebApplication1.internal.interface
namespace WebApplication1.internal interface{ 
}
    public interface IJWTMangerRepository
    {
    Tokens Authenicate(loginviewmodel user, bool IsRegister);
    }
}
