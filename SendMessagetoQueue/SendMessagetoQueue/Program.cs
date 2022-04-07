using Azure.Storage.Queues;
using System;

namespace SendMessagetoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertMessage("OrderId 890 is processed");
        }

        public static void InsertMessage(string message)
        {
            string connectionstring = "DefaultEndpointsProtocol=https;AccountName=levelupsolutions007;AccountKey=ejW9TYX27jNYPr8KP2IwxOQT1fo45ZlIogFiJBk934cozluWtiq3vvk6BpMgimsBjWSvBdcoq/MM+ASty9q3YA==;EndpointSuffix=core.windows.net";

            QueueClient queueClient = new QueueClient(connectionstring, "ordermanagment");

            queueClient.CreateIfNotExists();

            if (queueClient.Exists())
            {
                queueClient.SendMessage(message);
            }
            Console.WriteLine("Message Inserted");
        }
    }
}
