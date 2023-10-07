

namespace Linear_date_structures
{
    public class StackWithList<T> : List<T>
    {
        private List<T> list;
        public StackWithList():base() { }
        public void Push(T item)
        {
            list.PushBack(item);
        }
        public void Pop(T item)
        {
            list.PopBack();
        }
        public T Peek()
        {
            return list.Last;
        }
        public new void Reserve(int size)
        {
            list.Reserve(size);
        }
        public void ShrinkToFit()
        {
            list.SthrinkToFit();
        }
        public T Top => list.Last;
        public bool Empty=>list.Size == 0;
    }
}
