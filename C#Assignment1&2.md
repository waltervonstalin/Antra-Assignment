##### ------------Introduction to C# and Data Types-----------------

1\. What type would you choose for the following “numbers”?

&nbsp;	A person’s telephone number

&nbsp;	String



&nbsp;	A person’s height

&nbsp;	Float



&nbsp;	A person’s age

&nbsp;	Int


	A person’s gender (Male, Female, Prefer Not To Answer)

&nbsp;	String



&nbsp;	A person’s salary

&nbsp;	Float



&nbsp;	A book’s ISBN

&nbsp;	String



&nbsp;	A book’s price

&nbsp;	Float



&nbsp;	A book’s shipping weight

&nbsp;	Float



&nbsp;	A country’s population

&nbsp;	Long



&nbsp;	The number of stars in the universe

&nbsp;	Array of Int



&nbsp;	The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)

&nbsp;	Int



2\. What are the difference between value type and reference type variables? What is boxing and unboxing?

&nbsp;	The differences: 	1. Value type will directly hold the value but reference type will hold the memory address or reference for the value.

&nbsp;					2. Value types are stored in stack memory but references types are stored in heap memory.

&nbsp;					3. Value types will not be collected by a garbage collector but references type will be collected by garbage collector.

&nbsp;					4. The value type will be created struct or Enum while reference type will be created by class, interface or delegate.

&nbsp;					5. Value type can't accept null values whereas reference types can accept null values. 

&nbsp;	Boxing:	convert value type to reference type/object type

&nbsp;	Unboxing:    convert reference type to value type	



3\. What is meant by the terms managed resource and unmanaged resource in .NET

&nbsp;	Manages resource:  Resources whose lifecycle is automatically managed by the .NET Common Language Runtime through the garbage collector.

&nbsp;	Unmanaged resource: Resources outside the .NET runtime's direct control that require explicit cleanup by the developer.



4\. What's the purpose of Garbage Collector in .NET?

&nbsp;	The Garbage Collector in .NET is responsible for automatically managing memory. It frees up memory used by objects that are no longer accessible in the program, helping to prevent memory leaks and optimizing the application’s memory usage.



-----------------Controlling Flow and Converting Types----------------------------------

Test your Knowledge

1\. What happens when you divide an int variable by 0?

&nbsp;	This will cause a DivideByZeroException to be thrown, as dividing by zero is undefined in integer arithmetic.



2\. What happens when you divide a double variable by 0?

&nbsp;	The result will be wither positive or negative infinity depending on the sign of numerator. If you divide zero by zero, it will cause Double.NaN



3\. What happens when you overflow an int variable, that is, set it to a value beyond its range?

&nbsp;	If an integer overflows, it wraps around to the either minimum value or maximum value depending on its numerator.

&nbsp;	If you try to set a value beyond its range this will be checked by the checked keywords and will throw an OverflowException if an overflow occurs.



4\. What is the difference between x = y++; and x = ++y;?

&nbsp;	x = y++ :  x is first set the value of original y and y plus one.

&nbsp;	x = ++y :  y first plus one and set the value of x equals to y+1.



5\. What is the difference between break, continue, and return when used inside a loop statement?

&nbsp;	Break: the break statement exits the loop immediately.

&nbsp;	Continue: the continue statement skips the rest of current iteration and moves to the next iteration of the loop

&nbsp;	Return: the return statement exits the loop statement and returning a value if the method has a return type.



6\. What are the three parts of a for statement and which of them are required?

&nbsp;	Initialization: Sets up the loop variable.

&nbsp;	Condition: Checked before each iteration and if false the loop ends.

&nbsp;	Iteration: Executes after each iteration of the loop. The condition is required and the other two parts are optional.



7\. What is the difference between the = and == operators?

&nbsp;	= is an assignment operator, used to assign the value to a variable.

&nbsp;	== is a comparable operator, it used to compare the two values are equal or not and return the bool true or false.



8\. Does the following statement compile? for ( ; true; ) ;

&nbsp;	Yes. This statement means an infinite loop.



9\. What does the underscore \_ represent in a switch expression?

&nbsp;	The underscore\_ is used as a discard, which is a way to match any value that wasn't matched by previous cases in a switch expression.



10\. What interface must an object implement to be enumerated over by using the foreach statement?

&nbsp;	An object must implement the IEnumerable or IEnumerable<T> interface to be enumerated over with a foreach statement. These interfaces require the implementation of the GetEnumerator method, which returns an IEnumerator or IEnumerator<T>.



---------------------Arrays and Strings----------------------

1\. When to use String vs. StringBuilder in C# ?

&nbsp;	Use string when you have a fixed or infrequently changing string. Since string is immutable, each modification creates a new string which can be inefficient for frequent changes.

&nbsp;	Use Stringbuilder when you need to make a frequent modifications to a string.StringBuilder is mutable and allows for efficient appending, insertion and removal of characters.



2\. What is the base class for all arrays in C#?

&nbsp;	System.Array. This class provides various properties and methods for creating, manipulating and managing arrays.



3\. How do you sort an array in C#?

&nbsp;	Use Array.Sort() function. This helps sorting elements in a one-dimensional array.



4\. What property of an array object can be used to get the total number of elements in an array?

&nbsp;	The property to get the total number of elements in an array is length. It returns the total number elements across all dimensions of the array.



5\. Can you store multiple data types in System.Array?

&nbsp;	Yes. You could store multiple data types by creating an array of type objects.



6\. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

&nbsp;	CopyTo() method copies the elements from the sources array to a destination array starting at a specified index.

&nbsp;	System.Array.Clone() creates a new array that is a shallow copy of the original array. It's useful when you need a duplicate array with the same elements.













