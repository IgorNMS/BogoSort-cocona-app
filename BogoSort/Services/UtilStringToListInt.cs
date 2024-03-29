namespace BogoSort.Services
{
    public interface IUtilStringService
    {
        public List<int> ToListInt(string numbers);
    }
    public class UtilStringToListInt : IUtilStringService
    {
        public List<int> ToListInt(string numbers)
        {
            string[] parts = numbers.Split(',');
            List<int> listNumber = new List<int>();
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    listNumber.Add(number);
                }
                else
                {
                    listNumber.Add(0);
                }
            }

            return listNumber;
        }
    }
}
