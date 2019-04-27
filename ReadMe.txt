Project: PathWithMaxSumFinder

Description: 
This project is to to find the path that provides the maximum possible sum of the numbers in the given triangle input as per the rules given below: 
	1. Starting from the top and move downwards to the last possible node.  
	2. Changing between even and odd numbers subsequently.
	3. Must reach to the bottom of the pyramid

PlaceHolder for Input File:
	$"C:\FileToRead\Input.txt"

Algorithm ShortDescription:
The solution is with below approach using dynamic programming.
	Convert input data into array.
	Each Parent node will have two child node - One immediate child and the other one on the right.
	Traverse through array from top node to find the path according to criteria 2 by validating even odd condition and calulate sum.
	Create new array with the sorted data.
	Traverse from top to bottom in the new array to find the maximum sum.


