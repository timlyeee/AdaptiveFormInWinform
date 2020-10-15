using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveForm
{
    unsafe class A_Alength:Observer
    {
        int* length;

        A_Alength(Subject s,ref int Length)
        {
            s.AddObserver(this);
            *length = Length;

            
        }
        
        public override void Response()
        {
            *length = (int)(*length * 0.5);
        }
    }
    unsafe class A_OLength:Subject
    {
        int* length;
        A_OLength(ref int Length)
        {
            *length = Length;
        }

    }
}
