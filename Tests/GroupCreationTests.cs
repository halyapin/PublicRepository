using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace ZaebalTestom
{

    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            
            GroupData group = new GroupData("ssss");
            group.Header = "ssss";
            group.Footer = "aaaa";
            app.Groups.CreateGroup(group);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            app.Groups.CreateGroup(group);

        }



    }
}
