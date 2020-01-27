using System.Linq;
using Postgres;
using System;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

public class Program
{
    public IProduct _context;
    public static  void Main()
    {
        
    }
    private static void RegisterServices()
    {
        var collection = new ServiceCollection();
        collection.AddScoped<IProduct, Products>();
    }
    public  interface IProduct
    {
            List<Product> GetAll();
    }
    public class Products : IProduct
    {
        private DataContext _context;
        public List<Product> GetAll()
        {
           return  _context.Products.ToList();
        }
    }


}