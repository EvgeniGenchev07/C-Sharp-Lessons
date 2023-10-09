using SingleLinkedList;

var a = new SingleLinkedList<int>();
a.Add(1);
a.Add(2);
a.Add(3);
a.Add(4);
a.Add(5);
a.Remove(4);
a.Add(6);
a.Remove(6);
a.Add(7);
a.InsertAt(0, 2);
a.InsertAt(8, 3);
a.Add(9);
a.Print();