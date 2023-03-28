namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train? train = null;
            try
            {
                train = new Train(1, TrainType.Passenger, "Kuiv  - Odessa", new DateTime(2022, 3, 12, 12, 22, 22), new DateTime(2022, 3, 12, 18, 33, 00),
                                      new Сarriage(1, CType.Reserved, 50, 45),
                                      new Сarriage(5, CType.Reserved, 50, 30),
                                      new Сarriage(7, CType.Reserved, 50, 25),
                                      new Сarriage(12, CType.Reserved, 50, 50),
                                      new Сarriage(3, CType.Сompartment, 25, 24),
                                      new Сarriage(8, CType.Сompartment, 25, 20));
            }
            catch (Exception exc) { Console.WriteLine(exc.Message); }
            
            Console.WriteLine(train?.PassAvr);
        }
    }
}