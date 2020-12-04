function arrayPlusArray(arr1, arr2) {
  var array1Sum = arr1.reduce((a,b) => a + b, 0);
  var array2sum = arr2.reduce((a,b) => a + b, 0);
  return array1Sum + array2sum; 
}
