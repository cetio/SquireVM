namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Sizeof : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int mdtoken = operand.Unbox();
            Type type = TokenHelper.ForceResolveType(mdtoken);
            
            ctx.VMStack.Push(Marshal.SizeOf(type));

            ctx.Position++;
        }
    }
}