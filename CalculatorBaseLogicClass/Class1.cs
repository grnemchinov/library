using DynamicExpresso;

namespace BaseLogicCalculator
{
    public static class Class1
    {
        public static string Eval(string exp)
        {
            var intrep = new Interpreter();
            try
            {
                var result = intrep.Eval(exp);
                return result.ToString();
            }
            catch
            {
                return "error";
            }
        }
    }
}