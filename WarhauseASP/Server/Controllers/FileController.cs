﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarhauseASP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileXml _filexml;

        public FileController(IFileXml filexml)
        {
            _filexml = filexml;
        }

        [HttpGet("FileXml")]
        public IActionResult GetFileXmlBig(string Link, Guid idUser, Guid AuthKey, string LocalDir)
        {
            _filexml.GetFileXmlBig(Link, idUser, AuthKey, LocalDir);
            return Ok();
        }
        [HttpPost("AddPrivilage")]
        public IActionResult AddPrivilageToAccessXmlFile(Guid guid, int count)
        {
            _filexml.AddPrivilageToAccesGetFile(guid, count);
            return Ok();
        }
    }
}
