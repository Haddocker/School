// Programmet skal udskrive tallene fra 0 til 9
// med den detalje at i stedet for tallet 5 skal teksten FEM udskrives
// (så det bliver 0 1 2 3 4 FEM 6 7 8 9)

for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        Console.Write("FEM");
        Console.Write(" ");
    }
    else
    {
        Console.Write(i);
        Console.Write(" ");
    }
}