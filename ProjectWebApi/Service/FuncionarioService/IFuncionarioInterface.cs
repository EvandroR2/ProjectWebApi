using ProjectWebApi.Models;

namespace ProjectWebApi.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();

        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionario(FuncionarioModel novoFuncionario);

        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionarios(FuncionarioModel editadoFuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionarios(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionarios(int id);

    }
}
