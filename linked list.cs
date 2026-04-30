using System;
LinkedList<int> a;
LinkedListNode<int> b= new LinkedListNode<int> (5);
LinkedList<int> d= new LinkedList<int>(new int[] { 1,2,3});
Console.WriteLine (d.Count);
Console.WriteLine (d.First?.Value);
Console.WriteLine (d.Last?.Value);

Console.WriteLine(d.First?.Next.Value);

var g= d.First;
g = g.Next;
while (g != null)
{
    Console.WriteLine (g.Value);
    g = g.Next;
}
Console.WriteLine ();
while (g != null)
{
    Console.WriteLine (g.Value);
    g = g.Previous;
}

foreach (int i in d)
{
    Console.WriteLine (i);
}
d.ToList().ForEach(x => Console.WriteLine (x));
Console.WriteLine ();


var currentNode = d.Find(2);
d.AddAfter(currentNode, 123);








using System;
List<string> sites = new List<string>()
{
    "google.com",
    "microsft.com",
    "github.com"
};
LinkedList<string> tabs = new LinkedList<string>(sites);


var currentTab = tabs.Find("microsoft.com");
tabs.AddAfter(currentTab, "chotot.com");
tabs.AddFirst("yandex.ru");
var tab  = tabs.Last;
while (tab != null)
{
    Console.WriteLine(tab.Value);
    tab = tab.Previous;
}
