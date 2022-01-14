using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using System;

namespace Design_Patterns_Assignment
{
    internal class DecoratorMain
    {
        internal static void Run()
        {
            //BaseText baseText = new BaseText();

            //Bold bold = new Bold(baseText);
            //ItalicText italicText = new ItalicText(baseText);
            //DeletedText deletedText =new DeletedText(baseText);
            //EmphasizedText emphasizedText = new EmphasizedText(baseText);
            //MarkedText markedText = new MarkedText(baseText);
            //ImportantText importantText = new ImportantText(baseText);
            //InsertedText insertedText = new InsertedText(baseText);
            //SmallerText smallerText = new SmallerText(baseText);
            //SubScriptText subScriptText = new SubScriptText(baseText);
            //SupScriptText supScriptText = new SupScriptText(baseText);

            Console.WriteLine("Decorator");

            Console.WriteLine("Decorate Your Text");
            Console.WriteLine("---------------------");
            Console.WriteLine("  Select an Tag-Style   ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Show finished text");
            Console.WriteLine("B: Add Bold");
            Console.WriteLine("C: Add Deleted");
            Console.WriteLine("D: Add Emphasized");
            Console.WriteLine("E: Add Important");
            Console.WriteLine("F: Add Inserted");
            Console.WriteLine("G: Add Italic");
            Console.WriteLine("H: Add Marked");
            Console.WriteLine("I: Add Smaller");
            Console.WriteLine("J: Add SubScript");
            Console.WriteLine("K: Add SuperScript");
            Console.WriteLine("X: Quit Program");

            Console.WriteLine("Please enter the text.");

            var textFactory = TextFactory.CreateText();

            textFactory.UserInput();

            var newTextFactory = textFactory;

            while (true)
            {

                Console.WriteLine("Add a tag style or press A for finished: ");
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'a' or 'A':
                        Console.WriteLine($"Decorated text: {textFactory.TextDecorate()}");
                        textFactory = newTextFactory;
                        break;

                    case 'b' or 'B':
                        Console.WriteLine("Add Bold text");
                        textFactory = new Bold(textFactory);
                        break;

                    case 'c' or 'C':
                        Console.WriteLine("Add Deleted text");
                        textFactory = new DeletedText(textFactory);
                        break;

                    case 'd' or 'D':
                        Console.WriteLine("Add Emphasized text");
                        textFactory = new EmphasizedText(textFactory);
                        break;

                    case 'e' or 'E':
                        Console.WriteLine("Add Important text");
                        textFactory = new ImportantText(textFactory);
                        break;

                    case 'f' or 'F':
                        Console.WriteLine("Add Inserted text");
                        textFactory = new InsertedText(textFactory);
                        break;

                    case 'g' or 'G':
                        Console.WriteLine("Add Italic text");
                        textFactory = new ItalicText(textFactory);
                        break;

                    case 'h' or 'H':
                        Console.WriteLine("Add Marked text");
                        textFactory = new MarkedText(textFactory);
                        break;
                    case 'i' or 'I':
                        Console.WriteLine("Add Smaller text");
                        textFactory = new SmallerText(textFactory);
                        break;
                    case 'j' or 'J':
                        Console.WriteLine("Add SubScript text");
                        textFactory = new SubScriptText(textFactory);
                        break;

                    case 'k' or 'K':
                        Console.WriteLine("Add SuperScript text");
                        textFactory = new SupScriptText(textFactory);
                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                        //baseText.description = Console.ReadLine();
                        //Console.WriteLine();
                        //Console.WriteLine( bold.TextDecorate());
                        //Console.WriteLine(deletedText.TextDecorate());
                        //Console.WriteLine(emphasizedText.TextDecorate());
                        //Console.WriteLine(importantText.TextDecorate());
                        //Console.WriteLine(insertedText.TextDecorate());
                        //Console.WriteLine(italicText.TextDecorate());
                        //Console.WriteLine(markedText.TextDecorate());
                        //Console.WriteLine(smallerText.TextDecorate());
                        //Console.WriteLine(subScriptText.TextDecorate());
                        //Console.WriteLine(supScriptText.TextDecorate());

                        // Refactor this code so that it uses the Decorator Pattern
                        //Console.WriteLine("Decorator");
                        //Console.WriteLine("Please enter the text.");
                        //string textInput = Console.ReadLine();
                        //Console.WriteLine();
                        //Console.WriteLine("Bold");
                        //Console.WriteLine("Deleted");
                        //Console.WriteLine("Emphasized");
                        //Console.WriteLine("Important");
                        //Console.WriteLine("Inserted");
                        //Console.WriteLine("Italic");
                        //Console.WriteLine("Marked");
                        //Console.WriteLine("Smaller");
                        //Console.WriteLine("SubScript");
                        //Console.WriteLine("SuperScript");
                        //Console.WriteLine();
                        //Console.WriteLine("Type the tags you want separated by space");
                        //string tagSelection = Console.ReadLine();
                        //string result = HTMLGenerator.TagProcessor(tagSelection, textInput);
                        //Console.WriteLine(result);
                        //Console.WriteLine();
                }
            }
        }
    }
}