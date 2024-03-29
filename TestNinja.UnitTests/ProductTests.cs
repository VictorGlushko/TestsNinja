﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ProductTests
    {

        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            var product = new Product {ListPrice = 100};
            var result = product.GetPrice(new Customer {IsGold = true});
            Assert.That(result,Is.EqualTo(70));
        }
    }
}
