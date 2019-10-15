using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class RunCondition : BaseCondition
    {
        private Condtition condtition = new Condtition();
        private CondtitionPart2 CondtitionPart2 = new CondtitionPart2();

        public override void ComparisonNumber(int Number)
        {
            if (Number > 0)
            {
                condtition.ComparisonNumber(Number);
                CondtitionPart2.ComparisonNumber(Number);
            }            
        }

    }
}
