using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Model;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private List<MemberDto> members = new MemberData().datas;

        [HttpPost("Login")]
        public IActionResult Login(LoginDto param)
        {
            var member = members.FirstOrDefault(x => x.account == param.account && x.password == param.password);
            if (member == null)
            {
                return NotFound("±b¸¹©Î±K½X¿ù»~");
            }
            return Ok(member);
        }

    }
}