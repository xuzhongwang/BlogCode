using Microsoft.VisualStudio.TestTools.UnitTesting;
using T4TemplateDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TemplateDemoTests.Tests
{
    [TestClass()]
    public class AccessDBExTests
    {
        [TestMethod()]
        public void GetTablesTest()
        {
            string filePath = @"E:\localspace\codelibrary\CADTest\CADLib.Models\Data\Template.mdb";
            IDataBaseEx dataBaseEx = new AccessDBEx(filePath);
            var tables = dataBaseEx.GetTables();
            foreach (var item in tables)
            {
                var columas = dataBaseEx.GetFields(item);
                foreach (var column in columas)
                {
                    var fieldName = column.FieldName;
                    var type = column.FieldType;
                }

            }            
            
        }
    }
}