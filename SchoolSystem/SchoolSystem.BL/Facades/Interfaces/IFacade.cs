﻿using DAL.Entities;
using SchoolSystem.BL.Models;

namespace SchoolSystem.BL.Facades.Interfaces;

public interface IFacade<TEntity, TListModel, TDetailModel>
    where TEntity : class, IEntity
    where TListModel : IModel
    where TDetailModel : class, IModel
{
    Task DeleteAsync(Guid id);

    Task<TDetailModel?> GetAsync(Guid id);

    Task<IEnumerable<TListModel>> GetAsync();

    Task<TDetailModel> SaveAsync(TDetailModel model);
}
