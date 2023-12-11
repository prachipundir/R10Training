namespace StateDesignPattern
{
     class Program
    {
        static void Main(string[] args)
        {
            ATMMachine AtmMachine= new ATMMachine();
            Console.WriteLine($"ATM MAchine's Current State :"+AtmMachine.AtmMachineState.GetType().Name);
            AtmMachine.EnterPin();
            AtmMachine.WithdrawCash();
            AtmMachine.EjectDebitCard();
            AtmMachine.InsertDebitCard();

            Console.WriteLine("******************************************");
            Console.WriteLine($"ATM MAchine's Current State:" + AtmMachine.AtmMachineState.GetType().Name);
            AtmMachine.EnterPin();
            AtmMachine.WithdrawCash();
            AtmMachine.InsertDebitCard();
            AtmMachine.EjectDebitCard();

            Console.WriteLine("**************************************************");
            Console.WriteLine($"ATM MAchine's Current State:" + AtmMachine.AtmMachineState.GetType().Name);



        }
    }
}