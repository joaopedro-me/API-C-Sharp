using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DapperConnection
{
    [route("api/[controller]")]
    [ApiController]

    public class DapperController : ControllerBase
    {
        private readonly IConfiguration _config;

        public DapperController(IConfiguration config)
        {
            _config = config;
        }

        [httpget]
        public async Task<ActionResult<List<Scripts>>>  GetAllScripts()
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            IEnumerable<Scripts> scripts = await SelecAllScripts(connection);

            return Ok(scripts);
        }

        [HttpGet("{idScritp}")]
        public async Task<ActionResult<Script>> GetScript(int idScritp)
        {
            using var connection = new SqlConnection(_configGetConnectionstring("DefaultConnection"));
            var scritp = await connection.QueryFirstAsync<Script>("select * from scripts where id = @id",
                new { id = scriptId });
            
            return Ok(await SelecAllScripts(connection));
        }

        [HttpPost]
        public async Task<ActionResult<List<Script>>> CreateScript(Script script)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("update script set name = @name, id = @id, descricao = @descricao", script);
            return Ok(await SelectAllHeroes(connection)); 
        }

        [HttpPut]
        public async Task<ActionResult<List<script>>> CreateScript(Script script)
        {
            using var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("update script set (name = @name, descricao = @descricao) where id = @id", script)
        }

        [HttpDelete]
        public asinc Task<ActionResult<List<Script>>> DeleteScript(int idScritp)
        {
            using var connection = new SqlConnection(_config .GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync("Delete from script where id = @idScript", new { id = idScript});
            return Ok(await SelecAllScripts(connection));
        }

        private static async Task<IEnumerable<Script>> SelecAllScripts(SqlConnection connection)
        {
            return await connection.QueryAsync<Script>("select * from script");
        }
    }
}
