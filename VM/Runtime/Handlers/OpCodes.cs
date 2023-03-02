namespace Squire.VM.Runtime.Handlers
{
    public class OpCodes
    {
        public static const OpCode Add = new Add();
        public static const OpCode And = new And();
        public static const OpCode Arglist = new Arglist();
        public static const OpCode Begincatch = new Begincatch();
        public static const OpCode Beginfinally = new Beginfinally();
        public static const OpCode Begintry = new Begintry();
        public static const OpCode Beq = new Beq();
        public static const OpCode Bge = new Bge();
        public static const OpCode Bgt = new Bgt();
        public static const OpCode Ble = new Ble();
        public static const OpCode Ble = new Ble();
        public static const OpCode Bne = new Bne();
        public static const OpCode Br = new Br();
        public static const OpCode Break = new Break();
        public static const OpCode Brfalse = new Brfalse();
        public static const OpCode Call = new Call();
        public static const OpCode Calli = new Calli();
        public static const OpCode Castclass = new Castclass();
        public static const OpCode Ceq = new Ceq();
        public static const OpCode Cgt = new Cgt();
        public static const OpCode Ckfinite = new Ckfinite();
        public static const OpCode Clt = new Clt();
        public static const OpCode Conv = new Conv();
        public static const OpCode Cpblk = new Cpblk();
        public static const OpCode Cpobj = new Cpobj();
        public static const OpCode Div = new Div();
        public static const OpCode Dup = new Dup();
        public static const OpCode Endcatch = new Endcatch();
        public static const OpCode Endfinally = new Endfinally();
        public static const OpCode Endtry = new Endtry();
        public static const OpCode Initblk = new Initblk();
        public static const OpCode Initobj = new Initobj();
        public static const OpCode Isinst = new Isinst();
        public static const OpCode Jmp = new Jmp();
        public static const OpCode Ldarg = new Ldarg();
        public static const OpCode Ldarga = new Ldarga();
        public static const OpCode Ldelem = new Ldelem();
        public static const OpCode Ldelema = new Ldelema();
        public static const OpCode Ldind = new Ldind();
        public static const OpCode Ldlen = new Ldlen();
        public static const OpCode Ldloc = new Ldloc();
        public static const OpCode Ldloca = new Ldloca();
        public static const OpCode Ldne = new Ldne();
        public static const OpCode Ldobj = new Ldobj();
        public static const OpCode Leave = new Leave();
        public static const OpCode Localloc = new Localloc();
        public static const OpCode Mul = new Mul();
        public static const OpCode Neg = new Neg();
        public static const OpCode Newarr = new Newarr();
        public static const OpCode Nop = new Nop();
        public static const OpCode Not = new Not();
        public static const OpCode Or = new Or();
        public static const OpCode Pop = new Pop();
        public static const OpCode Rem = new Rem();
    }
}