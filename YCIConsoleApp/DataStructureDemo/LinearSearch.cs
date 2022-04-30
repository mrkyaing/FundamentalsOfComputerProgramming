namespace DataStructureDemo
{
  public  class LinearSearch
    {
        //using for loop 
        public int SearchKey(int searchKey,int[] Items)
        {
               int N = Items.Length;            
                for ( int i = 0; i < N; i++)
                {
                    if (Items[i] == searchKey)
                        return i;//found key in array.
                }
            return -1;//key not found in array .
        }
        //using while loop 
        public int FindKey(int findKey,int[] numbers)
        {
            int i = 0;
            int n = numbers.Length;
            if (i > n) 
                return -1;           
            while (i < n)
            {
                if (numbers[i] == findKey) 
                    return i;
                i++;
            }
            return -1;
        }
    }
}
