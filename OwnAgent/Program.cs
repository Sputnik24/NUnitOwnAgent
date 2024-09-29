using System.Xml;
using NUnit.Engine;

//string testFile = "../../../../Tests/bin/Debug/net8.0/Tests.dll"; //File.Exists true, but FileNotFound on runner.Explore
//string testFile = "../../../../../../../../Tests/bin/Debug/net8.0/Tests.dll"; //File.Exists false but Explore is working
string testFile = "D:/dev/repos/NUnitOwnAgent/Tests/bin/Debug/net8.0/Tests.dll"; //File.Exists true, Explore is not working
//string testFile = "Tests.dll"; //Works when WorkDirectory is set
Console.WriteLine($"File exists: {File.Exists(testFile)}");

try {
    ITestEngine testEngine = TestEngineActivator.CreateInstance();
    //testEngine.WorkDirectory = "D:\\dev\\repos\\NUnitOwnAgent\\Tests\\bin\\Debug\\net8.0";
    TestPackage package = new TestPackage(testFile);
    ITestRunner runner = testEngine.GetRunner(package);
    XmlNode? explorer = runner.Explore(TestFilter.Empty);
    Console.WriteLine(explorer.OuterXml);
}
catch (Exception e) {
    Console.WriteLine(e);
}

Console.ReadKey();