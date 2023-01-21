using Pizza.Domain.Common;
using Pizza.Domain.Menu.ValueObjects;

namespace Pizza.Domain.Menu.Entities;

public class MenuItem: Entity<MenuItemId>
{
    public string Name { get; }
    public string Description { get; }
    
    private MenuItem(
        MenuItemId menuItemId, 
        string name, 
        string description) 
        : base(menuItemId)
    {
        Name = name;
        Description = description;
    }

    public static MenuItem Create(string name, string description) 
        => new(MenuItemId.CreateUnique(), name, description);
}