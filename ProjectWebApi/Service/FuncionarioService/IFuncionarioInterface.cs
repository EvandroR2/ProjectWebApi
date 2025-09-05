using ProjectWebApi.Models;

namespace ProjectWebApi.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncionarios();

        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncionarios(FuncionarioModel novoFuncionario);

        Task<ServiceResponse<FuncionarioModel>> GetFuncionarioById();

        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncionarios(FuncionarioModel editadoFuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncionarios(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncionarios(int id);

    }
}
