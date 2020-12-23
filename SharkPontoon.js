function shark(pontoonDistance, sharkDistance, youSpeed, sharkSpeed, dolphin){
  const youSwim = pontoonDistance / youSpeed;
  var sharkSwim = 0;
  if (dolphin) {
    var sharkSwim = sharkDistance / (sharkSpeed / 2);
  } else {
    var sharkSwim = sharkDistance / sharkSpeed;
  }
  if (youSwim < sharkSwim) {
    return "Alive!";
  } 
  return "Shark Bait!";
}
