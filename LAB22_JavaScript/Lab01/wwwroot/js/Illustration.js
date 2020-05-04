let footerNode = document.getElementsByTagName('footer')[0];
let newHtml = "<p>This page was last modified on: " + document.lastModified + "</p>";
footerNode.innerHTML += newHtml;