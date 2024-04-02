// Lists in C#
using ListTutorial;

List<Part> lp = new List<Part>();

lp.Add(new Part{PartName = "Headlight", PartId = 1});
lp.Add(new Part { PartName = "Bumper", PartId = 2 });


foreach (Part p in lp)
{
    Console.WriteLine("Part: {0}\nId: {1}",p.PartName, p.PartId);
}
