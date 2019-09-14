
namespace ACM.BL.Product.Repository
{
    public class ProductRepository
    {
        public Model.Product Retrieve(int productId)
        {
            if(2.Equals(productId))
                return new Model.Product(productId)
                {
                    ProductName = "Coxinha",
                    ProductDescription = "Massa de mandioca e recheio de flango",
                    CurrentPrice = 3M
                };
            return new Model.Product(productId);
        }

        public bool Save(Model.Product product)
        {
            if (!product.HasChanges) return true;

            if (!product.IsValid) return false;
            if (product.IsNew)
            {
                //Insert
            }
            else
            {
                //Update
            }

            return true;
        }
    }
}
