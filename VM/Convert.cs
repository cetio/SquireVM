namespace Squire.VM
{
    public class Convert
    {
        public MemoryStream Parse(MethodDef method)
        {
            if (!method.HasBody || !method.Body.HasInstructions)
                return null;

            MemoryStream ms = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(ms);

            foreach (Instruction instr in method.Body.Instructions)
            {
                if (ins.Operand is byte b)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(b);
                }
                else if (ins.Operand is sbyte sb)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(sb);
                }
                else if (ins.Operand is short s)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(s);
                }
                else if (ins.Operand is int i)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(i);
                }
                else if (ins.Operand is long l)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(l);
                }
                else if (ins.Operand is double d)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(d);
                }
                else if (ins.Operand is float f)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(f);
                }
                else if (ins.Operand is string str)
                {
                    writer.Write(0);
                    writer.Write((ushort)instr.Operand.Code)
                    writer.Write(str);
                }
                // finish me!
                dadmkwad
            }
        }
    }
}