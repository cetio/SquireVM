namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Castclass : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int mdtoken = (int)operand.Value;
            Type type = TokenHelper.ForceResolveType(mdtoken);
            VMObject vobj = ctx.VMStack.Pop();
            
            ctx.VMStack.Push(vobj.ChangeType(type));

            ctx.Position++;
        }
    }
}