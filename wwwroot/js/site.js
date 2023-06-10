// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

window.addEventListener("DOMContentLoaded", addCanonical(window.location.href))

function addCanonical(url) {
  let link = document.createElement("link")
  link.setAttribute("rel", "canonical")
  link.href = url
  document.head.appendChild(link)
}

function accordion(button) {
  button.classList.toggle("active")
  var panel = button.nextElementSibling;
  if (panel.style.maxHeight) {
    panel.style.maxHeight = null;
    panel.style.marginTop = null;
  } else {
    panel.style.maxHeight = panel.scrollHeight + "px";
    panel.style.marginTop = "12px";
  }
}
