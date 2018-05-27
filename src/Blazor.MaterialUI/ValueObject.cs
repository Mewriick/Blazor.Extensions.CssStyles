using System.Collections.Generic;

namespace Blazor.Extensions.CssStyles
{
    public abstract class ValueObject
    {
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != GetType())
            {
                return false;
            }

            bool result;

            if (!(obj is ValueObject other))
            {
                return false;
            }

            var thisValues = GetAtomicValues().GetEnumerator();
            var otherValues = other.GetAtomicValues().GetEnumerator();


            while (thisValues.MoveNext() && otherValues.MoveNext())
            {
                if (thisValues.Current is null ^ otherValues.Current is null)
                {
                    thisValues.Dispose();
                    otherValues.Dispose();

                    return false;
                }

                if (thisValues.Current != null && !thisValues.Current.Equals(otherValues.Current))
                {
                    thisValues.Dispose();
                    otherValues.Dispose();

                    return false;
                }
            }

            result = otherValues != null && (!thisValues.MoveNext() && !otherValues.MoveNext());

            thisValues.Dispose();
            otherValues?.Dispose();

            return result;
        }

        public override int GetHashCode()
        {
            var objectValues = GetAtomicValues().GetEnumerator();
            var hash = 13;
            while (objectValues.MoveNext())
            {
                hash = (hash ^ 7) + objectValues.Current.GetHashCode();
            }

            objectValues.Dispose();

            return hash;
        }

        public static bool operator ==(ValueObject left, ValueObject right)
        {
            if (left is null ^ right is null)
            {
                return false;
            }

            return left is null || left.Equals(right);
        }

        public static bool operator !=(ValueObject left, ValueObject right)
        {
            return !(left == right);
        }

        protected abstract IEnumerable<object> GetAtomicValues();
    }

}
