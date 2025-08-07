--------------Object-Oriented Programming--------------------

Test your knowledge

1\. What are the six combinations of access modifier keywords and what do they do?

&nbsp;   public: Accessible from any other class.

&nbsp;	private: Accessible only with the class defined.

&nbsp;	protected: Accessible within the class defined and any derived class.

&nbsp;	internal: Accessible within the same assembly or any derived class.

&nbsp;	protected internal: Accessible within the same assembly or any derived class.

&nbsp;	private protected: Accessible within the containing class or types derived from the containing class within the current assembly.



2.What is the difference between the static, const, and read-only keywords when applied to a type member?

&nbsp;	static: belong to the type itself rather than an instance of the type

&nbsp;	const: An immutable value which is known at compile time and cannot be changed.

&nbsp;	read-only: A variable that can be initialized at runtime or in the constructor of the class, and cannot be modified afterwards.



3\. What does a constructor do?

&nbsp;	A constructor is a special method used to initialize objects when they are created.



4\. Why is the partial keyword useful?

&nbsp;	The partial keyword allows the definition of a class, struct, or interface to be split into multiple files.



5\. What is a tuple?

&nbsp;	A tuple is a data struct which contains a sequence of elements of different data types.



6\. What does the C# record keyword do?

&nbsp;	The record keyword defines a reference type that provides built-in functionality for encapsulating data.



7\. What does overloading and overriding mean?

&nbsp;	Overloading: Having multiple methods with the same name but different parameters.

&nbsp;	Overriding: Redefining a method in a derived class that was already in the base class.



8\. What is the difference between a field and a property?

&nbsp;	A field is a variable declared directly in a class or struct.

&nbsp;	A property is a member that  provides a flexible mechanism to read, write, or compute the value of a private field.



9\. How do you make a method parameter optional?

&nbsp;	You can make a method parameter optional by specifying a default value for it.



10\. What is an interface and how is it different from abstract class?

&nbsp;	An interface defines a contract with no implementation.

&nbsp;	An abstract class can provide some implementation and can have constructors.



11\. What accessibility level are members of an interface?

&nbsp;	Members of an interface are by default public.



12\. True/False. Polymorphism allows derived classes to provide different implementations of the same method.

&nbsp;	True. Polymorphism allows derived classes to provide different implementations of the same method.



13\. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

&nbsp;	True. The override keywords is used to provide a new implementation of a method in a derived class.



14\. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.

&nbsp;	True. The new keyword is used to hide a method in a derived class.



15\. True/False. Abstract methods can be used in a normal (non-abstract) class.

&nbsp;	False. Abstract methods can only be used in abstract class.

&nbsp;	

16.True/False. Normal (non-abstract) methods can be used in an abstract class. 

&nbsp;	True. Normal methods can be used in an abstract class.



17\. True/False. Derived classes can override methods that were virtual in the base class.

&nbsp;	True. Derived classes can override methods that were virtual in the base class.



18\. True/False. Derived classes can override methods that were abstract in the base class. 

&nbsp;	True. Derived classes must override methods that were abstract in the base class.



19\. True/False. In a derived class, you can override a method that was neither virtual non abstract in the base class.

&nbsp;	False. You cannot override a method that was neither virtual non abstract in the base class.



20\. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.

&nbsp;	False. A class that implements an interface must provide an implementation for all of the members of the interface.



21\. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.

&nbsp;	True. A class that implements an interface is allowed to have other members that aren't defined in the interface.



22\. True/False. A class can have more than one base class.

&nbsp;	False. A class cannot have more than one base class.



23\. True/False. A class can implement more than one interface.

&nbsp;	True. A class can implement more than one interface.

