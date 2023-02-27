namespace Squire.VM.Runtime.Frame
{
    public class VMStack
    {
        public Stack<VMObject> Stack { get; }
        
        public int Count 
            => Stack.Count;

        public VmStack()
        {
            Stack = new Stack<VMObject>();
        }

        public void Push(object? obj) 
            => Stack.Push(new VMObject(obj));

        public void Push(VMObject vobj) 
            => Stack.Push(vobj);

        public VMObject Get(int i) => Stack.ToList()[i];
        public VMObject Peek() => Stack.Peek();
        public VMObject Pop() => Stack.Pop();
    }
}