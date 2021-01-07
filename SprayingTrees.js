function task(w, n, c) {
  var worker = '';
  var totalCost = n * c;

  switch (w) {
    case 'Monday':
      worker = 'James';
      break;
    case 'Tuesday':
      worker = 'John';
      break;
    case 'Wednesday':
      worker = 'Robert';
      break;
    case 'Thursday':
      worker = 'Michael';
      break;
    case 'Friday':
      worker = 'William';
      break;
    default:
      worker = 'No One';
      break;
  }

  return `It is ${w} today, ${worker}, you have to work, you must spray ${n} trees and you need ${totalCost} dollars to buy liquid`
}
