# Strategy Design Pattern in C#

This repository demonstrates the **Strategy Design Pattern** in C# through a practical example of sorting algorithms. The Strategy Pattern allows an object to select a specific algorithm at runtime and apply it without changing the client code.

---

## About the Code

This project implements three sorting algorithms using the **Strategy Design Pattern**:

- **Bubble Sort**
- **Quick Sort**
- **Insertion Sort**

The client (`SortContext`) can choose the sorting algorithm dynamically by switching strategies.

---

## How It Works

1. **SortingStrategy** is an abstract class that declares the `Sort()` method.
2. Concrete strategies such as `BubbleSortStrategy`, `QuickSortStrategy`, and `InsertionSortStrategy` each implement the `Sort()` method in their own way.
3. The **SortContext** class allows changing the sorting strategy at runtime and delegates the sorting task to the selected strategy.

---

## Class Breakdown

| Class Name              | Description                                      |
|-------------------------|--------------------------------------------------|
| `SortingStrategy`        | Abstract class defining the sorting strategy.    |
| `BubbleSortStrategy`     | Concrete strategy that implements Bubble Sort.   |
| `QuickSortStrategy`      | Concrete strategy that implements Quick Sort.    |
| `InsertionSortStrategy`  | Concrete strategy that implements Insertion Sort.|
| `SortContext`            | Context class that delegates sorting to a strategy.|

---

## UML Diagram

```plaintext
                   +----------------------+
                   |    SortingStrategy   |<-----------------------+
                   +----------------------+
                            ▲
                            |
            +-------------------------+  
            |                         |  
 +----------------------+    +---------------------+    +----------------------+
 |  BubbleSortStrategy  |    |   QuickSortStrategy |    | InsertionSortStrategy |
 +----------------------+    +---------------------+    +----------------------+
                            |
                            v
                   +---------------------+
                   |    SortContext      |
                   +---------------------+
```
## Sample Code

Below is an example of how to use the **Strategy Design Pattern** in the provided program:

```csharp
public class Program
{
    public static void Main(string[] args)
    {
        // Sort list using Bubble Sort
        SortContext context = new SortContext(new BubbleSortStrategy());
        context.SortList();  // Output: Sorting using Bubble Sort...

        // Sort list using Quick Sort
        context = new SortContext(new QuickSortStrategy());
        context.SortList();  // Output: Sorting using Quick Sort...

        // Sort list using Insertion Sort
        context = new SortContext(new InsertionSortStrategy());
        context.SortList();  // Output: Sorting using Insertion Sort...
    }
}
