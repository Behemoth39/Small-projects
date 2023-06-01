let toggle = false;
let image = new Image();
image.onload = function () {
  document.getElementById("1").setAttribute("src", this.src);
};
image.src = "sun.jpg";

document.getElementById("1").addEventListener("click", (e) => {
  e.preventDefault;
  if (toggle === true) {
    image.src = "moon.jpg";
  } else {
    image.src = "sun.jpg";
  }
  toggle = !toggle;
});
