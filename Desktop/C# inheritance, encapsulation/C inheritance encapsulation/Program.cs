namespace C_inheritance_encapsulation
{
    internal class Program
    {
        static void Main()
        {
            DocumentProgram documentprogram = new DocumentProgram();
            ExpertDocumnetProgram expertDocumentProgram = new ExpertDocumnetProgram();
                ProDocumentProgram proDocumentProgram = new ProDocumentProgram();


            documentprogram.OpenDocument();
            documentprogram.EditDocument();
            documentprogram.SaveDocument();


            expertDocumentProgram.OpenDocument();
            expertDocumentProgram.EditDocument();
            expertDocumentProgram.SaveDocument();


            proDocumentProgram.OpenDocument();
            proDocumentProgram.EditDocument();
            proDocumentProgram.SaveDocument();
        }
    }
}