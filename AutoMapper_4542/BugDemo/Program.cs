using System;
using AutoMapper;

public class Source { public string Name { get; set; } }
public class Destination { public string Name { get; set; } }

class Program
{
    static void Main()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Source, Destination>();
        });

        var mapper = config.CreateMapper();

        var source = new Source { Name = "Sai" };
        var dest = mapper.Map<Destination>(source);
        Console.WriteLine("Mapped Name: " + dest.Name);
    }
}