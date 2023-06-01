const app={
  animals: ['Cat', 'Dog', 'Bird', 'Whale', 'Snake'],  
};

const para = document.createElement("div");
para.innerHTML = "This is a paragraph.";
document.body.appendChild(para);

document.body.insertAdjacentHTML("beforeend", (app.animals.join(' ')));
