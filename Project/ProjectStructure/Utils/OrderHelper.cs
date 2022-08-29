using System;

namespace ProjectStructure.Util
{
    public class OrderHelper
    {
        public string GenerateOrderNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);
            return $"C{DateTime.Now.ToString("yyyyMMdd")}{randomNumber.ToString().PadLeft(4, '0')}";
        }
    }
}
