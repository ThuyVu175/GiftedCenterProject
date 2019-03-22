//Login
function Login() {
    var Username = $("#txtUsername").val();
    var Password = $("#txtPassword").val();
    if (Username == null || Password == null) {
        alert("Vui lòng nhập đầy đủ thông tin!");
    }
    $.ajax({
        url: "/Login/Login",
        data:{  Username: Username, Password: Password},
        success: function (result) {
          
            if (result == 0) {
               // alert("ddd");
                window.location = "/Home/DashBoard";
            }
            else {
                alert("Xem lại Tài khoản hoặc mật khẩu!");
            }

        }
    });
}


