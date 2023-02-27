namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Cpobj : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            int mdtoken = operand.Unbox();
            Type type = TokenHelper.ForceResolveType(mdtoken);
            void* dest = (void*)ctx.VMStack.Pop().Unbox();
            void* source = (void*)ctx.VMStack.Pop().Unbox();

            Unsafe.InitBlock(dest, 0, Marshal.SizeOf(type));
            Unsafe.CopyBlock(dest, source, Marshal.SizeOf(type));

            ctx.Position++;
        }
    }
}