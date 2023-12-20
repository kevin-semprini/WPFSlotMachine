// See https://aka.ms/new-console-template for more information
using Kevin.Semprini._4i.LibSlotMachine;

Console.WriteLine("Hello, slotMaachine!");

SlotMachine s = new SlotMachine(0);


if (s.Credito > 0)
{
    Console.WriteLine(s.Credito);
}
else
{
    Console.WriteLine("POVERO DI MERDA AHAHAHHAHAHAHAHHA!");
}


