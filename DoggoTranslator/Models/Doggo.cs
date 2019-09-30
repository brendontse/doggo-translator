namespace DoggoStone
{
    public class Stone
    {
    
        public static bool IsAnE(string e)
        {
            char[] array = e.ToCharArray();
            if (array[array.Length-1] =='e')
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}