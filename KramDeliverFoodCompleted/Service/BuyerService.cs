using KramDeliverFoodCompleted.Interaction;
using KramDeliverFoodCompleted.Models;

namespace KramDeliverFoodCompleted.Service
{
    public class BuyerService
    {
        private readonly BuyerReader _buyerReader;
        private readonly ProductService _product;
        private readonly OrderService _order;
        private readonly Order _checkout;

        public BuyerService(BuyerReader buyerReader, ProductService product, OrderService order, Order checkout)
        {
            _buyerReader = buyerReader;
            _product = product;
            _order = order;
            _checkout = checkout;
        }

        public void MakeOrder()
        {
            //BuyerMessager.ShowProducts(_product.GetProducts());
            //BuyerMessager.BuyInstruction();

            //while (true)
            //{
            //    var input = _buyerReader.MakeInput();

            //    while (!_product.IsRealProductId(input))
            //        input = _buyerReader.MakeInput();

            //    _order.AddProductToOrder(input);

            //    if (!BuyerReader.BuyMoreProducts())
            //        break;

            //    BuyerMessager.BuyInstruction();
            //}
        } 

        public void MakeCheckout()
        {
            //BuyerMessager.BuyerPhone();

            //var phoneNumber = BuyerReader.EnterPhoneNumber();

            //BuyerMessager.BuyerAddress();

            //var address = BuyerReader.EnterAddress();

            //var orderedProducts = _order.GetOrderedProducts();

            //_checkout.Order = orderedProducts;
            //_checkout.Address = address;
            //_checkout.PhoneNumber = phoneNumber;

            //BuyerMessager.MakeCheckout(_checkout, address, phoneNumber);

            //BuyerMessager.ShowSuccessfulOrder();
        }
    }
}
