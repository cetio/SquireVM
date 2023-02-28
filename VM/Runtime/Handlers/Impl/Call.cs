namespace Squire.VM.Runtime.Handlers.Impl
{
    public class Call : OpCode
    {
        public override void Run(Context ctx, VMObject operand)
        {
            if (operand.IsType(typeof(ConstructorInfo)))
            {
                ConstructorInfo method = operand.Unbox();

                int plen = method.GetParameters().Length - 1;
                List<object> params = new List<object>()
                for (; plen > -1; plen--)
                    params.Add(VMStack.Pop().ToParameter(method.GetParameters()[plen]));

                object? ret = method.Invoke(params.ToArray());

                if (((MethodInfo)method).ReturnType == typeof(voic))
                    ctx.VMStack.Push(ret);
            }
            else
            {
                MethodBase method = (MethodBase)operand.Unbox();
                object target = method.IsStatic ? null : vmContext.Stack.Pop().Box();

                int plen = method.GetParameters().Length - 1;
                List<object> params = new List<object>()
                for (; plen > -1; plen--)
                    params.Add(VMStack.Pop().ToParameter(method.GetParameters()[plen]));

                object? ret = method.Invoke(target, params.ToArray());

                if (ret != null)
                    ctx.VMStack.Push(ret);
            }
            
            
            ctx.Position++;
        }
    }
}