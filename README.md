# About CSharpWith
A C# implementation of the With..EndWith statement that is featured in some other languages such as VB.

Back in the day when I worked in Visual Basic (from version 3 to VB.Net) I always liked how clean and readable using the With...End With statements made my code.
This is my take on implementing a similar pattern in C# using extension methods and Lambda expressions.

*CSharpWith* allows you to wrap an object of your choosing inside a *With* object that you can then use to invoke methods by calling *Do*.
Each call will return the *With* object, making it possible to chain method calls together.

Finally if you need to get to the underlying value, you can do this by calling the *EndWith* property on the *With*.

There are a few different ways to use the library so here are some examples of using *With*....

using CSharpWith;

    // Using the extension method to wrap an object with a 'With' object
    person.With()
        .Do(x => _ = x.FirstName = "John")
        .Do(x => _ = x.Surname = "Smith");

    // Without the extension method
    _ = new With(person)
        .Do(x => _ = x.FirstName = "John")
        .Do(x => _ = x.Surname = "Smith");

    // With is a wrapper for your object instances, 
    // you can access the wrapped object by
    // calling the EndWith property
    // Examples...            

    // With extension method
    Person myVar = new Person().With()
        .Do(x => _ = x.FirstName = "John")
        .Do(x => _ = x.Surname = "Smith");
    .EndWith;

    // Without the extension method
    Person person = new With(new Person())
        .Do(x => _ = x.FirstName = "John")
        .Do(x => _ = x.Surname = "Smith");
    .EndWith;

Remember you don't have to construct a new object instance when using *With*, the object could have been created at another point in your program. The examples use new Person() purely to try and provide a complete demonstration.

    // Finally you can use the With extension methods to pass in a single
    // action<T>, or mulitple action<T>s. 
    // Each one will return the T type so there's no need to use EndWith to.

        Person person1 = new Person().With(x =>
        {
            x.FirstName = "John";
            x.Surname = "Smith";
        });

        Person person2 = new Person()
        .With(
            x => x.FirstName = "John", 
            x => x.Surname = "Smith");