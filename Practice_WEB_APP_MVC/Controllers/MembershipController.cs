using Microsoft.AspNetCore.Mvc;
using NetCore.Data.ViewModels;
using NetCore.Services.Interfaces;
using NetCore.Services.Svcs;
using Practice_WEB_APP_MVC.Models;

namespace Practice_WEB_APP_MVC.Controllers
{
    public class MembershipController : Controller
    {
        // 의존성 주입 - 생성자
        private IUser _user;

        public MembershipController(IUser user)
        {
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginInfo login)
        {
            String message = string.Empty;

            // ValidateAntiForgeryToken -> 위조방지 토큰을 통해 View로부터 받은 Post data가 유효한지 검증 -> 기본적으로 post를 호출하면 해당 attribute 사용
            if (ModelState.IsValid)
            {

                // 서비스 개념
                // 1.서비스의 재사용성
                // 2. 모듈화를 통한효율적 관리
                if (_user.MatchTheUserInfo(login))
                {
                    TempData["Message"] = "로그인이 성공적으로 이루어졌습니다.";
                    return RedirectToAction("Index", "Membership");
                }
                else
                {
                    message = "로그인에 실패했습니다.";
                }

            }
            else
            {
                message = "로그인정보를 올바르게 입력하세요.";
            }

            ModelState.AddModelError(string.Empty, message);
            return View(login);
        }
    }
}
