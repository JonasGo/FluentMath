# FluentMath
==========

Just some experiments with easy readable math library calls.
All functions are implemented just for fun and are not 100% correct or optimized for performance. 
Handle with care.

## What's the point?
I'm following the problems on http://projecteuler.net/ and develop the functions when I need them.
So right now, it's very basic! Maybe someday, we will have a easy usable math library.

## Show me an example!

The first problem is pretty simple.

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
[http://projecteuler.net/problem=1]

The function call should be simple too:

```csharp
FluentMath.SumOf(FluentMath.MultiplesOf(3).Or(5).Below(1000))
```

I'm still not completely happy with that, but it's a work in progress ;)

## What are the tools?
Everything is developed test driven, test first. Right now only with unit tests.

The language is C# with the .NET 4.5 Framework.

I'm using Microsoft Visual Studio 2012 with ReSharper (can't live without that)