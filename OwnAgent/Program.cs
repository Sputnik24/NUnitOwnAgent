using System.Xml;
using NUnit.Engine;

try {
    ITestEngine testEngine = TestEngineActivator.CreateInstance();
    TestPackage package = new TestPackage("../../../../Tests/bin/Debug/net8.0/Tests.dll");
    ITestRunner runner = testEngine.GetRunner(package);
    XmlNode? explorer = runner.Explore(TestFilter.Empty);
    Console.WriteLine(explorer.OuterXml);
}
catch (Exception e) {
    Console.WriteLine(e);
}

Console.ReadKey();