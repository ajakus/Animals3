using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class FileOutput {

    
    private string fileName = "animals.txt";
    // FileStream
    // FileStream fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
    public StreamWriter sw;

    public FileOutput(string fileName) {
        this.fileName = fileName;
        using (sw = new StreamWriter(fileName)) {    
        try {
            // sw = new StreamWriter(fileName);
            // sw.Close();
            // sw.AutoFlush = true;
            Console.WriteLine(" FileOutput: " + fileName);
        } catch (FileNotFoundException e) {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
        }
    }

    public void FileWrite(string line) {
        using (sw = new StreamWriter(fileName, append: true)) { 
        try {
            // sw = new StreamWriter(fileName);
            // sw.Close();
            
            // Console.Write("FileWrite: " + line);
            sw.WriteLine( line );
            // sw.Close();
            
            
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + fileName + " " + e);
        }
        } 
    }

    public void FileClose() {
        if (sw!= null) {
            try {
                sw.Close();
            } catch (IOException e) {
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}