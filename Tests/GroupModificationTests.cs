using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace ZaebalTestom
{
 
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("");
            newData.Header = "ttt";
            newData.Footer = "qqq";

            app.Groups.Modify(1, newData);


        }
    }
}

