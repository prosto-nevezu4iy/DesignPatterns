using Newtonsoft.Json;
using RealDependencies;
using System.Xml;

namespace StructuralPatterns.Adapter
{
    public class RecipeFinder : IAdaptsRecipesToJson
    {
        private readonly IRecipesApi _recipesApi;

        public RecipeFinder(IRecipesApi recipesApi)
        {
            _recipesApi = recipesApi;
        }

        public async Task<string> GetRecipeAsJson(string recipeName)
        {
            var recipeXml = await _recipesApi.MakeHttpRequestForRecipe(recipeName);
            var doc = new XmlDocument();
            doc.LoadXml(recipeXml);
            var jsonResult = JsonConvert.SerializeXmlNode(doc);
            return jsonResult;
        }
    }
}
