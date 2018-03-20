namespace interview.Data
{
    public class ProductRepository : IProductRepository
    {
        public int[] DeleteProducts(int[] products, int[] positionToDel)
        {
            //calculate number of deletion
            var ids = new int[products.Length - positionToDel.Length];
            var index = 0;
            for (int j = 0; j < positionToDel.Length; j++)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (i != positionToDel[j] - 1)
                    {
                        ids[index] = products[i];
                        index++;
                    }
                }
            }
            //return ids
            return ids;
        }

        public int[] SortingNumber(int[] ids)
        {
             for (int pass = 1; pass < ids.Length; pass++)
            {
                for (int i = 0; i < ids.Length - pass; i++)
                {
                    if (ids[i] < ids[i + 1])
                    {
                        // Exchange elements
                        int tempVal = ids[i];
                        ids[i] = ids[i + 1];
                        ids[i + 1] = tempVal;
                    }
                }
            }
            return ids;
        }
    }
}