﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingConstructorLib.models
{
    public interface VehicleModel
    {
        List<ParkingModelElementType> GetAvailableElementTypesForMovement();

        int GetRequiredSize();
    }
}