using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webapi.Domain.Models;
using webapi.Domain.Repositories.LibraryBook;
using webapi.Infra.Data.Context;

namespace webapi.Infra.Data.Repositories.LibraryBook
{
    public class KeyCenterService : IKeyCenterService
    {
        private readonly KeyCenterContext _context;
        public KeyCenterService(KeyCenterContext Context)
        {
            _context = Context;
        }

        public KeyCenterService()
        {

        }

        public KeyObject GetKeyById(int idKey)
        {
            var result = _context.RegisteredKeys.Where(x => x.IdKey == idKey).FirstOrDefault();

            return result;
        }

        public bool ValidKey(string keyValue)
        {
            bool result = false;

            using (var db = _context)
            {
                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    var foundKey = db.RegisteredKeys.SingleOrDefault(b => b.KeyValue == keyValue && b.KeyUsedTimestamp == null && b.KeyClosedTimestamp == null);

                    if (foundKey != null)
                    {
                        foundKey.KeyUsedTimestamp = DateTime.Now;

                        db.RegisteredKeys.Update(foundKey);
                        db.SaveChanges();

                        result = true;
                    }
                    else
                    {
                        result = false;
                    }

                    dbContextTransaction.Commit();
                }
            }

            return result;
        }
    }
}
