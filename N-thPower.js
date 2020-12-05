function index(array, n){
  // Check if array[n] is in the array
  if (n < array.length) {
    // If array[n] is in the array, return array[n] ** n
    return array[n] ** n;
  } else {
    // else return -1
    return -1;
  }
}
