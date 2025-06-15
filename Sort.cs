namespace PassgenConsole;

public class Sorter
{
    public static void Sort(int[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {

            if (array[0] > array[1])
            {
                int temp = array[0];
                array[0] = array[1];
                array[1] = temp;
            }
            else
            {
            }

            if (array[1] > array[2])
            {
                int temp = array[1];
                array[1] = array[2];
                array[2] = temp;
            }
            else
            {
            }
        }
    }
}