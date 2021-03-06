﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingConstructorLib.models
{
    [Serializable]
    public abstract  class ParkingModelElement<T> where T: class
    {
        public abstract ParkingModelElementType GetElementType();

        public abstract T GetElementModel(); // Должна возвращать обьект с конретыми параметрами модели - изображение и тд.
    }

    [Serializable]
    public enum ParkingModelElementType
    {
        Grass,
        Road,
        TruckParkingSpace,
        ParkingSpace,
        Entry,
        Exit,
        Cashier
    }
}
