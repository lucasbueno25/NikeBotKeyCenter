using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Domain.Models;
using webapi.Domain.Repositories.LibraryBook;

namespace web.api.V1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/configuration")]
    public class LibraryController
    {
        private readonly IKeyCenterService _keyService;
        public LibraryController(IKeyCenterService keyService)
        {
            _keyService = keyService;
        }

        [Route("ValidKey")]
        [HttpGet]
        public bool ValidKey(string keyValue)
        {
            return _keyService.ValidKey(keyValue);
        }

        
    }
}