//Login
function Login() {
    var Username = $("#txtUsername").val();
    var Password = $("#txtPassword").val();
    $.ajax({
        url: "/Login/Login",
        data:{  Username: Username, Password: Password},
        success: function (result) {
            if (result == 1) {
               // alert("ddd");
                window.location = "/Home/DashBoard";
            }
            else {
                alert("Xem lại Tài khoản hoặc mật khẩu!");
            }

        }
    });
}


