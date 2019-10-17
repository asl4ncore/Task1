using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Model
{
    public class RunCondition 
    {
        public ICondition Condtition { get; set; }

        public void Run(int Number)
        {
            if (Number != 0)
            {
                Condtition.ComparisonNumber(Number);
            }
        }

    }
}
