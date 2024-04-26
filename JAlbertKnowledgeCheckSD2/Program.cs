using System;
using System.Collections.Generic;
using JAlbertKnowledgeCheckSD2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());
var recordList = new List<GraphicNovels>();

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

    foreach(var graphicNovel in recordList)
{
        Console.WriteLine(graphicNovel.Title);
    }
}



// Print out the list of records using Console.WriteLine()
