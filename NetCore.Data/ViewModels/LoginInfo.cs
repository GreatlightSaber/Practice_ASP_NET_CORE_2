using System.ComponentModel.DataAnnotations;

namespace NetCore.Data.ViewModels

{
    public class LoginInfo
    {
        [Required(ErrorMessage ="사용자 ID를 입력하세요")]
        [MinLength(6, ErrorMessage ="사용자 ID는 최소 6글자 이상입니다.")]
        [Display(Name = "사용자 ID")]
        public String UserId{ get; set; }

        [Required(ErrorMessage = "비밀번호를 입력하세요")]
        [MinLength(6, ErrorMessage = "비밀번호는 최소 6글자 이상입니다.")]
        [Display(Name = "비밀번호")]
        public String Password { get; set; }

    }
}
