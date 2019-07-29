$(document).ready(function () {
  // This file just does a GET request to figure out which user is logged in
  // and updates the HTML on the page
  $.get("/api/users_profile").then(function(data) {
    var userID = data.id;
    // set variable to be updated from db
    var timesPlayed = data.numberOfPlays;
    console.log("Original plays: " + timesPlayed);
    // if this is their first time playing
    if (timesPlayed === 0) {
      // Special message if they haven't played
      $("#playerName").append(
        "Show Us What You Can Do " + data.firstName + "!"
      );
    } else {
      // display their name
      $("#playerName").append("Welcome back, " + data.firstName + "!");
      // display how many times they have played
      $("#timesPlayed").append("You have played " + timesPlayed + " times!");
    }
    // when user clicks play button
    $(".playCount").click(function() {
      // add one to times played
      var newPlays = timesPlayed + 1;
      console.log("New play total: " + newPlays);
      // send new total to update plays function
      updatePlays(newPlays);
    });
  });
  // update play count in db
  function updatePlays(numberOfPlays) {
    $.ajax({
      method: "PUT",
      url: "/api/plays",
      data: {
        nop: numberOfPlays
      }
    }).done(function(response){
      // reload cache
      reloadCache();
      // navigate to game page
      navigateToPage();
    });
  }
  function navigateToPage() {
    location.href = "/play";
  }
  // reload cache
  function reloadCache() {
    location.reload(true);
  }
  // user delete account option
});
