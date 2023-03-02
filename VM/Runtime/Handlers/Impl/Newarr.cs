namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Newarr : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject len = ctx.VMStack.Pop();
            VMObject[] arr = new VMObject[len];
            
            ctx.VMStack.Push(arr);
            
            ctx.Position++;
        }
    }
}