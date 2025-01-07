# Direct Access to Private Member Variable in C#

This repository demonstrates a common coding style issue in C#: directly accessing private member variables.  While functional, this practice is discouraged because it violates encapsulation and makes code harder to maintain.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file presents a corrected version using properties, adhering to good OOP principles.

## Problem
Directly accessing private variables reduces maintainability and may break future code changes.