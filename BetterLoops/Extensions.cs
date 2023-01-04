using System.Collections;

namespace BetterLoops
{
    internal static class Extensions
    {
        internal static CustomIntEnumerator GetEnumerator(this Range range)
        {
            return new CustomIntEnumerator(range);
        }

        internal ref struct CustomIntEnumerator
        {
            private readonly int end;
            private int current;

            public CustomIntEnumerator(Range range)
            {
                if (range.End.IsFromEnd)
                {
                    throw new NotSupportedException();
                }

                current = range.Start.Value - 1;
                end = range.End.Value;
            }

            public int Current => current;

            public bool MoveNext()
            {
                current++;
                return current <= end;
            }
        }
    }
}
