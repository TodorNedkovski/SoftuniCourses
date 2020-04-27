﻿using AutoMapper;
using CarDealer.Dtos.Import;
using CarDealer.Models;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            this.CreateMap<Supplier, ImportSupplierDTO>();
            this.CreateMap<ImportSupplierDTO, Supplier>();
        }
    }
}
