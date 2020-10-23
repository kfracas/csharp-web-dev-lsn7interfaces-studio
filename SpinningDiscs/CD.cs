using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public CD(string name, string discType, double storageCapacity, List<Data> contents) : base(name, discType, storageCapacity, contents)
        {
        }
        public void SpinDisc()
        {
            Console.WriteLine("You spin me round...");
        }
    }
}
