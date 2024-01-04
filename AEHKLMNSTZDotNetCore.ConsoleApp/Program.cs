
using AEHKLMNSTZDotNetCore.ConsoleApp.AdoDotNetExamples;
using AEHKLMNSTZDotNetCore.ConsoleApp.DapperExamples;
using AEHKLMNSTZDotNetCore.ConsoleApp.EFCore_Examples;
using AEHKLMNSTZDotNetCore.ConsoleApp.HttpClientExamples;



//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Run();
//DapperExample dapperExample = new DapperExample();
//dapperExample.Run(); 
//EFCoreExample eFCoreExample = new EFCoreExample();
//eFCoreExample.Run();

Console.WriteLine("Please wait for api...");
Console.ReadKey();

HttpClientExample httpClientExample = new HttpClientExample();
await httpClientExample.Run();

Console.ReadKey();