using System;
using Consumer.ServiceReference1;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonServiceClient client=new PersonServiceClient();
            Person nullPerson = client.GetPerson(0);
            Person person = client.GetPerson(1);

            Console.WriteLine(nullPerson == null ? "Person object is null" : nullPerson.Name);

            Console.WriteLine(person.Name);

            try
            {
                Console.WriteLine(nullPerson.Name);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception"+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
