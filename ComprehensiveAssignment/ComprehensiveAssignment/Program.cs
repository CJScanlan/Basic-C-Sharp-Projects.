using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] sentences = { "I am ", "You are ", "We all are ", "Except him. He's not " };
        Console.WriteLine("Please enter an adjective.");
        string userInput = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
            sentences[i] = sentences[i] + userInput;
        }
        
        foreach (string sentence in sentences)
        {
            Console.WriteLine(sentence);
        }

        bool isTrue = true;
        while (isTrue)
        {
            Console.WriteLine("\nHello there!\n");
            isTrue = false;
        }

        List<int> temperatures = new List<int>();
        temperatures.Add(55);
        temperatures.Add(65);
        temperatures.Add(78);
        temperatures.Add(43);
        temperatures.Add(32);
        temperatures.Add(38);

        foreach (int temp in temperatures)
        {
            if (temp < 45)
            {
                Console.WriteLine("Bundle up! It's " + temp + " degrees.");
            }
        }

        Console.WriteLine("\nEnter a number.");
        int userNum = Convert.ToInt32(Console.ReadLine());
        int counting = 0;

        while (counting <= userNum)
        {
            Console.WriteLine(counting);
            counting++;
        }

        List<string> animals = new List<string>();
        animals.Add("tiger");
        animals.Add("monkey");
        animals.Add("elephant");
        animals.Add("turtle");
        animals.Add("zebra");
        animals.Add("giraffe");
        animals.Add("mouse");
        animals.Add("snake");
        animals.Add("lion");

        Console.WriteLine("\nPlease enter an animal to search for in the list.");
        string animalInput = Console.ReadLine().ToLower();

        if (animals.Contains(animalInput))
        {
            Console.WriteLine(animalInput + ": index {0}",
            animals.IndexOf(animalInput));
        }
        else
        {
            Console.WriteLine("The animal you entered is not in the list.");
        }


        //foreach (string animal in animals)
        //{
        //    if (animal.Contains(animalInput))
        //    {
        //        Console.WriteLine(animalInput + ": index {0}",
        //        animals.IndexOf(animalInput));
        //        break;
        //    }
        //}

        List<string> names = new List<string>();
        names.Add("becky");
        names.Add("john");
        names.Add("blake");
        names.Add("jasmine");
        names.Add("john");
        names.Add("raul");
        names.Add("marissa");
        names.Add("xavier");

        Console.WriteLine("\nPlease enter a name to search for in the list.");
        string nameInput = Console.ReadLine().ToLower();
        bool nameIsFound = names.Contains(nameInput);
        nameIsFound = false;

        for (int i = 0; i < names.Count; i++)
        {
            if (names[i].Contains(nameInput))
            {
                Console.WriteLine(nameInput + "\n");
                nameIsFound = true;
            }
        }
        if (!nameIsFound)
        {
            Console.WriteLine("The name you entered was not found. \n");
        }




        List<string> newName = new List<string>();
        var uniqueNames = names.Distinct();

        foreach (string name in names)
        {
            if (!newName.Contains(name))
            {
                newName.Add(name);
                Console.WriteLine(name + " has not been seen already.");
            }
            else
            {
                Console.WriteLine(name + " has already been seen.");
            }
        }

        //IEnumerable<string> duplicates = names.GroupBy(x => x)
        //                                    .Where(g => g.Count() > 1)
        //                                    .Select(x => x.Key);

        //if (names.Distinct().Count() != names.Count())
        //{
        //    foreach (string name in uniqueNames)
        //    {
        //        Console.WriteLine(name);
        //    }
        //    foreach (string duplicate in duplicates)
        //    {
        //        Console.WriteLine(duplicate + " has already appeared in the list.");
        //    }
        //}
        Console.ReadLine();
    }
}

