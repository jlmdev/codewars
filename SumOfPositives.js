function positiveSum(arr) {
  const positives = arr.filter(number => number >= 0)
  const sumOfPositives = positives.reduce((total, number) => total + number, 0)
  return sumOfPositives
}
