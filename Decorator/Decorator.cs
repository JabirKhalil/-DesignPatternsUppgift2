using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using System;

namespace Design_Patterns_Assignment
{
    internal class DecoratorMain
    {
        internal static void Run()
        {
            BaseText baseText = new BaseText();
           
            Bold bold = new Bold(baseText);
            ItalicText italicText = new ItalicText(baseText);
            DeletedText deletedText =new DeletedText(baseText);
            EmphasizedText emphasizedText = new EmphasizedText(baseText);
            MarkedText markedText = new MarkedText(baseText);
            ImportantText importantText = new ImportantText(baseText);
            InsertedText insertedText = new InsertedText(baseText);
            SmallerText smallerText = new SmallerText(baseText);
            SubScriptText subScriptText = new SubScriptText(baseText);
            SupScriptText supScriptText = new SupScriptText(baseText);

            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            baseText.description = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine( bold.TextDecorate());
            Console.WriteLine(deletedText.TextDecorate());
            Console.WriteLine(emphasizedText.TextDecorate());
            Console.WriteLine(importantText.TextDecorate());
            Console.WriteLine(insertedText.TextDecorate());
            Console.WriteLine(italicText.TextDecorate());
            Console.WriteLine(markedText.TextDecorate());
            Console.WriteLine(smallerText.TextDecorate());
            Console.WriteLine(subScriptText.TextDecorate());
            Console.WriteLine(supScriptText.TextDecorate());

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