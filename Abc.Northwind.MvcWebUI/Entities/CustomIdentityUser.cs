using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Abc.Northwind.MvcWebUI.Entities
{
    public class CustomIdentityUser:IdentityUser
    {
        // burada artık ekstra alanlarımızı koyabiliriz.
    }
}
