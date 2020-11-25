function squareSum(numbers){
  var sum = 0;
  for (index in numbers) {
    sum += (numbers[index] ** 2);
  }
  return sum;
}
