﻿namespace StructuralPatterns.Adapter;

public interface IAdaptsRecipesToJson
{
    public Task<string> GetRecipeAsJson(string recipeName);
}