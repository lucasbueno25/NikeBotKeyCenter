using System;
using System.Collections.Generic;
using System.Text;
using webapi.Domain.Models;

namespace webapi.Domain.Repositories.LibraryBook
{
    public interface IKeyCenterService
    {
        KeyObject GetKeyById(int idKey);
        bool ValidKey(string keyCode);
    }
}
