function solution(str){
  var array = str.split("");
  var reverseArray = array.reverse();
  var reverseString = reverseArray.join("");
  return reverseString;
}
