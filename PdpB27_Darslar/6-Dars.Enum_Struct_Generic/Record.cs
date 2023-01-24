namespace PdpB27_Darslar._6_Dars.Enum_Struct_Generic;

 class Car
{
    public int MyProperty { get; init; }
    public int My1 { get; init; }
}
public record Name
{
    public int first { get; init; }
    public int last { get; init; }
}

    public record Name1:Name
{
    public string first { get; init; }
    public string last { get; init; }

    public Name1(string first, string last)
    {
        this.first = first;
        this.last = last;
    }
}

internal class Record
{
    public static void Do()
    {
        Car car1 = new Car { MyProperty = 9, My1 = 7 };
       // Car name2 = car1 with { MyProperty = 9, };
       // Name name = new("Michael", "Jackson");

        Name1 name1 = new("Michael", "Jordan");
        Console.WriteLine(name1);//Name { first = Michael, second = Jordan }

        RecordName recName1 = new RecordName("Michael", "Jackson");
        RecordName recName2 = new RecordName("Michael", "Jackson");
        ClassName className1 = new ClassName("Michael", "Jackson");
        ClassName className2 = new ClassName("Michael", "Jackson");
        Console.WriteLine(recName1.Equals(recName2));//True
        Console.WriteLine(className1.Equals(className2));//False
        Console.WriteLine(className1.Equals(recName2));//False
        Console.WriteLine(recName1.Equals(className2));//False

        
    }
}

public record RecordName(string first, string second);
public class ClassName
{
    public string First { get; set; }
    public string Last { get; set; }
    public ClassName(string first, string last)
    {
        First = first;
        Last = last;
    }
}



