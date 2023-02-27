namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldind : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            IntPtr source = (IntPtr)ctx.VMStack.Pop().Unbox();
            ctx.VMStack.Push(Marshal.PtrToStructure(source, operand.Unbox()));

            ctx.Position++;
        }
    }
}