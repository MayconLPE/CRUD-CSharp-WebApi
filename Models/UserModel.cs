using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_CSharp_WebApi.Models
{
    public class UserModel
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Email {get; set;}
    }
}