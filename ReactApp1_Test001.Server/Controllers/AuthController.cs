//using Microsoft.AspNetCore.Mvc;
////using SUSWebApp.Models;

//namespace SUSWebApp.Controllers;

//[ApiController]
//[Route("api/[controller]")]
//public class AuthController : ControllerBase
//{
//    [HttpPost("login")]
//    public IActionResult Login([FromBody] LoginRequest request)
//    {
//        // ���͊ȒP�ȉ��̔F�؃��W�b�N���������܂�
//        if (request.EmployeeNo == "user" && request.Password == "password")
//        {
//            // �F�ؐ���
//            return Ok(new { message = "���O�C���ɐ������܂���" });
//        }
//        else
//        {
//            // �F�؎��s
//            return Unauthorized(new { message = "�Ј��ԍ��܂��̓p�X���[�h������������܂���" });
//        }
//    }
//}

//public class LoginRequest
//{
//    public string EmployeeNo { get; set; }
//    public string Password { get; set; }
//}
