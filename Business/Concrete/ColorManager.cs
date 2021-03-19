using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [SecuredOperation("color.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }

        [SecuredOperation("color.delete,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>();
        }

        public IDataResult<List<Color>> GetById(int ColorId)
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(color => color.ColorId == ColorId));
        }

        [SecuredOperation("color.update,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.Updated);
        }
    }
}
