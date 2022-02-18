using HBWebApi.Entities.Models;
using System.Threading.Tasks;

namespace HBWebApi.Domain.ArrayLogic
{
    public interface ICalculateArray
    {
        Task<CharArrayResponse> Calculate(CharArray numbers);
    }
}