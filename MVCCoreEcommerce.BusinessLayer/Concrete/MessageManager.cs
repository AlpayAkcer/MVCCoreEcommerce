﻿using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
            _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetByID(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetAll();
        }

        public void TUpdate(Message t)
        {
            _messageDal.Update(t);
        }
    }
}
