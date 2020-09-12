using System.Collections.Generic;
using DefaultNamespace;

public class Generator : IGenerator
{
    private readonly List<IGenerator> _generators = new List<IGenerator>();

    public void Add(IGenerator generator)
    {
        _generators.Add(generator);
    }

    public void Generate(GlobalContext context, ControllerCollection controllerCollection, GlobalContainer container)
    {
        foreach (var generator in _generators)
        {
            generator.Generate(context, controllerCollection, container);
        }
    }
}