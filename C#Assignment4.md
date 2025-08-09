------------04 Generics----------

Test your Knowledge

1\. Describe the problem generics address.

&nbsp;   Generic address has the problem of type safety and code reuse.

&nbsp;	This allows you to define a class or method with placeholders for the type of its fields, methods, parameters which can then be used with any data type without the need of casting.



2\. How would you create a list of strings, using the generic List class?

&nbsp;	List<string> listofstrings = new List<string>();



3\. How many generic type parameters does the Dictionary class have?

&nbsp;	The dictionary class has two generic type parameters: one for the key and one for the value.



4\. True/False. When a generic class has multiple type parameters, they must all match.

&nbsp;	False. When a generic class has multiple type parameters, they do not need to match; they can be of different types.



5\. What method is used to add items to a List object?

&nbsp;	In order to add items to a list object is to use Add() function.



6\. Name two methods that cause items to be removed from a List.

&nbsp;	The first one is Remove() function. The other is RemoveAt() function.



7\. How do you indicate that a class has a generic type parameter?

&nbsp;	To indicate that a class has a generic type parameter, you should use angle brackets<>.

&nbsp;	

8\. True/False. Generic classes can only have one generic type parameter.

&nbsp;	False. Generic classes can have more than one generic type parameter like Dictionary<TKey,TValue>



9\. True/False. Generic type constraints limit what can be used for the generic type.

&nbsp;	True. Generic type constraints limit what can be used for the generic type by specifying the requirements that must be met by the arguments passed to the type parameter.



10\. True/False. Constraints let you use the methods of the thing you are constraining to.

&nbsp;	True. Constraints allow you to use the methods of the type you are constraining to because you are specifying that the type argument must inherit from a certain base class or implement  a certain interface, which guarantees the presence of those methods.

