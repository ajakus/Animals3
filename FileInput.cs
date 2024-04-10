using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class FileInput {
    
    private StreamReader sr;
    private string fileName = "animals.txt";

    public FileInput(string fileName) {
        using (StreamReader sr = new StreamReader(fileName)) {
        this.fileName = fileName;
        try {
                
            // sr = new StreamReader(fileName);
            // sr.Close();
        } catch (FileNotFoundException e) {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
        }
    }

    public void FileRead() {
        using (StreamReader sr = new StreamReader(fileName)) { 
        string line;
        try {
            
            if ((line = sr.ReadLine()) != null) {
                Console.WriteLine(line);
                // sr.Close();
            }
        } catch (Exception e) {
            //error persists here
            Console.WriteLine("File Write Error: " + fileName + " " + e);
        }
        sr.ReadToEnd(); }
    }

    public string FileReadLine() {
        using (StreamReader sr = new StreamReader(fileName)) { 
        try {
            string line = sr.ReadLine();
            return line;
            
            
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + fileName + " " + e);
            return null;
        }
        return sr.ReadLine(); }
    }

    public void FileClose() {
        if (sr != null) {
            try {
                sr.Close();
            } catch (IOException e) {
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}