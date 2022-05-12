using ServiceStack.Redis;
using System;

namespace RedisWithDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "localhost:6379";

            var key1 = Guid.NewGuid();
            var key2 = Guid.NewGuid();


            var client1 = new Client(key1) { Document = "21211212", Name = "Rick" };
            var client2 = new Client(key2) { Document = "33454333", Name = "Lisa" };

            //CRUD
            using (var redisClient = new RedisClient(host))
            {
                //CREATE
                redisClient.Set<Client>(client1.Key.ToString(), client1);
                redisClient.Set<Client>(client2.Key.ToString(), client2);


                //GET
                var clientx2 = redisClient.Get<Client>(key2.ToString());
                var clientx1 = redisClient.Get<Client>(key1.ToString());
                Console.WriteLine(clientx2.Name);
                Console.WriteLine(clientx1.Name);

                
                //UPDATE
                var client1Alteracao = new Client(key1) { Document = "21211212", Name = "Rick Alterado" };
               
                redisClient.Set<Client>(client1.Key.ToString() , client1Alteracao);
                
                clientx1 = redisClient.Get<Client>(key1.ToString());
                
                Console.WriteLine(clientx1.Name);



                //DELETE
                var clientx1Remove = redisClient.Remove(key1.ToString());
                
                clientx1 = redisClient.Get<Client>(key1.ToString());
                
                if (clientx1Remove && clientx1 == null)
                {
                    Console.WriteLine("Cliente foi removido");
                }
                else
                {
                    Console.WriteLine("Cliente não foi removido");
                }
                
            }
        }
    }
}
