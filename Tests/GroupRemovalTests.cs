using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace ZaebalTestom
{
   [TestFixture]
    public class GroupRemovalTests : TestBase
    {
       
        [Test]
        public void GroupRemovalTest()
        {

            app.Groups.Remove(1);
         

        }
    }
}
