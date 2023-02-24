using System;
using System.Collections.Generic;

class Branch{
  public List<Branch> branches = new List<Branch>();
}

class Hello {
  static void Main(string[] args) {
    // Create a root branch
    Branch rootBranch = new Branch();
    
    // Create child branches
    Branch child1 = new Branch();
    Branch child2 = new Branch();

    // Add child branches to root branch
    rootBranch.branches.Add(child1);
    rootBranch.branches.Add(child2);

    // Create grandchild branches
    Branch grandchild1 = new Branch();
    Branch grandchild2 = new Branch();

    // Add grandchild branches to child1
    child1.branches.Add(grandchild1);
    child1.branches.Add(grandchild2);

    // Create great-grandchild branches
    Branch greatgrandchild1 = new Branch();
    Branch greatgrandchild2 = new Branch();

    // Add great-grandchild branches to grandchild2
    grandchild2.branches.Add(greatgrandchild1);
    grandchild2.branches.Add(greatgrandchild2);

    // Print the hierarchy of branches
    PrintBranch(rootBranch);
  }

  static void PrintBranch(Branch branch, int level = 0) {
    // Print the name of the branch with indentation based on the level
    Console.WriteLine(new string(' ', level * 2) + "Branch");

    // Recursively print child branches with increased indentation level
    foreach (Branch child in branch.branches) {
      PrintBranch(child, level + 1);
    }
  }
}