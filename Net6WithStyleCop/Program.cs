// SA1200: Using directives must be placed within namespace
using System.Collections;
using System.Runtime.InteropServices;

namespace Net6WithStyleCop
{
    // CA1040: Avoid empty interfaces
    public interface IEmptyInterfaceNotHighlightedByDefault
    {
    }

    // CA1010: Collections should implement generic interface
    // SA1402: Move type to new file (https://youtrack.jetbrains.com/issue/RIDER-27433)
    // SA1649: File name must match first type name (https://youtrack.jetbrains.com/issue/RIDER-65813)
    public class BookCollectionNotHighlightedByDefault : CollectionBase
    {
        // CA1070: Event 'TestEvent' should not be declared virtual.
        public virtual event EventHandler TestEventHighlightedAsSuggestionByDefault;

        // CA1417: Do not use OutAttribute on string parameters for P/Invokes
        [DllImport("MyLibrary")]
        private static extern void Foo([Out] string stringHighlightedAsWarningByDefault);

        // CA1712: Do not prefix enum values with type name
        public enum Enum
        {
            EnumNotHighlightedByDefault1 = 0,
            EnumNotHighlightedByDefault2 = 1,

        }

        internal static class Program
        {
            private static void Main()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}