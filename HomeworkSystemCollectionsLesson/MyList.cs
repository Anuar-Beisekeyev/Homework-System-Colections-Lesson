using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace HomeworkSystemCollectionsLesson
{
    public class MyList<T> : List<int>
    {
        public void BubbleSorting()
        {
            for(int i = 0; i < Count - 1; i++)
            {
                for(int j = 0; j < Count - 1 - i; j++)
                {
                    if (this[j] > this[j + 1])
                    {
                        int temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }
        

    }
}
