using Xunit;
using DocumentsConsole.Containers;
using DocumentsConsole.Interfaces;
using DocumentsConsole.Types;
using ListLibrary;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace UnitTests;
public partial class UnitTest1
{
    public bool TestMethod1()
    {
        ListLib<Document> list = new ListLib<Document>();
        list.Add(
            new Memo("Memo of David", null,"visa",new DateOnly(2001,1,1),"Content")
        );
        list.Add(
            new Statement("St", "visa")
        );
        list.Add(
            new Memo()
        );

        Document[] array = list.ToArray();
        
        return true;
    }
    public bool TestMethod2()
    {
        ListLib<Document> list = new ListLib<Document>();

        Document[] array = list.ToArray();

        return true;
    }
    [Fact]
    public void Test1()
    {
        Assert.True(TestMethod1());
    }
    [Fact]
    public void Test2()
    {
        Assert.True(TestMethod2());
    }
}