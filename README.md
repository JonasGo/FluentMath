FluentMath
==========

Just some experiments with readable math library calls. 
All functions are implemented just for fun and are not 100% correct or optimized for performance. Handle with care.

I'm following the problems on http://projecteuler.net/ and develop the functions when I need them.
So, right now it's very basic!
Everything is developed test driven.

Maybe someday, we will have a fluently usable math library 


Small example:
The first problem is pretty simple.
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
[http://projecteuler.net/problem=1]

The function call should be simple too:
FluentMath.SumOf(FluentMath.MultiplesOf(3).Or(5).Below(1000))

I'm still not completely happy with that, but it's a work in progress ;)