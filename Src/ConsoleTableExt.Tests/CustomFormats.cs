using NUnit.Framework;
using System;

namespace ConsoleTableExtNet5.Tests
{
    [TestFixture]
    public class CustomFormats
    {
        [Test]
        public void DefaultFormatWithDataTable()
        {
            var strBuilder =
                ConsoleTableBuilder
                .From(SampleData.SampleTableData)
                .WithTitle("TITLE")
                .WithPaddingLeft(String.Empty)
                .WithCharMapDefinition()
                .Export();

            Assert.IsTrue(strBuilder.ToString() == @"                                        TITLE                                         
Name           Position                      Office        Age Start Date             
Airi Satou     Accountant                    Tokyo         33  5/9/2017 12:00:00 AM   
Angelica Ramos Chief Executive Officer (CEO) New York      47  1/12/2017 12:00:00 AM  
Ashton Cox     Junior Technical Author       London        46  4/2/2017 12:00:00 AM   
Bradley Greer  Software Engineer             San Francisco 28  11/15/2017 12:00:00 AM 
");
            var lines = strBuilder.ToString().Split('\n');
            Assert.IsTrue(lines.Length == 7);
        }

    }
}