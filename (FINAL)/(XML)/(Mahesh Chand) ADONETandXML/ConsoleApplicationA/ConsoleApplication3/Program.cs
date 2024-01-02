using System;
using System.IO;
using System.Data;

// https://www.c-sharpcorner.com/uploadfile/mahesh/ado-net-and-xml/

namespace XmlAndDataSetsampB2
{
    class XmlAndDataSetSampCls
    {
        public static void Main()
        {

            try
            {
                // Create a DataSet, namespace and Student table
                // with Name and Address columns
                DataSet ds = new DataSet("DS")
                {
                    Namespace = "StdNamespace"
                };
                DataTable stdTable = new DataTable("Student");
                DataColumn col1 = new DataColumn("Name");
                DataColumn col2 = new DataColumn("Address");
                stdTable.Columns.Add(col1);
                stdTable.Columns.Add(col2);
                ds.Tables.Add(stdTable);

                //Add student Data to the table
                DataRow newRow;

                newRow = stdTable.NewRow();
                newRow["Name"] = "Gerardo Tordoya";
                newRow["Address"] = "Jujuy, Argentina";
                stdTable.Rows.Add(newRow);

                newRow = stdTable.NewRow();
                newRow["Name"] = "Mahesh Chand";
                newRow["Address"] = "Meadowlake Dr, Dtown";
                stdTable.Rows.Add(newRow);
                
                newRow = stdTable.NewRow();
                newRow["Name"] = "Mike Gold";
                newRow["Address"] = "NewYork";
                stdTable.Rows.Add(newRow);
                
                newRow = stdTable.NewRow();
                newRow["Name"] = "Mel Gibson";
                newRow["Address"] = "Sidney, Australia";
                stdTable.Rows.Add(newRow);
                
                ds.AcceptChanges();
                // Create a new StreamWriter
                // I’ll save data in stdData.Xml file
                StreamWriter myStreamWriter = new
                StreamWriter(@"stdData.xml");
                // Writer data to DataSet which actually creates the file
                ds.WriteXml(myStreamWriter);
                myStreamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.ToString());
            }

            Console.ReadLine();
            return;
        }
    }
}
