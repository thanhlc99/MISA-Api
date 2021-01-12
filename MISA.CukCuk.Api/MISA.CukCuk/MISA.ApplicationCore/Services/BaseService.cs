﻿using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity>
    {
        IBaseRepository<TEntity> _baseRepository;

        #region constructor
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        #endregion

        #region method
        public int Add(TEntity entity)
        {
            return _baseRepository.Add(entity);
        }

        public int Delete(Guid entityId)
        {
            return _baseRepository.Delete(entityId);
        }

        public IEnumerable<TEntity> GetEntities()
        {
            return _baseRepository.GetEntities();
        }

        public TEntity GetEntityById(Guid entityId)
        {
            return _baseRepository.GetEntityById(entityId);
        }

        public int Update(TEntity entity)
        {
            return _baseRepository.Update(entity);
        }
        #endregion
    }
}
