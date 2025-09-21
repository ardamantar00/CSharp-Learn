using CSharpEgitimKampi301.DataAccsessLayer.Abstract;
using CSharpEgitimKampi301.DataAccsessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccsessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDal

    {
    }
}
