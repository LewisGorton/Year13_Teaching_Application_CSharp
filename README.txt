This is all my code that was used for my teaching application for Year 12 Further Maths complex numbers that I made in year 13.

The language used is C# and the IDE used was visual studio 2019. Essentially, a lot of the files given here were automatically created; the files that I developed myself were:

Complex.cs (class used for creating complex numbers)
MAL.cs (static class that contains all of the Maths algorithms, hence the name MAL, required, such as a Macalurin eries approximation to arctan and sine functions and an implementation of the Chudnovsky algorithm for calculating an accurate approximation for pi
DisplayComplex.cs (windows form class used to display the complex number in modulus argument form)
Graph.cs (used to display the various loci on an Argand diagram0
ParameterGraph.cs ( a type of Graph (see Graph.cs) with an additional paramter, such as a halfline or circle)
Main.cs (where all the windows forms are intitialised, basically the main "brain" of the code)
Midpoint.cs (a type of windows form that uses a graph where we're drawing the line that is equidistant from two given points - in retrospect this is worded badly, and if I was in Year 13 again I would word this class differently)
ModulusArgument.cs (type of windows form where we write the output of the complex number in modulus argument form)
Operations.cs (type of windows form that outputs the result of applying the standard operations (multiply, add etc.) to two complex numbers)
Program.cs (just a starting point to run Main.cs)

My main advice to anyone wishing to run this project would be to copy and paste all of the .cs files into a project folder in Visual Studio, as all of the other files are generated automatically by Visual Studio.

I made use of OOP, recursive algorithms, windows forms graphics and Maclaurin series approximations in this project.