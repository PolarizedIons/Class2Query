using Class2Query.Generated;
using Test;

var searchingForMe = new PersonFilter()
{
    Name = "Stephan",
    Age = 23,
};

Console.WriteLine(searchingForMe.ToQuery());


var searchingForBook = new BookFilter()
{
    Title = "Search Title",
    MyEnumThatCanBeZero = 0,
    PublishedYear = 0,
};

Console.WriteLine(searchingForBook.ToQuery());
