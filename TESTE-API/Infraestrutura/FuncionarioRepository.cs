using TESTE_API.Entities;
using TESTE_API.Model;

namespace TESTE_API.Infraestrutura
{
    public class FuncionarioRepository : IFuncionariosRepository
    {

        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Funcionarios funcionarios)
        {
            _context.Funcionarios.Add(funcionarios);
            _context.SaveChanges();
        }

        public List<Funcionarios> Get()
        {
            return _context.Funcionarios.ToList();
        }

        public void Delete(int funcionarioId)
        {
            var funcionarioToDelete = _context.Funcionarios.Find(funcionarioId);

            if (funcionarioToDelete != null)
            {
                _context.Funcionarios.Remove(funcionarioToDelete);
                _context.SaveChanges();
            }
        }
    }
}
