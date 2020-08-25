using System;
using System.Collections.Generic;
using System.Linq;

public class Kata 
{
    public static int FindSmallestInt(int[] args) 
    {
      int smallest = args.Min();
      return smallest;
    }
}

// PEDAC
// Input: an array of integers (args)
// Work: Find and return the smallest integer in the array
// Output: smallest Integer in the array


// Examples:
// 34,15,88,2 => 2
// 34,-345,-1,100 => -345

// Data Structures
//
// args: (input integer array)
// smallest: (return integer smallest intger

// Algorithm
// int smallest = args.Min()
// return smallest
