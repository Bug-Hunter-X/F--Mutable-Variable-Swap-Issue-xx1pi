# F# Mutable Variable Swap Issue

This example demonstrates a common mistake when working with mutable variables in F#.  The `swap` function doesn't correctly swap the values of the mutable variables `x` and `y` because F# passes arguments by value, not by reference.  The solution shows how to properly swap using a tuple or a function that returns a tuple of the swapped values.