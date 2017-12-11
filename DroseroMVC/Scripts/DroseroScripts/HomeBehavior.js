var foodIndex = 0;
var loungeIndex = 0;
carouselFood();
carouselLounge();

function carouselFood() {
    var i;
    var x = document.getElementsByClassName("homeFoodSlides");
    for (i = 0; i < x.length; i++) {
       x[i].style.display = "none";  
    }
  foodIndex++;
  if (foodIndex > x.length) { foodIndex = 1}    
  x[foodIndex-1].style.display = "block";  
    setTimeout(carouselFood, 2500); // Change image every 2 seconds
}

function carouselLounge() {
  var i;
  var x = document.getElementsByClassName("homeLoungeSlides");
  for (i = 0; i < x.length; i++) {
    x[i].style.display = "none";
  }
  loungeIndex++;
  if (loungeIndex > x.length) { loungeIndex = 1 }
  x[loungeIndex - 1].style.display = "block";
  setTimeout(carouselLounge, 2500); // Change image every 2 seconds
}