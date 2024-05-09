using System;
using System.Collections.Generic;
using JAlbertKnowledgeCheckSD2;

Console.WriteLine("Please enter the amount of records you would like to add.");
var userInput = string.Empty;
var recordList = new List<GraphicNovels>();
var numberOfRecords = int.Parse(Console.ReadLine());

while (userInput != "exit")

{
    for (int i = 0; i < numberOfRecords; i++)
    {
        // In this loop, populate the object's properties using Console.ReadLine()
        var graphicNovels = new GraphicNovels();


        Console.WriteLine("Please enter the title.");
        graphicNovels.Title = Console.ReadLine();
        Console.WriteLine("Title: " + graphicNovels.Title);

        recordList.Add(graphicNovels);

        Console.WriteLine("Please enter the story description.");
        graphicNovels.Description = Console.ReadLine();
        Console.WriteLine("Description: " + graphicNovels.Description);

        Console.WriteLine("Please enter the author name.");
        graphicNovels.Author = Console.ReadLine();
        Console.WriteLine("Author: " + graphicNovels.Author);

        Console.WriteLine("Please enter the number of pages.");
        graphicNovels.Pages = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Pages: " + graphicNovels.Pages);

        Console.WriteLine("Please enter the series name.");
        graphicNovels.SeriesName = Console.ReadLine();
        Console.WriteLine("Series name: " + graphicNovels.SeriesName);

        Console.WriteLine("Please enter the hero name.");
        graphicNovels.HeroName = Console.ReadLine();
        Console.WriteLine("Hero name: " + graphicNovels.HeroName);

        Console.WriteLine("Please enter the volume number.");
        graphicNovels.VolumeNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Volume number: " + graphicNovels.VolumeNumber);

        foreach (var graphicNovel in recordList)
        {
            Console.WriteLine(graphicNovel.Title);
        }

    }
    if (userInput == "exit")
    {
        Console.WriteLine("Goodbye. Application closing.");
        Environment.Exit(0);
    }
    Console.WriteLine("Enter the number of records you would like to add or type exit to quit.");
    userInput = Console.ReadLine();
}

// Print out the list of records using Console.WriteLine()
