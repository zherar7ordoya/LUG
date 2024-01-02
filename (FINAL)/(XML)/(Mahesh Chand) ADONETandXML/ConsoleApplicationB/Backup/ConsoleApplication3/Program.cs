using System;
using System.IO;
using System.Xml;
using System.Data;

namespace XmlAndDataSetsampB2
{
    class XmlAndDataSetSampCls
    {
        public static void Main()
        {

            DataSet ds = new DataSet("DS");
            ds.Namespace = "StdNamespace";
            DataTable stdTable = new DataTable("Students");
            DataColumn col1 = new DataColumn("Name");
            DataColumn col2 = new DataColumn("Address");
            stdTable.Columns.Add(col1);
            stdTable.Columns.Add(col2);
            ds.Tables.Add(stdTable);
            // Add student Data to the table
            DataRow newRow; newRow = stdTable.NewRow();
            newRow["Name"] = "Mahesh chand";
            newRow["Address"] = "Meadowlake Dr, Dtown";
            stdTable.Rows.Add(newRow);
            newRow = stdTable.NewRow();
            newRow["Name"] = "Mike Gold";
            newRow["Address"] = "NewYork";
            stdTable.Rows.Add(newRow);
            ds.AcceptChanges();
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            ds.WriteXmlSchema(writer);


            Console.ReadLine();
            return;

        }
    }
}
