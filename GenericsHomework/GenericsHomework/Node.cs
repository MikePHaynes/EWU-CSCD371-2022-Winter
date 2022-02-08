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

        public override string? ToString()
        {
            if (Value is null) return null;
            return Value.ToString();
        }

        public void Append(T value)
        {
            
        }

        public void Clear()
        {
            Next = this;
        }

        public bool Exists(T value)
        {
            Node<T> current = this;
            do
            {
                if (current.Value is not null)
                {
                    if (current.Value.Equals(value))
                    {
                        return true;
                    }
                }
                current = current.Next;
            } while (Next != this);
            return false;
        }

    }
}