using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Day1_Homework.Models
{
    public class AddRecordService
    {
        private AssetsModel _db;
        public AddRecordService()
        {
            _db = new AssetsModel();
        }

        public void AddRecord(AccountBook accountBook)
        {
            _db.AccountBook.Add(accountBook);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}