$(document).ready(function() {
  // This file just does a GET request to figure out which user is logged in
  // and updates the HTML on the page
  $.get("/api/users_profile").then(function(data) {
    $(".member-name").text(data.email);
    $("#playerName").append(" " + data.firstName);
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

