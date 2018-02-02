/* 鼠标点击特效 */
var a_idx = 0;
jQuery(document).ready(function ($) {
    $("body").click(function (e) {
        //                    var a = new Array("富强", "民主", "文明", "和谐", "自由", "平等", "公正", "法治", "爱国", "敬业", "诚信", "友善");
        var a = new Array("黄一毛", "黄二毛", "黄三毛", "黄四毛", "黄五毛", "黄六毛", "黄七毛", "黄八毛", "黄九毛", "黄十毛", "黄十一毛", "黄十二毛");
        var $i = $("<span></span>").text(a[a_idx]);
        a_idx = (a_idx + 1) % a.length;
        var x = e.pageX,
            y = e.pageY;
        $i.css({
            "z-index": 9999999999999999999999,
            "top": y - 20,
            "left": x,
            "position": "absolute",
            "font-weight": "bold",
            "color": "#ff6651"
        });
        $("body").append($i);
        $i.animate({
            "top": y - 180,
            "opacity": 0
        },
            1500,
            function () {
                $i.remove();
            });
    });
});