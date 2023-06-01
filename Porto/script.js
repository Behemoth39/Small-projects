const app = {
  calc: document.querySelector("input"),
  output: document.getElementById("output"),
};

document.getElementById("btn").addEventListener("click", (e) => {
  e.preventDefault;
  app.output.textContent = null;
  if (app.calc.value <= 50) {
    app.output.textContent += "13,00";
  } else if (app.calc.value <= 100) {
    app.output.textContent += "26,00";
  } else if (app.calc.value <= 250) {
    app.output.textContent += "52,00";
  } else if (app.calc.value <= 500) {
    app.output.textContent += "78,00";
  } else if (app.calc.value <= 1000) {
    app.output.textContent += "91,00";
  } else if (app.calc.value <= 2000) {
    app.output.textContent += "104,00";
  } else {
    app.output.textContent += "Endast paket under 2000g";
  }
});
