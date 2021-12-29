namespace StateExample.Services
{
   public enum StateItem
   {
      ThingOne,
      ThingTwo
   }

   public class StateService
   {
      private readonly Dictionary<StateItem, object?> State;

      public StateService()
      {
         State = new Dictionary<StateItem, object?>();
      }

      public object? GetState(StateItem item)
      {
         if (State.TryGetValue(item, out var value))
         {
            return value;
         }
         return null;
      }

      public void SetState<T>(StateItem item, T value)
      {
         State[item] = value;
      }
   }
}
