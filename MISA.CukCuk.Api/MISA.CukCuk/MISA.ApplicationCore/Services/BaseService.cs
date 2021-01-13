using MISA.ApplicationCore.Interfaces;
using MISA.ApplicationCore.Models;
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
        public virtual int Add(TEntity entity)
        {
            //thực hiện validate
            var isValidate = Validate(entity);
            if (isValidate)
            {
                return _baseRepository.Add(entity);
            }
            else
            {
                return 0;
            }
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

        private bool Validate(TEntity entity)
        {
            var isValidate = true;
            //đọc các property
            var properties = entity.GetType().GetProperties();
            foreach(var property in properties)
            {
                //kiểm tra xem có các attribute cần phải validate không
                if(property.IsDefined(typeof(Required),false))
                {
                    //check bắt buộc nhập
                    var propertyValue = property.GetValue(entity);
                    if(propertyValue == null)
                    {
                        isValidate = false;
                    }
                }
                else
                {
                    if(property.IsDefined(typeof(CheckDuplicate),false))
                    {
                        var entityDulicate = _baseRepository.GetEntityByProperty(property.Name,property.GetValue(entity));
                        if(entityDulicate!=null)
                        {
                            isValidate = false;
                        }    
                    }    
                }    
            }
            return isValidate;
        }
        #endregion
    }
}
