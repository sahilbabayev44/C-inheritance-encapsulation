﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_inheritance_encapsulation
{
    public class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document Edited");
        }


        public override void SaveDocument()
        {
            Console.WriteLine("document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
