// namespace Strategy.Structural
// {
//     /// <summary>
//     /// Strategy Design Pattern
//     /// </summary>
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             Context context;
//             // Three contexts following different strategies
//             context = new Context(new ConcreteStrategyA());
//             context.ContextInterface();
//             context = new Context(new ConcreteStrategyB());
//             context.ContextInterface();
//             context = new Context(new ConcreteStrategyC());
//             context.ContextInterface();
//             // Wait for user
//             Console.ReadKey();
//         }
//     }
//     /// <summary>
//     /// The 'Strategy' abstract class
//     /// </summary>
//     public abstract class Strategy
//     {
//         public abstract void AlgorithmInterface();
//     }
//     /// <summary>
//     /// A 'ConcreteStrategy' class
//     /// </summary>
//     public class ConcreteStrategyA : Strategy
//     {
//         public override void AlgorithmInterface()
//         {
//             Console.WriteLine(
//             "Called ConcreteStrategyA.AlgorithmInterface()");
//         }
//     }
//     /// <summary>
//     /// A 'ConcreteStrategy' class
//     /// </summary>
//     public class ConcreteStrategyB : Strategy
//     {
//         public override void AlgorithmInterface()
//         {
//             Console.WriteLine(
//             "Called ConcreteStrategyB.AlgorithmInterface()");
//         }
//     }
//     /// <summary>
//     /// A 'ConcreteStrategy' class
//     /// </summary>
//     public class ConcreteStrategyC : Strategy
//     {
//         public override void AlgorithmInterface()
//         {
//             Console.WriteLine(
//            "Called ConcreteStrategyC.AlgorithmInterface()");
//         }
//     }
//     /// <summary>
//     /// The 'Context' class
//     /// </summary>
//     public class Context
//     {
//         Strategy strategy;
//         // Constructor
//         public Context(Strategy strategy)
//         {
//             this.strategy = strategy;
//         }
//         public void ContextInterface()
//         {
//             strategy.AlgorithmInterface();
//         }
//     }
// }
using System;
using System.Collections.Generic;

namespace StrategyPatternSorting
{
    // The 'Strategy' abstract class
    public abstract class SortingStrategy
    {
        public abstract void Sort();
    }

    // A 'ConcreteStrategy' class representing Bubble Sort
    public class BubbleSortStrategy : SortingStrategy
    {
        public override void Sort()
        {
            Console.WriteLine("Sorting using Bubble Sort...");
            // Placeholder: Implement Bubble Sort logic here
        }
    }

    // A 'ConcreteStrategy' class representing Quick Sort
    public class QuickSortStrategy : SortingStrategy
    {
        public override void Sort()
        {
            Console.WriteLine("Sorting using Quick Sort...");
            // Placeholder: Implement Quick Sort logic here
        }
    }

    // A 'ConcreteStrategy' class representing Insertion Sort
    public class InsertionSortStrategy : SortingStrategy
    {
        public override void Sort()
        {
            Console.WriteLine("Sorting using Insertion Sort...");
            // Placeholder: Implement Insertion Sort logic here
        }
    }

    // The 'Context' class
    public class SortContext
    {
        private SortingStrategy _strategy;

        // Constructor
        public SortContext(SortingStrategy strategy)
        {
            _strategy = strategy;
        }

        // Sets the strategy at runtime

        // Executes the strategy
        public void SortList()
        {
            _strategy.Sort();
        }
    }

    // Test Program
    public class Program
    {
        public static void Main(string[] args)
        {

            // Sort list using Bubble Sort
            SortContext context = new SortContext(new BubbleSortStrategy());
            context.SortList();

            // Sort list using Quick Sort
            context = new SortContext(new QuickSortStrategy());
            context.SortList();

            // Sort list using Insertion Sort
            context = new SortContext(new InsertionSortStrategy());
            context.SortList();


            Console.ReadKey();
        }
    }
}
