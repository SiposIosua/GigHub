//This is a Client-Side Controller
/*The controller should only be responsible for handling events raised
    from the view and update in the view*/

var GigsController = function (attendanceService) {
    var button;

    var done = function () {
        var text = (button.text() === "Going") ? "Going?" : "Going";
        button.toggleClass("btn-info").toggleClass("btn-default").text(text);
    }

    var fail = function () {
        alert("something failed!");
    }

    var toggleAttendence = function (e) {
        button = $(e.target);

        var gigId = button.attr("data-gig-id");

        if (button.hasClass("btn-default"))
            attendanceService.createAttendance(gigId, done, fail);
        else
            attendanceService.deleteAttendance(gigId, done, fail);
    }

    var init = function (container) {
        // for futre like facebook, Twitter, Instagram
        $(container).on("click", ".js-toggle-attendance", toggleAttendence);
        //$(".js-toggle-attendance").click(toggleAttendence);
    };

    return {
        init: init
    }
}(AttendanceService);