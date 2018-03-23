
var GigDetailsController = function(followingService) {
    var followButton;

    var init = function() {
        $(".js-toggle-follow").click(toggleFollowing);
    };

    var toggleFollowing = function(e) {
        followButton = $(e.target);

        var followeeId = followButton.attr("data-user-id");

        if (followButton.hasClass("btn-default"))
            followingService.createFollowing(followeeId, done, fail);
        else {
            followingService.deleteFollowing(followeeId, done, fail);
        }
    }

    var done = function() {
        var text = (followButton.text === "Following") ? "Follow" : "Following";
        followButton.toggleClass("btn-default").toggleClass("btn-info").Text();
    }

    var fail = function() {
        alert("something failed!");
    }

    return {
        init: init
    }


}();
