using Class2Query.Generated;
using System;

namespace Test;

[IsFilter]
public class BookFilter
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublishedYear { get; set; }
    
    [IncludeIfDefault]
    public int MyEnumThatCanBeZero { get; set; }
}
