# FooBarQix Kata

## Rules

### Step 1
Write a program that prints numbers from 1 to 100, one number per line. For each printed number, use the following rules:

1. if the number is divisible by 3 or contains 3, replace 3 by "Foo";
2. if the number is divisible by 5 or contains 5, replace 5 by "Bar";
3. if the number is devisible by 7 or contains 7, replace 7 by "Qix".

Example:
	1
	2
	FooFoo
	4
	BarBar
	Foo
	QixQix
	8
	Foo
	Bar

More details:
- divisors have high precedence, ex: 51 -> FooBar
- the content is analysed in the order they appear, ex: 53 -> BarFoo
- 13 contains 3 so we print "Foo"
- 15 is divisible by 3 and 5 and contains 5, so we print “FooBarBar”
- 33 contains 3 two times and is divisible by 3, so we print “FooFooFoo”

### Step 2
We have a new business request : we must keep a trace of 0 in numbers, each 0 must be replace par char “*“.

## Why C#.NET 
I choosed C#.NET because I would like to improve my skills in this language. 

# How to run and running the tests
Open the solution 'FooBarQix.sln' with Visual Studio and run 'FooBarQix.cs'.