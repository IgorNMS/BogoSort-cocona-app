using Cocona;
using BogoSort.Services;

namespace BogoSort
{
    public class SortCommands
    {
        private readonly ISortService _sortService;
        private readonly IUtilStringService _stringService;

        public SortCommands(ISortService sortService, IUtilStringService stringService)
        {
            _sortService = sortService;
            _stringService = stringService;
        }
        [Command("sort")]
        public void Sort(string numbers)
        {
            var listNumber = _stringService.ToListInt(numbers);
            _sortService.BogoSort(listNumber);
        }
    }
}
