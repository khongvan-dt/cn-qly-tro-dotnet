using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using quanLyTro.Data;
using quanLyTro.Models;

namespace quanLyTro.Controllers
{
    [ApiController]
    [EnableCors()]
    [Route("api/[controller]")]
    public class UserController : Repository<User>
    {
        public UserController(DataContext dc) : base(dc)
        {

        }
    }
}
