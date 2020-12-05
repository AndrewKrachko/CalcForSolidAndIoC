using System.Linq;
using Calculator.Interfaces;

namespace Calculator
{
    /// <summary>
    /// Реализует принцип Open/Close через абстрагирование Parser от типов объектов и позволяя
    /// относительно свободно изменять набор параметров в EquationItemFactory, оставляя Parser
    /// в исходном состоянии.
    /// </summary>
    public class EquationItemFactory
    {
        public char[] Operations = {'+', '-', '=', '$'};

        public bool CanOperate(IEqItem processedItem, char sign)
        {
            if (char.IsDigit(sign) && !((processedItem is Variable) || (processedItem is Number)) ||
                Operations.Contains(sign) || sign == '\0')
            {
                return true;
            }

            return false;
        }

        public IEqItem GetOperation(char sign, int position)
        {
            switch (sign)
            {
                case '$':
                    return new Variable(position);
                case var _ when char.IsDigit(sign):
                    return new Number(position);
                case '+':
                    return new SumOperation(position);
                case '-':
                    return new SubtractOperation(position);
                case '=':
                    return new AssignOperation(position);

                default:
                    return null;
            }
        }

        public void GetProcessedItemValue(IEqItem processedItem, string value)
        {
            switch (processedItem)
            {
                case var _ when processedItem is Number number:
                    if (double.TryParse(value, out var result))
                    {
                        number.SetValue(result);
                    }
                    break;
                case var _ when processedItem is Variable variable:
                    variable.SetName(value);
                    break;
            }
        }
    }
}