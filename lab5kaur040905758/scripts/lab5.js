
//Lab5 - Working with the Document Object Model

var mainTitle = document.getElementById("mainTitle");
var newText = "Learning about the Document Object Modal";
mainTitle.innerHTML=newText;

mainTitle.style.textAlign = "center";

var image = document.getElementById('image1');
var newTitle = "JavaScript 1";
image.title = newTitle;

image1.setAttribute("align", "right");

var newItem =document.createElement("li");
var newText1 = document.createTextNode("1.1 August 1996");
newItem.appendChild(newText1);
var changedList = document.getElementById("list");
changedList.insertBefore(newItem, changedList.children[1]);


var newItem2 = document.createElement("li");
var newText2 = document.createTextNode("1.8.2 June 22,2009");
newItem2.appendChild(newText2);
var changedList2 = document.getElementById("list");
changedList2.insertBefore(newItem2, changedList2.children[8]);

var oldText = document.getElementById("list").children[5];
oldText.innerHTML = "1.6 November 2005";

document.write("This web page contains 9 li tags.");
