function firstNonConsecutive (arr) {
  number = arr[0];
  for(index = 1; index <= arr.length; index++) {
    if (arr[index] == arr[index - 1] + 1) {
      continue;
    } else {
      return arr[index];
    }
  }
  return null;
}
