﻿using System;

namespace VirtoCommerce.Domain.Catalog.Model
{
    [Flags]
    public enum SearchResponseGroup
    {
        WithProducts = 1,
        WithCategories = 2,
        WithProperties = 4,
        WithCatalogs = 8,
		WithVariations = 16,
        WithPriceRanges = 32,
		Full = WithProducts | WithCategories | WithProperties | WithCatalogs | WithVariations | WithPriceRanges
    }
}