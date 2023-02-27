namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Stobj : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            VMObject vobj = ctx.VMStack.Pop();
            Type type = vobj.Box().GetType();
            void* source = (void*)vobj.GetPointer()
            void* dest = (void*)ctx.VMStack.Pop().Unbox();

            Unsafe.InitBlock(dest, 0, Marshal.SizeOf(type));
            Unsafe.CopyBlock(dest, source, Marshal.SizeOf(type));

            ctx.Position++;
        }
    }
}