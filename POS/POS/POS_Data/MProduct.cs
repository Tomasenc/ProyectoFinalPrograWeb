using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_BL;
using POS_Entitiy;
using ServiceStack.OrmLite;
using System.Data;

namespace POS_Data
{
    public class MProduct : IProduct
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public MProduct()
        {
            _conexion = new OrmLiteConnectionFactory(DBAccess.Default.connection, SqlServerDialect.Provider);
            _db = _conexion.Open();
        }

        public void addProduct(Product pProduct)
        {
            _db.InsertOnly<Product>(new Product {
                ProductDescription = pProduct.ProductDescription, IdProductCategory = pProduct.IdProductCategory,
                                        ProductStatus = pProduct.ProductStatus }, p => new { p.ProductDescription, p.IdProductCategory, p.ProductStatus });
        }

        public Product getProduct(int idProduct)
        {
            return _db.Select<Product>("select * from Product where idProduct = "+idProduct).FirstOrDefault();
        }

        public void ModifyProduct(Product pProduct)
        {
            //_db.UpdateAdd<Product>("update Product set productDescription = '" + pProduct.ProductDescription + "', idProductCategory = " + pProduct.IdProductCategory + ", productStatus = " + pProduct.ProductStatus + " WHERE idProduct = " + pProduct.IdProduct);
            //_db.Update<Product>( new Product { ProductDescription = pProduct.ProductDescription, IdProductCategory = pProduct.IdProductCategory, ProductStatus = pProduct.ProductStatus }, p => p.IdProduct == pProduct.IdProduct);
            //("update Product set productDescription = '" + pProduct.ProductDescription + "', idProductCategory = " + pProduct.IdProductCategory.ToString() + ", productStatus = " + pProduct.ProductStatus.ToString() + " WHERE idProduct = " + pProduct.IdProduct.ToString());
            pProduct.IdProductCategory = pProduct.IdProductCategory + 1; // to prevent any changes on the idProductCategory
            _db.ExecuteSql("update Product set productDescription = '" + pProduct.ProductDescription + "', idProductCategory = " + pProduct.IdProductCategory.ToString() + ", productStatus = " + pProduct.ProductStatus.ToString() + " WHERE idProduct = " + pProduct.IdProduct.ToString());


        }

        public List<Product> ProductList()
        {
            return _db.Select<Product>("select Product.idProduct, Product.productDescription, ProductCategory.productCategoryDescription, Product.productStatus from Product inner join ProductCategory on ProductCategory.idProductCategory = Product.idProductCategory");
        }
    }
}
