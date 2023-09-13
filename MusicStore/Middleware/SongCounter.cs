using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
namespace MusicStore.Middelware

{
    public class SongCounter
    {
        private readonly ILogger<SongCounter> _logger;
        private readonly RequestDelegate _nexxt;

        public SongCounter(ILogger<SongCounter> logger, RequestDelegate nexxt)
        {
            _logger = logger;
            _nexxt = nexxt;
        }

        public async Task invoke(HttpContent ctx)
        {


        }
    }
}
