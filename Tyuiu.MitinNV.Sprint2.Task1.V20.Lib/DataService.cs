using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MitinNV.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            if (a == (c ^ b) - 97)
            {
                result[0] = false;
            }

            if (b == 155)
            {
                result[1] = false;
            }

            if (c == 345 || d == 17)
            {
                result[2] = false;
            }

            if (a == 242 && c == 456)
            {
                result[3] = true;
            }

            if (a > 100 && c < 1000)
            {
                result[4] = true;
            }

            if (a >= 242)
            {
                result[5] = true;
            }

            return result;
        }
    }
}
