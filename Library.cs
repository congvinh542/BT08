using System.Collections.Generic;
class Library
{
    public static int Bai01(int[] list01)
    {
        int result = -1;
        foreach (var item in list01)
        {
            result += item;
        }
        return result;
    }
    public static int[] Bai02(int[] list02, int tagets)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < list02.Length; i++)
        {
            for (int j = i + 1; j < list02.Length; j++)
            {
                if (list02[i] + list02[j] == tagets)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
    public static int[] Bai03(int[] list03)
    {
        List<int> result = new List<int>();
        foreach (var item in list03)
        {
            if (!result.Contains(item))
            {
                result.Add(item);
            }
        }
        return result.ToArray();
    }

    public static int[] Bai04(int[] list04)
    {
        int count = 0;
        List<int> result = new List<int>();
        for(int i = 0; i < list04.Length; i++){
            count = 0;
            for (int j = 0; j < list04.Length; j++){
                if(list04[i] == list04[j]){
                    count++;
                }
            }
            if (count > 1 && !result.Contains(list04[i]))
            {
                result.Add(list04[i]);
            }
        }
        return result.ToArray();
    }

    public static int Bai05(int[] list05)
    {
        int minPrice = int.MaxValue;
        int result = 0;
        for (int i = 0; i < list05.Length; i++)
        {
            if (list05[i] < minPrice)
            {
                minPrice = list05[i];
            }

            else if (list05[i] - minPrice > 0)
            {
                result = list05[i] - minPrice;
            }
        }
        return result;
    }
}

