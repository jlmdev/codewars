function sumCubes(n){
  var sum = 0;
  for (var i = 1; i <= n; i++){
    sum += i ** 3;
  }
  return sum;
}
