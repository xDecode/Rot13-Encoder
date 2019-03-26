using System.IO;   
namespace Verschlüsselung {
    public class FileEncryption {
        System.IO.StreamReader file2 = new System.IO.StreamReader(@"C:\Users\Marvin.Lehnert\Desktop\Text.txt");
        string lines = System.IO.File.ReadAllText(@"C:\Users\Marvin.Lehnert\Desktop\Text.txt");
        
    }   
}