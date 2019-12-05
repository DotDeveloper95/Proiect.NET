﻿using System;
using System.Collections.Generic;
using SmartCity.WebApi.Models.Bus;
using SmartCity.WebApi.Models.BusRoute;
using SmartCity.WebApi.Models.BusStation;
using SmartCity.WebApi.Models.PointOfInterest;

namespace SmartCity.WebApi.Models.City
{
    public class UpdateCityModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<BusModel> Buses { get; set; }

        public List<BusStationModel> BusStations { get; set; }

        public List<BusRouteModel> BusRoutes { get; set; }

        public List<PointOfInterestModel> PointsOfInterests { get; set; }
    }
}
