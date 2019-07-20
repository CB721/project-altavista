$(document).ready(function() {
  // This file just does a GET request to figure out which user is logged in
  // and updates the HTML on the page
  $.get("/api/profile").then(function(data) {
    console.log(data);

    var profile = $("<div>");

    profile.addClass("wells");

    $("#populate").append(profile);
    $("#populate").append("<h3>First Name: " + data.firstName + "</h3>");
    $("#populate").append("<h3>Last Name: " + data.lastName + "</h3>");
    $("#populate").append("<h3>email: " + data.email + "</h3>");
    $("#populate").append("<h3>high score: " + data.include[0] + "</h3>");
  });
});
