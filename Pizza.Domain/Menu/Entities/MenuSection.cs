using Pizza.Domain.Common;
using Pizza.Domain.Menu.ValueObjects;

namespace Pizza.Domain.Menu.Entities;

public class MenuSection: Entity<MenuSectionId>
{
    private readonly List<MenuItem> _items = new(); 
    public string Name { get; }
    public string Description { get; }

    public IReadOnlyList<MenuItem> Items 
        => _items.AsReadOnly();
    
    private MenuSection(
        MenuSectionId menuSectionId,
        string name, 
        string description) : base(menuSectionId)
    {
        Name = name;
        Description = description;
    }

    public static MenuSection Create(
        string name,
        string description) 
        => new MenuSection(
            MenuSectionId.CreateUnique(),
            name,
            description);
}