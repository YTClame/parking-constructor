﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingConstructorLib.logic;
using ParkingConstructorLib.models;

namespace ParkingConstructorLib
{
    /// <summary>
    /// Конструктор парковки
    /// </summary>
    public class ParkingSceneConstructor<T> where T : class
    {
        public ParkingModel<T> ParkingModel { get; private set; }

        public ParkingSceneConstructor(ParkingModel<T> parkingModel = null)
        {
            if (parkingModel != null)
            {
                ParkingModel = parkingModel;
            }
        }

        public void CreateParkingModel(int columns, int rows, RoadDirections direction = RoadDirections.Bottom)
        {
            ParkingModel = new ParkingModel<T>(columns, rows)
            {
                RoadDirection = direction
            };
        }

        public void SetParkingModel(ParkingModel<T> parkingModel)
        {
            this.ParkingModel = parkingModel;
        }

        public void SetObjectToModel(int columnIndex, int rowIndex, ParkingModelElement<T> element)
        {
            ParkingModel.SetElement(columnIndex, rowIndex, element);
        }

        public bool IsParkingModelCreate() => ParkingModel != null;

        public void SetRoadDirection(RoadDirections roadDirection)
        {
            ParkingModel.RoadDirection = roadDirection;
        }

        public void ClearModel()
        {
            this.ParkingModel = null;
        }
    }
}