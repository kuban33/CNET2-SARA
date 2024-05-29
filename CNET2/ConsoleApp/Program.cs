using ConsoleApp;
using ConsoleApp.Logger;
using PersonData;
using PersonModel;
using System.Net.Http.Json;

ISimpleLogger logger = new SimpleConsoleLogger();

var data = await PersonApiCall.GetPeople(logger);

Console.WriteLine($"pocet osob: {data.Count()}");

Console.ReadLine();