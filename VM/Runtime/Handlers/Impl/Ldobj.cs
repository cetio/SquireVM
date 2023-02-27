namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Ldobj : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int mdtoken = operand.Unbox();
            Type type = TokenHelper.ForceResolveType(mdtoken);
            IntPtr source = (IntPtr)ctx.VMStack.Pop().Unbox();
            
            ctx.VMStack.Push(Marshal.PtrToStructure(source, type));

            ctx.Position++;
        }
    }
}