namespace vending_Machines
{
    internal class Program
    {
        public static List<int> MinimumCoins(List<int> coins,int amount)
        {
            coins.Sort((a, b) => b.CompareTo(a));
            List<int> result = new List<int>();
            for(int iterator=0; iterator<coins.Count; iterator++)
            {
                int coin = coins[iterator];
                while (coin <= amount)
                {
                    result.Add(coin);
                    amount -= coin;
                }
                if (amount == 0)
                {
                    break;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count of coin denominations:");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the coin denominations:");
            List<int> coins = new List<int>();
            for (int iterator=0;iterator<count;iterator++)
            {
                coins.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Enter the amount of change:");
            int amount=int.Parse(Console.ReadLine());

            List<int> outPut=MinimumCoins(coins, amount);
          
            Console.WriteLine($"The minimum coins required to return {amount} cents are:");

            for(int iterator=0;iterator<outPut.Count;iterator++) {
                Console.WriteLine(outPut[iterator]);
            }

        }
    }
}