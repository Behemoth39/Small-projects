const app = {
  num1: document.getElementById("num1"),
  num2: document.getElementById("num2"),
  menuBtn: document.getElementById("menu"),
  calcBtn: document.getElementById("calc"),
  out: document.getElementById("out"),
  box: document.getElementsByClassName("box"),
};

function operation() {
  let operation = app.box.value;
  switch (operation) {
    case "add":
      result = app.num1.value + app.num2.value;
      break;
    case "sub":
      result = app.num1.value - app.num2.value;
      break;
    case "div":
      result = app.num1.value / app.num2.value;
      break;
    case "mult":
      result = app.num1.value * app.num2.value;
      break;
    default:
      result = "No";
      break;
  }
  app.out.innerHTML = result;
}

app.calcBtn.addEventListener("click", (e) => {
  e.preventDefault;
  operation();
});
