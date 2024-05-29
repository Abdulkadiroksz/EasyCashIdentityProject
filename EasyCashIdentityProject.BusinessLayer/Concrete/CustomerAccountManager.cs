using EasyCashIdentitiyProject.DataAccsessLayer.Abstract;
using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        void IGenericService<CustomerAccount>.TDelete(CustomerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        CustomerAccount IGenericService<CustomerAccount>.TGetById(int id)
        {
            return _customerAccountDal.GetByID(id);
        }

        List<CustomerAccount> IGenericService<CustomerAccount>.TGetList()
        {
            return _customerAccountDal.GetList();
        }

        void IGenericService<CustomerAccount>.TInsert(CustomerAccount t)
        {
            _customerAccountDal.Insert(t);
        }

        void IGenericService<CustomerAccount>.TUpdate(CustomerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
