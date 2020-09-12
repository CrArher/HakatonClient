using System.Collections.Generic;

public class ControllerCollection
{
    private readonly List<IController> _controllers = new List<IController>();

    public void Activate()
    {
        foreach (var controller in _controllers)
        {
            controller.Activate();
        }
    }

    public void Deactivate()
    {
        foreach (var controller in _controllers)
        {
            controller.Deactivate();
        }
    }

    public void Remove(IController controller)
    {
        _controllers.Remove(controller);
        _controllers.Sort();
    }
    public void Add(IController controller)
    {
        _controllers.Add(controller);
    }
        
    public void Clear()
    {
        _controllers.Clear();
    }
}