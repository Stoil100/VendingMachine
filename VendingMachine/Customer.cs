using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

public class Customer
{
    private decimal money = 100M;
    public decimal Money { get { return money; } set { money = value; } }

    public Customer(decimal money)
    {
        this.money = money;
    }

    public List<VendingMachine> customerInventoryList = new List<VendingMachine>();

}
