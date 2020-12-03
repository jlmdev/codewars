function reverseWords(str) {
  // convert string to array and reverse
  // convert back to string
  const reversed = str.split(' ');
  const backwords = [];
  reversed.forEach(word => {
    var splitWord = word.split('');
    var reverseWord = splitWord.reverse();
    var joinWord = reverseWord.join('');
    backwords.push(joinWord);
  });
  return backwords.join(' ');
}
