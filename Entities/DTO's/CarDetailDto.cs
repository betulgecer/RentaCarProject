﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO_s
{
    public class CarDetailDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public string ColorName { get; set; }
        public short ModelYear { get; set; }
        public string Description { get; set; }
        public decimal DailyPrice { get; set; }
        public List<string> ImagePath { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int? MinFindexScore { get; set; }
    }
}
