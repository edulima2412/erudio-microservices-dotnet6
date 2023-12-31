﻿using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICouponRepository
    {
        Task<CouponVO> GetCouponByCode(string couponCode, string token);
    }
}
