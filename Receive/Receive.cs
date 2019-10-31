using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace Receive
{
    class Program
    {
        static void Main(string[] args)
        {

           var factory = new ConnectionFactory(){
               HostName = "35.238.95.239",
               Port = 5672,
               UserName = "monitor",
               VirtualHost = "/"
           };
           using(var connection = factory.CreateConnection())
           using(var channel = connection.CreateModel()){
               channel.QueueDeclare(
                   queue: "fila_msgs_monitoria",
                   durable: false,
                   exclusive: false,
                   autoDelete: false
               );
               var consumer = new EventingBasicConsumer(channel);
               consumer.Received += (ModuleHandle,ea)=>
               {
                   var body = ea.Body;
                   var messagem = Encoding.UTF8.GetString(body);
                   Console.WriteLine(" [x] Received {0}", messagem);
               };
               channel.BasicConsume(
                   queue: "fila_msgs_monitoria",
                   autoAck: true,
                   consumer: consumer
               );
               Console.WriteLine(" Press [enter] to exit.");
               Console.ReadLine();
           }
            
        }
    }
}
