using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Calculator.Interfaces;

namespace Calculator
{
    /// <summary>
    /// А здесь реализована инверсия зависимостей через передачу в метод Parse
    /// объекта с интерфейсом IDataSource.
    /// </summary>
    public class Parser : IParser
    {
        private Status _parserStatus;
        private IEnumerable<IEquationSet> _equationSet;
        private char _decimalSeparator;
        private char _thousandSeparator;

        public Status ParserStatus { get; }

        public Parser() : this('.', ',')
        {
        }

        public Parser(char decimalSeparator, char thousandSeparator)
        {
            _parserStatus = Status.Idle;
            _decimalSeparator = decimalSeparator;
            _thousandSeparator = thousandSeparator;
        }

        public IEquationSet[] Parse(IDataSource dataSource)
        {
            _parserStatus = Status.Processing;
            var data = dataSource.GetData();
            var equationSets = new List<IEquationSet>();

            foreach (var subSet in data.Split('\n'))
            {
                equationSets.Add(OperateSubString(subSet));
            }

            _parserStatus = Status.Ready;

            return equationSets.ToArray();
        }

        private IEquationSet OperateSubString(string substring)
        {
            substring = substring.Trim(_thousandSeparator, ' ') + '\0';

            var eqSubset = new List<IEqItem>();
            int position = 0;
            IEqItem processedItem = null;
            var itemFactory = new EquationItemFactory();

            do
            {
                var sign = substring[position];
                if (itemFactory.CanOperate(processedItem, sign))
                {
                    if (processedItem != null)
                    {
                        itemFactory.GetProcessedItemValue(processedItem,
                            substring.Substring(processedItem.Position, position - processedItem.Position));
                        eqSubset.Add(processedItem);
                    }

                    processedItem = itemFactory.GetOperation(sign, position);
                }

                position++;
            } while (substring.Length > position);

            return new EquationSet(eqSubset.ToArray());
        }
    }
}