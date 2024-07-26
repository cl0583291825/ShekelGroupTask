using ENV;
using ENV.Data;

namespace Northwind.Views.Controls.Test
{
    public class Test : UIControllerBase
    {
        public readonly Models.Products Products = new Models.Products() { AllowRowLocking = true };

        public Test()
        {
            Title = "Test";
            From = Products;
            Where.Add(Products.ProductName.StartsWith("C"));
        }

        public void Run()
        {
            Execute();
        }

        protected override void OnLoad()
        {
            View = () => new Views.TestView(this);
        }
    }
}