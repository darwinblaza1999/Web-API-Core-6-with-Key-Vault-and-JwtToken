﻿using WatchCatalogAPI.Repository.Interface;

namespace WatchCatalogAPI.Repository.UnitofWork
{
    public interface IAdapter
    {
       // IGeneric<object> generic { get; }
        IWatch watch { get; }
    }
}