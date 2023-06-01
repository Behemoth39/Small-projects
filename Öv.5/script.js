const app = {
  drycker: ["cider", "vatten", "öl", "vin", "whisky", "gin", "vodka", "mjöd"],
};

function getEveryNth(arr, nth) {
  const result = [];

  for (let i = 0; i < arr.length; i += nth) {
    result.push(arr[i]);
  }

  return result;
};

let list = getEveryNth(app.drycker, 2).map((li) => `<li>${li}</li>`).join("\n");
  document.querySelector("ul").innerHTML = list;