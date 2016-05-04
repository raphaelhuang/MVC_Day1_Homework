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

        public AccountBook GetSingle(Guid id)
        {
            return _db.AccountBook.Find(id);
        }

        public void AddRecord(AccountBook accountBook)
        {
            _db.AccountBook.Add(accountBook);
        }

        public void EditRecord(AccountBook pageData, AccountBook oldData)
        {
            oldData.Categoryyy = pageData.Categoryyy;
            oldData.Amounttt = pageData.Amounttt;
            oldData.Dateee = pageData.Dateee;
            oldData.Remarkkk = pageData.Remarkkk;
        }

        public void DeleteRecord(Guid id)
        {
            var record = GetSingle(id);
            _db.AccountBook.Remove(record);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}