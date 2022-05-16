using CKK.Project._1;
using System;
namespace CKK.Project
{
      public class program
      {
        static void Main(string[] args)
        { }
                public class StoreItem
                {
                    private Product _product;
                    private int _quantity;

                public StoreItem(Product product, int quantity)
                {
                        _product = product;
                        _quantity = quantity;
                }
                public int GetQuantity()
                {
                        return _quantity;
                }

                public void SetQuantity(int quantity)
                {
                        _quantity = quantity;
                }

                public Product GetProduct()
                {
                        return _product;
                }
           }
            
      }
}