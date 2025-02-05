using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependencies;

internal class Counter : ICounter
{
    private int counter = 0;

    public int CounterValue { get => counter; }
    public void Increment()
    {
        counter++;
    }
}
