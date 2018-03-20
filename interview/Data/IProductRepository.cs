namespace interview.Data
{
    public interface IProductRepository
    {
         int[] SortingNumber(int[] ids);
         int[] DeleteProducts(int[] products, int[] positionToDel);
    }
}