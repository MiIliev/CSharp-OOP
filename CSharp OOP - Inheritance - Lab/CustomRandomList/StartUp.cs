namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList randomList = new RandomList();
            randomList.Add("1");
            randomList.Add("2");
            randomList.Add("3");
            randomList.Add("4");

            randomList.RandomString();
         }
    }

}