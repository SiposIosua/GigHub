/*  ***Services***  */
//  these methods are about Data Access, responsible of calling the API
/* we have a clean service that knows nothing about UI and it can be reused 
    across multipe contollers*/

var AttendanceService = function() {
    var createAttendance = function(gigId, done, fail) {
        $.post("/api/attendances", { gigId: gigId })
            .done(done)
            .fail(fail);
    };

    var deleteAttendance = function(gigId, done, fail) {
        $.ajax({
                url: "/api/attendances/" + gigId,
                method: "DELETE"
            })
            .done(done)
            .fail(fail);
    };

    return {
        createAttendance: createAttendance,
        deleteAttendance: deleteAttendance
    }
}();
