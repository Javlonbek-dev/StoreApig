﻿using StoryAPI.Models;

namespace StoryAPI.DataAccess
{
    public interface IDataAccess
    {
        List<ProductCategory> GetProductCategories();

    }
}