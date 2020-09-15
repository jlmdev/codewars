function find_average(array) {
  let sum = 0
  for (let index = 0; index < array.length; index++) {
    const element = array[index]
    sum += element
  }
  return sum / array.length;
}
