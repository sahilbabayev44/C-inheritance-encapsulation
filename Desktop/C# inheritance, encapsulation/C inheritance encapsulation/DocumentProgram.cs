using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_inheritance_encapsulation
{
    public class DocumentProgram
    {


        public void OpenDocument()
        {
            Console.WriteLine("Document Opend");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert version");
        }
    }
}
