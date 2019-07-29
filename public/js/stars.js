addEventListener('resize', addStars);

function addStars() {
  document.getElementById("container").innerHTML = '';

  let width = window.innerWidth;
  let height = window.innerHeight;

  for (i = 0; i < 200; i++) {
    let randomSize = Math.floor(Math.random() * (6) + 1);
    let randomTop = Math.floor(Math.random() * (height) + 1);
    let randomLeft = Math.floor(Math.random() * (width) + 1);
    let randomOpacity = (Math.floor(Math.random() * (10) + 5) / 10);
    let randomDuration = (Math.floor(Math.random() * (20) + 5) / 10);
    let randomColor = Math.floor(Math.random() * (360) + 1);
    let revOrNot = Math.floor(Math.random() * (2) + 1);
    let rev = 'normal';
    if (revOrNot == 1) rev = 'reverse';
    // console.log(i); 

    let star = document.createElement("div");
    star.style.cssText = "background-color: hsl(" + randomColor + ",100%,90%); top:" + randomTop + "px; left:" + randomLeft + "px; opacity:" + randomOpacity + "; animation-direction:" + rev + "; width:" + randomSize + "px; height:" + randomSize + "px; animation: pulse linear " + randomDuration + "s infinite " + randomOpacity + "s;";

    document.getElementById("container").appendChild(star);
  };
}
addStars();