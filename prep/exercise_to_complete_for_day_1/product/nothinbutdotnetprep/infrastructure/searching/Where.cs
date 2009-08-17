using System;

namespace nothinbutdotnetprep.infrastructure.searching
{
    public class Where<ItemToFilter>
    {
        static public void has_an<PropertyTypeToFilterOn>(Func<ItemToFilter, object> func) where PropertyTypeToFilterOn : IComparable<PropertyTypeToFilterOn>
        {
            throw new NotImplementedException();
        }
        static public void has_a<PropertyTypeToFilterOn>(Func<ItemToFilter, object> func)
        {
            throw new NotImplementedException();
        }
    }
}