# CodeTest_i2Testing
Welcome to te Code test made for i2 Testing created by Bruce Devlin.

## This challenge that was set:
"provide code that iterates in multiples of A until X, then in multiples of A + 1 until 2X, then multiples of A + 2 until 3X" I had 1 hour to complete this challenge.

## A better understanding of the problem:
"The code should allow for the input of 2 numbers, Value 1 (A) and Value 2 (X). My interptritation of the issue is that
the code must take Value 1 and multiply it by itself until the number reaches Value 2 then, it will multiply Value 1 plus 1 
until 2 followed by Value 2 and finally Value 1 plus 2 until 3 followed by Value 2.

To do this I will iterate using a for loop multiplying Value 1 (initialValue) until it reaches Value 2 (maxValue), then I will repeat this loop 
for handling the addition.

My code will sometimes exceed Value 2 as it gets to the closest value to X.

The application also accepts arguments to multiply the values (seperated by a space).


# Notes after completing
- There is a flaw in loop 2 & 3 when the code is appending the number before values. This could be fixed fairly easily but, 
unfortunately I ran out of time.
- I have dyscalculia and so I found this code test to be quite challenging but I didn't let  this stop me for doing my best to
understand and solve the problem.
- After thinking on it more, I would change the "var"s in the MultiplyNumbers methods to "int"s to improve readability, I made
these "var"s to make this method slightly more dynamic but this was unnecessary since the values are always "int"s.
- Annoyingly I miss-typed "2i Testing" as "i2 Testing".
