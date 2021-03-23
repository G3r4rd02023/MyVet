using MyVet.Data.Entities;
using MyVet.Models;
using System.Threading.Tasks;

namespace MyVet.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path, bool isNew);

        PetViewModel ToPetViewModel(Pet pet);

        Task<History> ToHistoryAsync(HistoryViewModel model, bool isNew);

        HistoryViewModel ToHistoryViewModel(History history);

    }
}
