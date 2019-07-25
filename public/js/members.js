$(document).ready(function() {
  // This file just does a GET request to figure out which user is logged in
  // and updates the HTML on the page
  $.get("/api/users_profile").then(function(data) {
    $(".member-name").text(data.email);
    var timesPlayed = data.numberOfPlays;
    // if this is their first time playing
    if (timesPlayed === 0) {
      // Special message if they haven't played
      $("#playerName").append("Show Us What You Can Do " + data.firstName + "!");
    } else {
      // display their name
      $("#playerName").append("Welcome back, " + data.firstName + "!");
      // display how many times they have played
      $("#timesPlayed").append("You have played " + timesPlayed + " times!");
    }
  });

  // This function updates a todo in our database
  // function updateTodo(todo) {
  //   $.ajax({
  //     method: "PUT",
  //     url: "/api/todos",
  //     data: todo
  //   }).then(getTodos);
  // }
});

