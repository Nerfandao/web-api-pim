using TESTE_API.Entities;

namespace TESTE_API.Model
{
    public interface IFuncionariosRepository
    {
        void Add(Funcionarios funcionarios);
        void Delete(int id);
        List<Funcionarios> Get();
    }
}
