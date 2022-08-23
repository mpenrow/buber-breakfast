using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
  // Using memroy data for example.  Would use a permament data store for production.
  private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();

  public void CreateBreakfast(Breakfast breakfast)
  {
    _breakfasts.Add(breakfast.Id, breakfast);
  }

  public Breakfast GetBreakfast(Guid id)
  {
    return _breakfasts[id];
  }
}