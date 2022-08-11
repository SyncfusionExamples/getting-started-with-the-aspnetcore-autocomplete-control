using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoCompleteExample.Pages
{
    public class GameDataModel
    {
        public string Name { get; set; }
        public string ID { get; set; }

        public List<GameDataModel> GetData()
        {
            List<GameDataModel> AutoCompleteData = new List<GameDataModel>()
            {
                 new GameDataModel() { ID= "Game1", Name= "Badminton" },
                 new GameDataModel() { ID= "Game2", Name= "Basketball" },
                 new GameDataModel() { ID= "Game3", Name= "Cricket" },
                 new GameDataModel() { ID= "Game4", Name= "Football" },
                 new GameDataModel() { ID= "Game5", Name= "Golf" },
                 new GameDataModel() { ID= "Game6", Name= "Hockey" },
                 new GameDataModel() { ID= "Game7", Name= "Tennis"}
            };
            return AutoCompleteData;
        }
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}