namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Localloc : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int len = ctx.VMStack.Pop().Unbox();
            byte[] alloc = new byte[len];
            
            ctx.VMStack.Push(VMObject.GetPointer(ref alloc[0]));

            ctx.Position++;
        }
    }
}