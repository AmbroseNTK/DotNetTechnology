using System;
using System.Xml.Linq;
using System.Linq;

namespace W11
{
    class Program
    {
        static void Main(string[] args)
        {

            XDocument xDocument = XDocument.Load("PurchaseOrder.xml");

            //Ex1: Xuất ra danh sách PartNumber
            Console.WriteLine("DS PartNumber");
            (
                xDocument
                .Descendants("Item")
                .Select((item) => item.Attribute("PartNumber").Value))
                .ToList()
                .ForEach((item) => Console.WriteLine(item)
                );

            //Ex2: Xuất danh sách ProductName có USPrice > 100
            Console.WriteLine("USPrice >100");
            (
                xDocument
                .Descendants("Item")
                .Where((item) => double.Parse(item.Element("USPrice").Value) > 100)
                .Select((item) => item.Element("ProductName").Value))
                .ToList()
                .ForEach((item) => Console.WriteLine(item)
                );
            //Ex3: Tìm ProductName có Quantity cao nhất
            Console.WriteLine("Quantity cao nhat");
            (
                xDocument
                .Descendants("Item")
                .Where(
                (item) =>
                int.Parse(item.Element("Quantity").Value) ==
                (xDocument
                .Descendants("Item")
                .Select(
                    (maxItem) =>
                    int.Parse(maxItem.Element("Quantity").Value)))
                    .Max())
                    .Select(
                (item) =>
                item.Element("ProductName").Value))
                .ToList()
                .ForEach(
                (item) =>
                Console.WriteLine(item)
                );

            //Ex4: Đếm số lượng khách hàng Shipping
            Console.WriteLine("Khach hang Shipping");
            (
                xDocument
                .Descendants("Address")
                .Where(
                    (address) =>
                    address.Attribute("Type").Value.Equals("Shipping"))
                    .Select(
                    (item) =>
                    item.Element("Name").Value))
                    .ToList()
                    .ForEach(
                (customer) =>
                Console.WriteLine(customer)
                );

            //Ex5: Xuất danh sách địa chỉ khách hàng Billing
            Console.WriteLine("DS Khach hang Billing");
            (
                xDocument
                .Descendants("Address")
                .Where(
                    (item) =>
                    item.Attribute("Type").Value.Equals("Billing"))
                    .Select(
                    (customer) =>
                    customer.Element("Street").Value + ", " + customer.Element("City").Value + ", " + customer.Element("Country").Value
                    ))
                    .ToList()
                    .ForEach(
                (address) =>
                Console.WriteLine(address)
                );
            //Ex6: Xuất danh sách các khách hàng Shipping theo Country
            Console.WriteLine("Shipping theo country");

            (
                xDocument
                .Descendants("Address")
                .Where(
                    (item) =>
                    item.Attribute("Type").Value.Equals("Shipping"))
                    .GroupBy(
                    (item) =>
                    item.Element("Country").Value)
                    .Select(
                    (group) => new { group.Key, Value = group })
                    )
                    .ToList()
                    .ForEach(
                (customerGroup) =>
                {
                    Console.WriteLine(customerGroup.Key);
                    customerGroup.Value.ToList()
                    .ForEach(
                        (customer) =>
                        Console.WriteLine("\t" + customer.Element("Name").Value)
                        );
                }
                );
            Console.Read();
        }
    }
}