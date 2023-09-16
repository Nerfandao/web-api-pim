using Microsoft.AspNetCore.Mvc;
using TESTE_API.Entities;
using TESTE_API.Model;
using TESTE_API.ViewModel;

namespace TESTE_API.Controllers
{
    [ApiController]
    [Route("api/v1/funcionarios")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionariosRepository _funcionariosRepository;

        public FuncionariosController(IFuncionariosRepository funcionariosRepository)
        {
            _funcionariosRepository = funcionariosRepository;
        }

        [HttpPost]

        public IActionResult Add(FuncionariosViewModel funcionariosView)
        {
            var funcionarios = new Funcionarios(funcionariosView.IdFuncionario, funcionariosView.IdCargo, funcionariosView.Nome, funcionariosView.Telefone, funcionariosView.DataAdmissao, funcionariosView.Ctps, funcionariosView.SalarioBruto, funcionariosView.DataNascimento, funcionariosView.Banco, funcionariosView.Conta, funcionariosView.Cpf, funcionariosView.Email, funcionariosView.Ativo, funcionariosView.NomeSocial, funcionariosView.Genero, funcionariosView.Endereco);
            _funcionariosRepository.Add(funcionarios);

            return Ok(); 
        }

        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = _funcionariosRepository.Get();

            return Ok(funcionarios);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionariosRepository.Delete(id);

            return Ok();
        }
    }
}
