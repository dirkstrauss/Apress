# Chapter 1 - C# in focus

## Getting started with tuples
Exactly what makes tupels so great? As you know, returning multiple values from a function is something you can already do in C#. Tuples simply give you another way to do this.

## Pattern matching
In C# 7, we now have the ability to use pattern matching. By using patterns, we can test if a value has a certain shape and if so, work with the information of that matching shape.

## Using out variables
The out keyword in C# has been around for a while. Using out passes arguments by reference. By default, all parameters in C# are passed by value unless you explicitly include an out or ref modifier.

## Using local functions
Local functions are private methods that are nested in another member. The use of local functions is quite common in functional languages. This has now been included in C# 7.

## Generalized async return types
The functionality of async/await is widely used to avoid performance bottlenecks and improve the responsiveness of your application. There is a slight issue though that in certain situations, returning a Task object from async methods could introduce performance issues. This is especially evident when an async method returns a cached result or completes in a synchronous fashion. 

## Throw expressions
Before C# 7, we used throw statements. The use of throw expressions didn't exist. It sort of makes sense, because using throw as an expression would always result in an exception. Whatever the reasoning was for not including throw expressions, the evolution of C# has necessitated the inclusion of this feature. The inclusion of throw expressions is now available in C# 7 in a limited set of contexts.

## Discards
C# 7 saw the introduction of discards. This is a really welcome addition to the language. It allows you to tell the compiler that you do not care about the value of a specific variable. Discards is therefore a dummy or temporary variable that is not going to be used at all in your application.

# Chapter 2 - Exploring C#

## Using and Implementing Abstract Classes
When we use the abstract modifier in a class declaration, we are actually saying that the class we are creating is only the basic base class of other classes. This means that any members marked as abstract or that are included in the base class have to be implemented by the derived classes (classes that use the base class).
