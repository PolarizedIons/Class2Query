using Class2Query.Generated;
using System;

namespace Test;

[IsFilter]
public class PersonFilter
{
    public string Name { get; set; }
    public int Age { get; set; }
}
