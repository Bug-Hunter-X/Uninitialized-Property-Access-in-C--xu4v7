# Uninitialized Property Access in C#

This repository demonstrates a common, yet subtle, error in C#: accessing a property of a class before it has been assigned a value. This issue is particularly relevant with value types (like `int`, `float`, etc.) where an uninitialized property will have a default value that might not be appropriate for your code's logic.

## The Problem

The `bug.cs` file shows a C# class with an integer property, `MyProperty`, which is not explicitly initialized. The `MyMethod` function then attempts to use this property in a calculation.

The issue is that uninitialized properties of value types have default values (0 for `int`, 0.0 for `float`, etc.). If you don't expect this default value, the calculation in `MyMethod` will produce an unexpected result. This could lead to incorrect calculations or even exceptions if the code relies on a specific value for `MyProperty`.

## The Solution

The `bugSolution.cs` file provides a corrected version.  It initializes `MyProperty` in the constructor or provides an alternative way of handling cases where the property might not have been initialized. 

## How to run

Simply compile and run the provided C# code files.