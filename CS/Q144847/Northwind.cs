using System;
using DevExpress.Xpo;
namespace Northwind {

    public class Orders : XPLiteObject {
        int fOrderID;
        [Key(true)]
        public int OrderID {
            get { return fOrderID; }
            set { SetPropertyValue<int>("OrderID", ref fOrderID, value); }
        }
        string fCustomerID;
        [Size(5)]
        public string CustomerID {
            get { return fCustomerID; }
            set { SetPropertyValue<string>("CustomerID", ref fCustomerID, value); }
        }
        int fEmployeeID;
        public int EmployeeID {
            get { return fEmployeeID; }
            set { SetPropertyValue<int>("EmployeeID", ref fEmployeeID, value); }
        }
        DateTime fOrderDate;
        public DateTime OrderDate {
            get { return fOrderDate; }
            set { SetPropertyValue<DateTime>("OrderDate", ref fOrderDate, value); }
        }
        DateTime fRequiredDate;
        public DateTime RequiredDate {
            get { return fRequiredDate; }
            set { SetPropertyValue<DateTime>("RequiredDate", ref fRequiredDate, value); }
        }
        public Orders(Session session) : base(session) { }
        public Orders() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
