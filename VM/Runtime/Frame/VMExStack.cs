namespace Squire.VM.Runtime.Frame
{
    public class VMExStack
    {
        public Stack<Exception> Stack { get; }
        
        public int Count 
            => Stack.Count;

        public VMExStack()
        {
            Stack = new Stack<Exception>();
        }

        public void Push(Exception ex) 
            => Stack.Push(ex);

        public Exception Get(int i) => Stack.ToList()[i];
        public Exception Peek() => Stack.Peek();
        public Exception Pop() => Stack.Pop();
    }
}