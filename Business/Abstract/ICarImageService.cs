﻿using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarImageService:IService<CarImage>
    {
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);
    }
}