using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace NetCore31WithRoslynNotEnabled
{
    // CA1040: Avoid empty interfaces
    public interface IEmptyInterfaceNotHighlightedByDefault
    {
    }

    // CA1010: Collections should implement generic interface
    public class BookCollectionNotHighlightedByDefault : CollectionBase
    {
        // CA1070: Event 'TestEvent' should not be declared virtual.
        public virtual event EventHandler TestEventHighlightedAsSuggestionByDefault;

        // CA1417: Do not use OutAttribute on string parameters for P/Invokes
        [DllImport("MyLibrary")]
        private static extern void Foo([Out] string stringHighlightedAsWarningByDefault);
        
        //CA1712: Do not prefix enum values with type name
        public enum Enum
        {
            EnumNotHighlightedByDefault1 = 0,
            EnumNotHighlightedByDefault2 = 1
        }
    }

    internal static class Program
    {
    
        private static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}