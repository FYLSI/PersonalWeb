function PostAjax(url,data,fn) {
    $.ajax({
        url: url,
        type: "Post",
        data: data,
        success: function (res) {
            fn(res);
        },
        error: function () {
            alert("请求出错");
        }
    });
}
