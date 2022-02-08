namespace GenericsHomework
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; private set; }

        public Node(T value)
        {
            Value = value;
            Next = this;
        }

        public override string ToString()
        {
            return "";
        }

        public void Append(T value)
        {

        }

        public void Clear()
        {

        }

        public bool Exists(T value)
        {
            return true;
        }

    }
}