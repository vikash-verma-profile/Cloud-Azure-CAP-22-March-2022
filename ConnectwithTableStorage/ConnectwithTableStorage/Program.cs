using Azure;
using Azure.Data.Tables;
using System;

namespace ConnectwithTableStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //this is for getting table names
            // var client = new TableServiceClient(new Uri("https://levelupsolutions007.table.core.windows.net"), new TableSharedKeyCredential("levelupsolutions007", "ejW9TYX27jNYPr8KP2IwxOQT1fo45ZlIogFiJBk934cozluWtiq3vvk6BpMgimsBjWSvBdcoq/MM+ASty9q3YA=="));
            //  Pageable<TableItem> querytableresult = client.Query(filter: $"TableName eq 'sample'");
            
            //This is to get data from table
            var client = new TableClient(new Uri("https://levelupsolutions007.table.core.windows.net"),"sample", new TableSharedKeyCredential("levelupsolutions007", "ejW9TYX27jNYPr8KP2IwxOQT1fo45ZlIogFiJBk934cozluWtiq3vvk6BpMgimsBjWSvBdcoq/MM+ASty9q3YA=="));

            Pageable<TableEntity> querytableresult = client.Query<TableEntity>();
            foreach (TableEntity item in querytableresult)
            {
                Console.WriteLine(item.GetString("Name"));
            }
        }
    }
}
