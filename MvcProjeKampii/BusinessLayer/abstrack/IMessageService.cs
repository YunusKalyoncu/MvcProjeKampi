﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.abstrack
{
  public  interface IMessageService
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void MessageAdd(Message message);
        Message GetByID(int id);
        void MessageDelete(Message message);
        void MessageUpdate(Message message);
    }
}
