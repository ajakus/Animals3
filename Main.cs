// using System;
// using System.Collections.Generic;
// using System.Linq;


// public static class Main {

//     private readonly static  FileOutput outFile = new FileOutput("animals.txt");
//     private readonly static FileInput inFile = new FileInput("animals.txt");

//     public static void main(String[] args) {
//         // ArrayList<> zoo = new ArrayList();
//         List<Talkable> zoo = new List<Talkable>();

//         // Lines to Replace Begin Here
//         // zoo.Add(new Dog(true, "Bean"));
//         // zoo.Add(new Cat(9, "Charlie"));
//         // zoo.Add(new Teacher(44, "Stacy Read"));
//         // End Lines to Replace

//         foreach(Talkable thing in zoo) {
//             PrintOut(thing);
//         }
//         outFile.FileClose();
//         inFile.FileRead();
//         inFile.FileClose();

//         FileInput indata = new FileInput("animals.txt");
//         String line;
//         while ((line = indata.FileReadLine()) != null) {
//             Console.WriteLine(line);
//         }
//     }

//     public static void PrintOut(Talkable p) {
//         Console.WriteLine(p.GetName() + " says=" + p.Talk());
//         outFile.FileWrite(p.GetName() + " | " + p.Talk());
//     }
// }