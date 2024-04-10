using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

// namespace Program {

// Console.WriteLine("ad");

public class Program {
    


    private readonly static  FileOutput outFile = new FileOutput("A:/Advanced Web Services/animals3/animals.txt");
    private readonly static FileInput inFile = new FileInput("A:/Advanced Web Services/animals3/animals.txt");
    public StreamReader _sr;
    public static void Main(string[] args) {
        
        // ArrayList<> zoo = new ArrayList();
        List<Talkable> zoo = new List<Talkable>();
        
        // Lines to Replace Begin Here
        // Instantiate an object of your user input-gathering class
        // Use that object to add an object to the list
        // zoo.Add(new Teacher(44, "Stacy Read"));
        // End Lines to Replace
        
        // using (StreamReader _sr) { 
        try {
            
        // Console.WriteLine("Create a pet?(y/n): ");

        // if 
        Console.WriteLine("What type of Pet would you like to create?(animal name): ");
             string name = Console.ReadLine();
        Console.WriteLine("What is some info about this Pet?: ");
            string info = Console.ReadLine(); 
            
            zoo.Add(new UserInput(name, info));
            
        } catch (Exception e) {
            Console.WriteLine("Console Error: " + " " + e);
            
        }
        // }
        


        foreach (Talkable thing in zoo) {
            
            PrintOut(thing);
            // outFile.FileClose();
            
        }
        
        outFile.FileClose();
        inFile.FileRead();
        inFile.FileClose();

        FileInput indata = new FileInput("animals.txt");
        String line;
        if ((line = indata.FileReadLine()) != null) {
            Console.WriteLine(line);
        }
    }

    public static void PrintOut(Talkable p) {
        Console.WriteLine(p.GetName() + " says=" + p.Talk());
        outFile.FileWrite(p.GetName() + " | " + p.Talk());
    }
    
}














    



