namespace ParticularPresence.WeatherApplication.Data.Migrations
{
    using ParticularPresence.WeatherApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ParticularPresence.WeatherApplication.Data.WeatherContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ParticularPresence.WeatherApplication.Data.WeatherContext context)
        {
            //context.Employees.AddOrUpdate(new Employee{FirstName="John",LastName="Brown",Address="20 Wayward Road",City="Kingston",Country="Jamaica",EmailAddress="JBrown@gmail.com",Role=" IT Personnel" ,TelephoneNo=8763456234,AddressLocation="Kingston 10"});
            //context.Employees.AddOrUpdate(new Employee{FirstName="Mary",LastName="Smith",Address="5 JohnStone Road",City="Kingston",Country="Jamaica",EmailAddress="MSmith@gmail.com",Role=" IT Personnel" ,TelephoneNo=8762345678,AddressLocation="Kingston 5"});
            //context.Employees.AddOrUpdate(new Employee{FirstName="Carl",LastName="Wilson",Address=" 12 Main Street ",City="Montego Bay",Country="Jamaica",EmailAddress="CWilson@gmail.com",Role=" Manufacturing Worker" ,TelephoneNo=8766782345,AddressLocation="Ocho Rios"});
            //context.Employees.AddOrUpdate(new Employee{FirstName="Anne",LastName="Johnson",Address="5 Rocky Road",City="Kingston",Country="Jamaica",EmailAddress="AJohnson@gmail.com",Role=" IT Personnel" ,TelephoneNo=8764473532,AddressLocation="Kingston 20"});
            //context.Employees.AddOrUpdate(new Employee{FirstName="Mark",LastName="Gold",Address="12 Richard Drive",City="Montego Bay",Country="Jamaica",EmailAddress="MGold@gmail.com",Role=" Manufacturing Worker" ,TelephoneNo=8769345235,AddressLocation="Ocho Rios"});
            //context.Employees.AddOrUpdate(new Employee{FirstName="Roger",LastName="Green",Address="5 Olympic Way",City="Montego Bay",Country="Jamaica",EmailAddress="RGreen@gmail.com",Role= " Manufacturing Worker", TelephoneNo=8767635927,AddressLocation="Ocho Rios"});
        }
    }
}
