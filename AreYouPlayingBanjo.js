function areYouPlayingBanjo(name) {
  var nameArray = name.split('');
  if (nameArray[0].toLowerCase() === 'r') {
    return `${name} plays banjo`;
  } else {
  return `${name} does not play banjo`;
  }
}
