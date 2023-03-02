namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Stobj : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            object source = ctx.VMStack.Pop().Box();
            void* dest = (void*)ctx.VMStack.Pop().Unbox();

            int size = Marshal.SizeOf(source.GetType());

            Unsafe.InitBlock(dest, 0, size);
            Unsafe.CopyBlock(dest, source, size);

            ctx.Position++;
        }
    }
}