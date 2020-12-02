function enough(cap, on, wait) {
  // Calculate the capcity of the bus compared to the current load and waiting load
  //   If the available space is sufficient, return 0
  // Otherwise return the number of remaining riders
  if (cap - on >= wait) {
    return 0;
  } else {
    return wait - (cap - on);
  }
  
}
