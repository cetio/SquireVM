namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Isinst : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int mdtoken = operand.Unbox();
            Type type = TokenHelper.ForceResolveType(mdtoken);
            ctx.VMStack.Push(operand.IsType(type));

            ctx.Position++;
        }
    }
}