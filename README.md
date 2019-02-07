﻿# Chapter 1 - C# in focus

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

## Using and implementing Interfaces
In the previous section, we had a look at abstract classes. You will remember that I said that abstract classes act like a common noun that describes the derived objects. When referring to interfaces however, we are saying that some or all of the derived classes share some sort of functionality. We can thus think of interfaces as verbs that describe an action.

## Asynchronous programming using async and await
Asynchronous programming will allow you to write code that can perform long running tasks while still keeping your application responsive. With the introduction of async in the .NET Framework 4.5, it removed the previously complicated approach to implementing asynchronous functionality in your applications.

## Making use of extension methods
Since C# 3.0, extension methods have been making a huge difference in how I use my code. I am able to add methods to existing types without creating a new derived type. The C# Programming guide describes extension methods as a special kind of static method. The only difference is that they are called as if they were instance methods on the type being extended (i.e. called by using instance method syntax).

## Generics
Generics have been with us since C# 2. The goal was to allow developers to reuse code while maintaining type safety. Think of generics as a blueprint that will allow you to define data structures that are type safe without the commitment of actually defining a type.

## Nullable types
In C#, all reference types such as strings are nullable. In fact, null is the default value of reference type variables. This means that, while they can be null, we actually need to see the null keyword as a literal that represents a null reference. Put differently, something that does not refer to any object in .NET. With the release of C# 2.0, we were introduced to nullable value types.

## Dynamic types
With the release of C# 4.0, developers were introduced to a new dynamic type. It's a static type, but dynamic objects bypass static type checking. Think of it acting like it has a type object.

# Chapter 3 - The new features of C# 8.0

## Nullable reference types
You will remember from the previous chapter that in order to mark a variable as nullable, you need to use the type and ? when declaring a variable. For example, int? represents a nullable int. Now you can do the same with reference types such as string? to declare a nullable string.

## Recursive patterns
Recursive patterns are a welcome addition to C#. You will remember that in C# 7, we saw the introduction of pattern matching. C# 8.0 takes this a step further by allowing patterns to contain other patterns.

## Ranges and indices
Ranges and indicies were designed in the first few months of 2018. What C# 8.0 allows us to do with indexed data structures is grab a slice of the array, string or span.

## Switch expressions
C#8.0 introduces switch expressions where the cases are expressions. Think of it as a lightweight version of switch statements.

## Target-typed new-expressions
In the past, you would need to add the type when creating an array of Point for example. With C# 8.0, when the type is given from the context, you can omit the type in these situations.

## Async streams
Think of a database that is queried for data which it can't return all at once. So, it needs to stream it, and the data will arrive at the calling code at certain intervals. Your code, however, wants to process this data in its own time. It is for this reason that C# 8.0 introduced IAsyncEnumerable<T> which is an asynchronous version of IEnumerable<T>.

## Using declarations
Another nice addition to C# 8.0 is the feature of simplifying using statements. Traditionally, using statements introduce a level of nesting. For simple cases, we now have using declarations in C# 8.0.

# Chapter 4 - Creating responsive web applications using ASP.NET MVC

## Creating your ASP.NET MVC Application
Responsive web applications are essential in modern application development. Users need to be able to view the content of your web application on any device. This means that a web application needs to resize itself based on whatever device it is being viewed on.

## Referencing jQuery and Bootstrap
In your Solution Explorer, if you expand the App_Start folder you will see a class called BundleConfig. It is here that you will see references to CSS and JavaScript files.

## Setting up and using SCSS
SCSS is an implementation of SASS (Syntactically Awesome Style Sheets). In fact, SASS supports two types of syntax namely SCSS and SASS. The main difference between SCSS and SASS is the use of curly braces and semicolons that SCSS uses. Being used to C#, it makes more sense to use SCSS. SCSS is fully compliant with CSS, so all your existing code will still work.

## Creating Views and using Razor
The whole premise of MVC is to separate concerns based on the role of each part of your application. As you probably know, MVC stands for Model, View and Controller. Let's see how this all fits together.
'